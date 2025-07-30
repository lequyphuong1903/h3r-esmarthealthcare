#include <Adafruit_MLX90614.h>
Adafruit_MLX90614 mlx = Adafruit_MLX90614();

#define BUFFER_SIZE 64
#define START_BYTE 0x02
#define END_BYTE 0x03
#define LENGTH_BYTE 8
uint8_t buffer[BUFFER_SIZE];
volatile uint8_t head = 0;
volatile uint8_t tail = 0;
hw_timer_t *timer = NULL;

// Variables to store the sample data
volatile int16_t heartValue;
volatile int16_t breathValue;
volatile uint16_t t1;
volatile uint16_t t2;

volatile bool newSample = false;

void IRAM_ATTR onTimer() {
  heartValue = analogRead(A1); 
  breathValue = analogRead(A0);
  newSample = true; // Flag to indicate new sample is available
}

void setup() {
  Serial.begin(250000);
  timer = timerBegin(0, 80, true); // Timer 0, prescaler 80, count up
  timerAttachInterrupt(timer, &onTimer, true); // Attach the interrupt service routine
  timerAlarmWrite(timer, 10000, true); // Set the timer to trigger at 1000 ticks (2ms, 500Hz)
  timerAlarmEnable(timer); // Enable the timer
  mlx.begin();
}

void loop() {
  if (newSample) 
  {
    t1 = mlx.readRawAmbientTemp();
    t2 = mlx.readRawObjectTemp();
    processData(heartValue, breathValue, t1, t2);
    sendBuffer();
    newSample = false; // Reset the sample flag
  }
  
}

static bool bufferPush(uint8_t data) {
  uint8_t next = (head + 1) % BUFFER_SIZE;
  if (next != tail) {
    buffer[head] = data;
    head = next;
    return true;
  }
  return false; // Buffer is full
}

static bool bufferPop(uint8_t &data) {
  if (head != tail) {
    data = buffer[tail];
    tail = (tail + 1) % BUFFER_SIZE;
    return true;
  }
  return false; // Buffer is empty
}

static uint8_t calculateChecksum(uint8_t *data, uint8_t length) {
  uint8_t checksum = 0;
  for (uint8_t i = 0; i < length; i++) {
    checksum ^= data[i];
  }
  return checksum;
}

static void processData(int16_t value1, int16_t value2, uint16_t t1, uint16_t t2) {
  uint8_t data[8];
  data[0] = value1 & 0xFF;
  data[1] = (value1 >> 8) & 0xFF;
  data[2] = value2 & 0xFF;
  data[3] = (value2 >> 8) & 0xFF;
  data[4] = t1 & 0xFF;
  data[5] = (t1 >> 8) & 0xFF;
  data[6] = t2 & 0xFF;
  data[7] = (t2 >> 8) & 0xFF;

  bufferPush(START_BYTE);
  bufferPush(LENGTH_BYTE);
  for (uint8_t i = 0; i < LENGTH_BYTE; i++) {
    bufferPush(data[i]);
  }
  bufferPush(calculateChecksum(data, LENGTH_BYTE));
  bufferPush(END_BYTE);
}

void sendBuffer() {
  uint8_t data;
  while (bufferPop(data)) {
    Serial.write(data);
  }
}
