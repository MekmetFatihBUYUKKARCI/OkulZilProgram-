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
            label4.Text = "Tenefüs zili";
            label5.Text = "Öğrenci zili";
            label6.Text = "Öğretmen zili";

            button1.Text = "Düzenle";
            button2.Text = "Tören Araçları";
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

            ses = "C:\\Users\\sbuyu\\OneDrive\\Masaüstü\\OkulZilProgramı\\OkulZilProgramı\\zilSesleri\\Okul_Zili_Öğrenci_Zil_Sesi-(Çayır_Çimen_Geze_Geze).mp3";

            if (textBox1.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox2.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox3.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox4.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox5.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox6.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox7.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox8.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox9.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox10.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox11.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox12.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox13.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox14.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox15.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox16.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox17.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox18.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox19.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox20.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox21.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox22.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox23.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox24.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox25.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox26.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox27.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox28.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox29.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox30.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox31.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox32.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox33.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox34.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox35.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (textBox36.Text == label2.Text)
            {
                zilCal.URL = ses;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydedildi");

            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox3.BorderStyle = BorderStyle.None;
            textBox4.BorderStyle = BorderStyle.None;
            textBox5.BorderStyle = BorderStyle.None;
            textBox6.BorderStyle = BorderStyle.None;
            textBox7.BorderStyle = BorderStyle.None;
            textBox8.BorderStyle = BorderStyle.None;
            textBox9.BorderStyle = BorderStyle.None;
            textBox10.BorderStyle = BorderStyle.None;
            textBox11.BorderStyle = BorderStyle.None;
            textBox12.BorderStyle = BorderStyle.None;
            textBox13.BorderStyle = BorderStyle.None;
            textBox14.BorderStyle = BorderStyle.None;
            textBox15.BorderStyle = BorderStyle.None;
            textBox16.BorderStyle = BorderStyle.None;
            textBox17.BorderStyle = BorderStyle.None;
            textBox18.BorderStyle = BorderStyle.None;
            textBox19.BorderStyle = BorderStyle.None;
            textBox20.BorderStyle = BorderStyle.None;
            textBox21.BorderStyle = BorderStyle.None;
            textBox22.BorderStyle = BorderStyle.None;
            textBox23.BorderStyle = BorderStyle.None;
            textBox24.BorderStyle = BorderStyle.None;
            textBox25.BorderStyle = BorderStyle.None;
            textBox26.BorderStyle = BorderStyle.None;
            textBox27.BorderStyle = BorderStyle.None;
            textBox28.BorderStyle = BorderStyle.None;
            textBox29.BorderStyle = BorderStyle.None;
            textBox30.BorderStyle = BorderStyle.None;
            textBox31.BorderStyle = BorderStyle.None;
            textBox32.BorderStyle = BorderStyle.None;
            textBox33.BorderStyle = BorderStyle.None;
            textBox34.BorderStyle = BorderStyle.None;
            textBox35.BorderStyle = BorderStyle.None;
            textBox36.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Text = "Kaydet";

            textBox1.BorderStyle = BorderStyle.Fixed3D;
            textBox2.BorderStyle = BorderStyle.Fixed3D;
            textBox3.BorderStyle = BorderStyle.Fixed3D;
            textBox4.BorderStyle = BorderStyle.Fixed3D;
            textBox5.BorderStyle = BorderStyle.Fixed3D;
            textBox6.BorderStyle = BorderStyle.Fixed3D;
            textBox7.BorderStyle = BorderStyle.Fixed3D;
            textBox8.BorderStyle = BorderStyle.Fixed3D;
            textBox9.BorderStyle = BorderStyle.Fixed3D;
            textBox10.BorderStyle = BorderStyle.Fixed3D;
            textBox11.BorderStyle = BorderStyle.Fixed3D;
            textBox12.BorderStyle = BorderStyle.Fixed3D;
            textBox13.BorderStyle = BorderStyle.Fixed3D;
            textBox14.BorderStyle = BorderStyle.Fixed3D;
            textBox15.BorderStyle = BorderStyle.Fixed3D;
            textBox16.BorderStyle = BorderStyle.Fixed3D;
            textBox17.BorderStyle = BorderStyle.Fixed3D;
            textBox18.BorderStyle = BorderStyle.Fixed3D;
            textBox19.BorderStyle = BorderStyle.Fixed3D;
            textBox20.BorderStyle = BorderStyle.Fixed3D;
            textBox21.BorderStyle = BorderStyle.Fixed3D;
            textBox22.BorderStyle = BorderStyle.Fixed3D;
            textBox23.BorderStyle = BorderStyle.Fixed3D;
            textBox24.BorderStyle = BorderStyle.Fixed3D;
            textBox25.BorderStyle = BorderStyle.Fixed3D;
            textBox26.BorderStyle = BorderStyle.Fixed3D;
            textBox27.BorderStyle = BorderStyle.Fixed3D;
            textBox28.BorderStyle = BorderStyle.Fixed3D;
            textBox29.BorderStyle = BorderStyle.Fixed3D;
            textBox30.BorderStyle = BorderStyle.Fixed3D;
            textBox31.BorderStyle = BorderStyle.Fixed3D;
            textBox32.BorderStyle = BorderStyle.Fixed3D;
            textBox33.BorderStyle = BorderStyle.Fixed3D;
            textBox34.BorderStyle = BorderStyle.Fixed3D;
            textBox35.BorderStyle = BorderStyle.Fixed3D;
            textBox36.BorderStyle = BorderStyle.Fixed3D;
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
