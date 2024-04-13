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


            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox14.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox16.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox19.ReadOnly = true;
            textBox20.ReadOnly = true;
            textBox21.ReadOnly = true;
            textBox22.ReadOnly = true;
            textBox23.ReadOnly = true;
            textBox24.ReadOnly = true;
            textBox25.ReadOnly = true;
            textBox26.ReadOnly = true;
            textBox27.ReadOnly = true;
            textBox28.ReadOnly = true;
            textBox29.ReadOnly = true;
            textBox30.ReadOnly = true;
            textBox31.ReadOnly = true;
            textBox32.ReadOnly = true;
            textBox33.ReadOnly = true;
            textBox34.ReadOnly = true;
            textBox35.ReadOnly = true;
            textBox36.ReadOnly = true;




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
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox14.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox16.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox19.ReadOnly = true;
            textBox20.ReadOnly = true;
            textBox21.ReadOnly = true;
            textBox22.ReadOnly = true;
            textBox23.ReadOnly = true;
            textBox24.ReadOnly = true;
            textBox25.ReadOnly = true;
            textBox26.ReadOnly = true;
            textBox27.ReadOnly = true;
            textBox28.ReadOnly = true;
            textBox29.ReadOnly = true;
            textBox30.ReadOnly = true;
            textBox31.ReadOnly = true;
            textBox32.ReadOnly = true;
            textBox33.ReadOnly = true;
            textBox34.ReadOnly = true;
            textBox35.ReadOnly = true;
            textBox36.ReadOnly = true;


            MessageBox.Show("Kaydedildi");

            StreamWriter ogrenciDers1 = new StreamWriter("ogrenciDers1.txt"); ogrenciDers1.WriteLine(textBox1.Text); ogrenciDers1.Close();
            StreamWriter ogrenciDers2 = new StreamWriter("ogrenciDers2.txt"); ogrenciDers2.WriteLine(textBox2.Text); ogrenciDers2.Close();
            StreamWriter ogrenciDers3 = new StreamWriter("ogrenciDers3.txt"); ogrenciDers3.WriteLine(textBox3.Text); ogrenciDers3.Close();
            StreamWriter ogrenciDers4 = new StreamWriter("ogrenciDers4.txt"); ogrenciDers4.WriteLine(textBox4.Text); ogrenciDers4.Close();
            StreamWriter ogrenciDers5 = new StreamWriter("ogrenciDers5.txt"); ogrenciDers5.WriteLine(textBox5.Text); ogrenciDers5.Close();
            StreamWriter ogrenciDers6 = new StreamWriter("ogrenciDers6.txt"); ogrenciDers6.WriteLine(textBox6.Text); ogrenciDers6.Close();
            StreamWriter ogrenciDers7 = new StreamWriter("ogrenciDers7.txt"); ogrenciDers7.WriteLine(textBox7.Text); ogrenciDers7.Close();
            StreamWriter ogrenciDers8 = new StreamWriter("ogrenciDers8.txt"); ogrenciDers8.WriteLine(textBox8.Text); ogrenciDers8.Close();
            StreamWriter ogrenciDers9 = new StreamWriter("ogrenciDers9.txt"); ogrenciDers9.WriteLine(textBox9.Text); ogrenciDers9.Close();
            StreamWriter ogrenciDers10 = new StreamWriter("ogrenciDers10.txt"); ogrenciDers10.WriteLine(textBox10.Text); ogrenciDers10.Close();
            StreamWriter ogrenciDers11 = new StreamWriter("ogrenciDers11.txt"); ogrenciDers11.WriteLine(textBox11.Text); ogrenciDers11.Close();
            StreamWriter ogrenciDers12 = new StreamWriter("ogrenciDers12.txt"); ogrenciDers12.WriteLine(textBox12.Text); ogrenciDers12.Close();


            StreamWriter ogretmenDers1 = new StreamWriter("ogretmenDers1.txt"); ogretmenDers1.WriteLine(textBox24.Text); ogretmenDers1.Close();
            StreamWriter ogretmenDers2 = new StreamWriter("ogretmenDers2.txt"); ogretmenDers2.WriteLine(textBox23.Text); ogretmenDers2.Close();
            StreamWriter ogretmenDers3 = new StreamWriter("ogretmenDers3.txt"); ogretmenDers3.WriteLine(textBox22.Text); ogretmenDers3.Close();
            StreamWriter ogretmenDers4 = new StreamWriter("ogretmenDers4.txt"); ogretmenDers4.WriteLine(textBox21.Text); ogretmenDers4.Close();
            StreamWriter ogretmenDers5 = new StreamWriter("ogretmenDers5.txt"); ogretmenDers5.WriteLine(textBox20.Text); ogretmenDers5.Close();
            StreamWriter ogretmenDers6 = new StreamWriter("ogretmenDers6.txt"); ogretmenDers6.WriteLine(textBox19.Text); ogretmenDers6.Close();
            StreamWriter ogretmenDers7 = new StreamWriter("ogretmenDers7.txt"); ogretmenDers7.WriteLine(textBox18.Text); ogretmenDers7.Close();
            StreamWriter ogretmenDers8 = new StreamWriter("ogretmenDers8.txt"); ogretmenDers8.WriteLine(textBox17.Text); ogretmenDers8.Close();
            StreamWriter ogretmenDers9 = new StreamWriter("ogretmenDers9.txt"); ogretmenDers9.WriteLine(textBox16.Text); ogretmenDers9.Close();
            StreamWriter ogretmenDers10 = new StreamWriter("ogretmenDers10.txt"); ogretmenDers10.WriteLine(textBox15.Text); ogretmenDers10.Close();
            StreamWriter ogretmenDers11 = new StreamWriter("ogretmenDers11.txt"); ogretmenDers11.WriteLine(textBox14.Text); ogretmenDers11.Close();
            StreamWriter ogretmenDers12 = new StreamWriter("ogretmenDers12.txt"); ogretmenDers12.WriteLine(textBox13.Text); ogretmenDers12.Close();


            StreamWriter tenefusDers1 = new StreamWriter("tenefusDers1.txt"); tenefusDers1.WriteLine(textBox36.Text); tenefusDers1.Close();
            StreamWriter tenefusDers2 = new StreamWriter("tenefusDers2.txt"); tenefusDers2.WriteLine(textBox35.Text); tenefusDers2.Close();
            StreamWriter tenefusDers3 = new StreamWriter("tenefusDers3.txt"); tenefusDers3.WriteLine(textBox34.Text); tenefusDers3.Close();
            StreamWriter tenefusDers4 = new StreamWriter("tenefusDers4.txt"); tenefusDers4.WriteLine(textBox33.Text); tenefusDers4.Close();
            StreamWriter tenefusDers5 = new StreamWriter("tenefusDers5.txt"); tenefusDers5.WriteLine(textBox32.Text); tenefusDers5.Close();
            StreamWriter tenefusDers6 = new StreamWriter("tenefusDers6.txt"); tenefusDers6.WriteLine(textBox31.Text); tenefusDers6.Close();
            StreamWriter tenefusDers7 = new StreamWriter("tenefusDers7.txt"); tenefusDers7.WriteLine(textBox30.Text); tenefusDers7.Close();
            StreamWriter tenefusDers8 = new StreamWriter("tenefusDers8.txt"); tenefusDers8.WriteLine(textBox29.Text); tenefusDers8.Close();
            StreamWriter tenefusDers9 = new StreamWriter("tenefusDers9.txt"); tenefusDers9.WriteLine(textBox28.Text); tenefusDers9.Close();
            StreamWriter tenefusDers10 = new StreamWriter("tenefusDers10.txt"); tenefusDers10.WriteLine(textBox27.Text); tenefusDers10.Close();
            StreamWriter tenefusDers11 = new StreamWriter("tenefusDers11.txt"); tenefusDers11.WriteLine(textBox26.Text); tenefusDers11.Close();
            StreamWriter tenefusDers12 = new StreamWriter("tenefusDers12.txt"); tenefusDers12.WriteLine(textBox25.Text); tenefusDers12.Close();




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

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;
            textBox11.ReadOnly = false;
            textBox12.ReadOnly = false;
            textBox13.ReadOnly = false;
            textBox14.ReadOnly = false;
            textBox15.ReadOnly = false;
            textBox16.ReadOnly = false;
            textBox17.ReadOnly = false;
            textBox18.ReadOnly = false;
            textBox19.ReadOnly = false;
            textBox20.ReadOnly = false;
            textBox21.ReadOnly = false;
            textBox22.ReadOnly = false;
            textBox23.ReadOnly = false;
            textBox24.ReadOnly = false;
            textBox25.ReadOnly = false;
            textBox26.ReadOnly = false;
            textBox27.ReadOnly = false;
            textBox28.ReadOnly = false;
            textBox29.ReadOnly = false;
            textBox30.ReadOnly = false;
            textBox31.ReadOnly = false;
            textBox32.ReadOnly = false;
            textBox33.ReadOnly = false;
            textBox34.ReadOnly = false;
            textBox35.ReadOnly = false;
            textBox36.ReadOnly = false;

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
