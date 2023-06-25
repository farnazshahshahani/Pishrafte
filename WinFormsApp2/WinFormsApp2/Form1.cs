namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MultilineChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("admin") && txtpass.Text.Equals("admin"))
            
            {
                MessageBox.Show("Ê—Êœ „Ê›ﬁ");
                Main mainform = new Main();
                mainform.Show();
            } 
            else
            {
                MessageBox.Show("Ê—Êœ ‰«„Ê›ﬁ");
            }
        }
    }
}