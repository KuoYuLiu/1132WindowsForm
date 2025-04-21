namespace HelloApp0421
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Hello, World!","First Windows Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (result == DialogResult.OK)
            {
                MessageBox.Show("You clicked OK");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked Cancel");
            }
        }
    }
}
