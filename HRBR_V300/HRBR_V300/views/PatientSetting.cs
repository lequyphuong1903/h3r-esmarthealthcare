using HRBR_V300.utils;

namespace HRBR_V300.views
{
    public partial class PatientSetting : Form
    {
        public PatientSetting()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
                Patient.name = "N/A";
            else
                Patient.name = nameTxt.Text;

            if (ageTxt.Text == "")
                Patient.age = "N/A";
            else
                Patient.age = ageTxt.Text;

            if (idTxt.Text == "")
                Patient.id = "N/A";
            else
                Patient.id = idTxt.Text;

            if (heightTxt.Text == "")
                Patient.height = "N/A";
            else
                Patient.height = heightTxt.Text;
            if (weightTxt.Text == "")
                Patient.weight = "N/A";
            else
                Patient.weight = weightTxt.Text;
            MessageBox.Show("Save successfully!");
            this.Close();
            this.Dispose();
        }
    }
}
