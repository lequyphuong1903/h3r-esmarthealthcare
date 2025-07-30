public class CircularBuffer
{
    private byte[] buffer;
    private int head;
    private int tail;
    private int capacity;
    private int count;

    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
        buffer = new byte[capacity];
        head = 0;
        tail = 0;
        count = 0;
    }

    public void Enqueue(byte item)
    {
        buffer[tail] = item;
        tail = (tail + 1) % capacity;
        if (count == capacity)
        {
            head = (head + 1) % capacity; // Overwrite the oldest data
        }
        else
        {
            count++;
        }
    }

    public byte Dequeue()
    {
        if (count == 0)
        {
            //throw new InvalidOperationException("Buffer is empty.");
        }

        byte item = buffer[head];
        head = (head + 1) % capacity;
        count--;
        return item;
    }

    public int Count
    {
        get { return count; }
    }

    public bool IsEmpty
    {
        get { return count == 0; }
    }
}