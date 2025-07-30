using System.Threading.Tasks;
using FireSharp.Interfaces;
using FireSharp.Response;
using HRBR_V300.utils;
using ScottPlot;
using Color = ScottPlot.Color;

namespace HRBR_V300
{
    public partial class DashBoardControl : UserControl
    {
        private List<int> listHR = new List<int>();
        private List<int> listBR = new List<int>();
        private List<float> listT1 = new List<float>();
        private List<float> listT2 = new List<float>();
        private List<string> dateTime = new List<string>();

        private ScottPlot.Plottables.Scatter? sigHR;
        private ScottPlot.Plottables.Scatter? sigBR;
        private ScottPlot.Plottables.Scatter? sigT;
        
        private float[] HR = new float[24];
        private float[] BR = new float[24];
        private float[] T1 = new float[24];
        private float[] T2 = new float[24];
        private int[] indexList = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23 };
        private int index = 0;
        public DashBoardControl()
        {
            InitializeComponent();
            hrDB.Plot.Axes.SetLimits(0, 23, 30, 120);
            hrDB.Interaction.Disable();
            hrDB.Plot.FigureBackground.Color = Color.FromHex("#07263b");
            hrDB.Plot.DataBackground.Color = Color.FromHex("#0b3049");
            hrDB.Plot.Axes.Color(Color.FromHex("#a0acb5"));
            sigHR = hrDB.Plot.Add.Scatter(indexList,HR);
            sigHR.LineWidth = 0;
            sigHR.MarkerSize = 10;
            sigHR.Color = Colors.Yellow;


            brDB.Plot.Axes.SetLimits(0, 23, 5, 30);
            brDB.Plot.FigureBackground.Color = Color.FromHex("#07263b");
            brDB.Plot.DataBackground.Color = Color.FromHex("#0b3049");
            brDB.Plot.Axes.Color(Color.FromHex("#a0acb5"));
            brDB.Interaction.Disable();
            sigBR = brDB.Plot.Add.Scatter(indexList, BR);
            sigBR.MarkerSize = 10;
            sigBR.LineWidth = 0;
            sigBR.Color = Colors.Pink;

            tDB.Plot.Axes.SetLimits(0, 23, 20, 40);
            tDB.Plot.FigureBackground.Color = Color.FromHex("#07263b");
            tDB.Plot.DataBackground.Color = Color.FromHex("#0b3049");
            tDB.Plot.Axes.Color(Color.FromHex("#a0acb5"));
            tDB.Interaction.Disable();
            sigT = tDB.Plot.Add.Scatter(indexList, T1);
            sigT = tDB.Plot.Add.Scatter(indexList, T2);
            sigT.LineWidth = 0;
            sigT.MarkerSize = 10;
        }
        public async Task UpdatePlot(float hr, float br, float t1, float t2, bool isRecord, IFirebaseClient client)
        {
            var data = new Data
            {
                HR = ((int)hr).ToString(),
                BR = ((int)br).ToString(),
                Temp1 = ((int)t1).ToString(),
                Temp2 = ((int)t2).ToString(),
                Time = DateTime.Now.ToString("yyyy:MM:dd:HH:mm:ss")
            };
            SetResponse response = await client.SetTaskAsync(Auth.UID +"/", data);
            var result = response.ResultAs<Data>();
            if (isRecord)
            {
                listHR.Add((int)hr); 
                listBR.Add((int)br);
                listT1.Add((int)t1);
                listT2.Add((int)t2);   
                dateTime.Add(DateTime.Now.ToString("yyyy:MM:dd:HH:mm:ss"));
            }
            if (index == HR.Length)
            {
                for (int i = 1; i < HR.Length; i++)
                {
                    HR[i - 1] = HR[i];
                    BR[i - 1] = BR[i];
                    T1[i - 1] = T1[i];
                    T2[i - 1] = T2[i];
                }
                HR[HR.Length - 1] = hr;
                BR[BR.Length - 1] = br;
                T1[T1.Length - 1] = t1;
                T2[T2.Length - 1] = t2;
            }
            else
            {
                HR[index] = hr;
                BR[index] = br;
                T1[index] = t1;
                T2[index] = t2;
                index++;
            }
            hrDB.Invoke((MethodInvoker)delegate
            {
                hrDB.Refresh();
            });
            brDB.Invoke((MethodInvoker)delegate
            {
                brDB.Refresh();
            });
            tDB.Invoke((MethodInvoker)delegate
            {
                tDB.Refresh();
            });
        }
        public void SaveCSV()
        {
            List<List<object>> data = new List<List<object>>
            {
                dateTime.Cast<object>().ToList(),
                listHR.Cast<object>().ToList(),
                listBR.Cast<object>().ToList(),
                listT1.Cast<object>().ToList(),
                listT2.Cast<object>().ToList()
            };
            data.RemoveAt(0);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save CSV File";
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.FileName = "lists_output.csv";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    string csvFilePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        writer.WriteLine("Time,HR,BR,T1,T2");

                        int numRows = listHR.Count;
                        for (int i = 0; i < numRows; i++)
                        {
                            string row = string.Join(",", new string[] {
                                dateTime[i],
                                listHR[i].ToString(),
                                listBR[i].ToString(),
                                listT1[i].ToString(),
                                listT2[i].ToString()
                            });
                            writer.WriteLine(row);
                        }
                    }

                    dateTime.Clear();
                    listHR.Clear();
                    listBR.Clear();
                    listT1.Clear();
                    listT2.Clear();
                    MessageBox.Show("Save successfully.");
                }
                else
                {
                    MessageBox.Show("Operation canceled.");
                }
            }
        }
    }
}
