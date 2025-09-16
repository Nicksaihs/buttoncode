namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "red light";
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BackgroundImage = Properties.Resources._5a33d4978e43d87aa1c5f02c66bae69f01217718;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "green light";
            pictureBox1.BackColor = Color.Green;
            pictureBox1.BackgroundImage = Properties.Resources._2b3f6ff00db7a1efae21d85cfb8995eaff2da8d8;
        }


    }
}
