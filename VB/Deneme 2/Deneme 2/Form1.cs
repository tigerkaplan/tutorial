namespace Deneme_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Merhaba H�sniye - " + DateTime.Now.ToString();
        }
    }
}