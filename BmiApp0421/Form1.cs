namespace BmiApp0421
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(heightTxt.Text) || string.IsNullOrEmpty(weightTxt.Text))
            {
                MessageBox.Show("Please enter both height and weight.");
                return;
            }
            double height = double.Parse(heightTxt.Text);
            double weight = double.Parse(weightTxt.Text);
            double heightInMeters = height / 100; // Convert height from cm to meters
            double bmi = weight / (heightInMeters * heightInMeters); // Calculate BMI
            bmiResult.Text = "Your BMI = " + bmi.ToString("F2"); // Display BMI with 2 decimal places
            if (bmi < 18.5)
            {
                pictureBox1.Image = Properties.Resources.bmi_lv1; // Assuming you have an image named Underweight.png in your resources
            }
            else if (bmi >= 18.5 && bmi < 24.5)
            {
                pictureBox1.Image = Properties.Resources.bmi_lv2;
            }
            else if (bmi >= 24.5 && bmi < 29.5)
            {
                pictureBox1.Image = Properties.Resources.bmi_lv3;
            }
            else if (bmi >= 29.5 && bmi < 34.9)
            {
                pictureBox1.Image = Properties.Resources.bmi_lv4;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.bmi_lv5;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            heightTxt.Clear();
            weightTxt.Clear();
        }
    }
}
