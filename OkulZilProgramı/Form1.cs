namespace OkulZilProgramı
{
    public partial class Form1 : Form
    {
        string ses;
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
            label5.Text = "Öğrenci zili";
            label6.Text = "Öğretmen zili";

            button1.Text = "Düzenle";
            button2.Text = "Tören Araçları";
            button3.Text = "Zil Sesleri";
            button4.Text = "Kaydet";

            label7.Text = "Ders1: ";
            label8.Text = "Ders2: ";
            label9.Text = "Ders3: ";
            label10.Text = "Ders6: ";
            label11.Text = "Ders5: ";
            label12.Text = "Ders4: ";
            label13.Text = "Ders9: ";
            label14.Text = "Ders8: ";
            label15.Text = "Ders7: ";
            label16.Text = "Ders12: ";
            label17.Text = "Ders11: ";
            label18.Text = "Ders10: ";

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

            if (maskedTextBox1.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox2.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox3.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox4.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox5.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox6.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox7.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox8.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox9.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox10.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox11.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox12.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox13.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox14.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox15.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox16.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox17.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox18.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox19.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox20.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox21.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox22.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox23.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (maskedTextBox24.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = "Kaydedildi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Text = "Kaydet";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
