namespace OkulZilProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Mehmet Fatih BÜYÜKKARCI - Hasan DUYAR";
            button1.Text = "Zil Oluştur";
            button2.Text = "Tören Araçları";
            button3.Text = "Zil Sesleri";
        }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        torenAraclari TorenAraclari = new torenAraclari();
        private void button2_Click(object sender, EventArgs e)
        {
            TorenAraclari.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }
    }
}
