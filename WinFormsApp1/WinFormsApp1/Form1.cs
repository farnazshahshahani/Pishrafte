namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + "   " + e.Y.ToString());
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbly_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}