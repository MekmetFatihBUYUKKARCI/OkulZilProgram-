namespace OkulZilProgramı
{
    public partial class Form1 : Form
    {
        string ses;
        string o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12;
        string O1, O2, O3, O4, O5, O6, O7, O8, O9, O10, O11, O12;
        string t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = "alafen.jpeg";
            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;


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


            //program başladığında txt dosyalarındaki veriyi textBoxlara aktarma
            FileStream ogrenciDers_1 = new FileStream("ogrenciDers1.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__1 = new StreamReader(ogrenciDers_1); o1 = ogrenciDers__1.ReadLine(); ogrenciDers__1.Close();
            FileStream ogrenciDers_2 = new FileStream("ogrenciDers2.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__2 = new StreamReader(ogrenciDers_2); o2 = ogrenciDers__2.ReadLine(); ogrenciDers__2.Close();
            FileStream ogrenciDers_3 = new FileStream("ogrenciDers3.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__3 = new StreamReader(ogrenciDers_3); o3 = ogrenciDers__3.ReadLine(); ogrenciDers__3.Close();
            FileStream ogrenciDers_4 = new FileStream("ogrenciDers4.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__4 = new StreamReader(ogrenciDers_4); o4 = ogrenciDers__4.ReadLine(); ogrenciDers__4.Close();
            FileStream ogrenciDers_5 = new FileStream("ogrenciDers5.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__5 = new StreamReader(ogrenciDers_5); o5 = ogrenciDers__5.ReadLine(); ogrenciDers__5.Close();
            FileStream ogrenciDers_6 = new FileStream("ogrenciDers6.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__6 = new StreamReader(ogrenciDers_6); o6 = ogrenciDers__6.ReadLine(); ogrenciDers__6.Close();
            FileStream ogrenciDers_7 = new FileStream("ogrenciDers7.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__7 = new StreamReader(ogrenciDers_7); o7 = ogrenciDers__7.ReadLine(); ogrenciDers__7.Close();
            FileStream ogrenciDers_8 = new FileStream("ogrenciDers8.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__8 = new StreamReader(ogrenciDers_8); o8 = ogrenciDers__8.ReadLine(); ogrenciDers__8.Close();
            FileStream ogrenciDers_9 = new FileStream("ogrenciDers9.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__9 = new StreamReader(ogrenciDers_9); o9 = ogrenciDers__9.ReadLine(); ogrenciDers__9.Close();
            FileStream ogrenciDers_10 = new FileStream("ogrenciDers10.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__10 = new StreamReader(ogrenciDers_10); o10 = ogrenciDers__10.ReadLine(); ogrenciDers__10.Close();
            FileStream ogrenciDers_11 = new FileStream("ogrenciDers11.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__11 = new StreamReader(ogrenciDers_11); o11 = ogrenciDers__11.ReadLine(); ogrenciDers__11.Close();
            FileStream ogrenciDers_12 = new FileStream("ogrenciDers12.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__12 = new StreamReader(ogrenciDers_12); o12 = ogrenciDers__12.ReadLine(); ogrenciDers__12.Close();

            FileStream ogretmenDers_1 = new FileStream("ogretmenDers1.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__1 = new StreamReader(ogretmenDers_1); O1 = ogretmenDers__1.ReadLine(); ogretmenDers__1.Close();
            FileStream ogretmenDers_2 = new FileStream("ogretmenDers2.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__2 = new StreamReader(ogretmenDers_2); O2 = ogretmenDers__2.ReadLine(); ogretmenDers__2.Close();
            FileStream ogretmenDers_3 = new FileStream("ogretmenDers3.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__3 = new StreamReader(ogretmenDers_3); O3 = ogretmenDers__3.ReadLine(); ogretmenDers__3.Close();
            FileStream ogretmenDers_4 = new FileStream("ogretmenDers4.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__4 = new StreamReader(ogretmenDers_4); O4 = ogretmenDers__4.ReadLine(); ogretmenDers__4.Close();
            FileStream ogretmenDers_5 = new FileStream("ogretmenDers5.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__5 = new StreamReader(ogretmenDers_5); O5 = ogretmenDers__5.ReadLine(); ogretmenDers__5.Close();
            FileStream ogretmenDers_6 = new FileStream("ogretmenDers6.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__6 = new StreamReader(ogretmenDers_6); O6 = ogretmenDers__6.ReadLine(); ogretmenDers__6.Close();
            FileStream ogretmenDers_7 = new FileStream("ogretmenDers7.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__7 = new StreamReader(ogretmenDers_7); O7 = ogretmenDers__7.ReadLine(); ogretmenDers__7.Close();
            FileStream ogretmenDers_8 = new FileStream("ogretmenDers8.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__8 = new StreamReader(ogretmenDers_8); O8 = ogretmenDers__8.ReadLine(); ogretmenDers__8.Close();
            FileStream ogretmenDers_9 = new FileStream("ogretmenDers9.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__9 = new StreamReader(ogretmenDers_9); O9 = ogretmenDers__9.ReadLine(); ogretmenDers__9.Close();
            FileStream ogretmenDers_10 = new FileStream("ogretmenDers10.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__10 = new StreamReader(ogretmenDers_10); O10 = ogretmenDers__10.ReadLine(); ogretmenDers__10.Close();
            FileStream ogretmenDers_11 = new FileStream("ogretmenDers11.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__11 = new StreamReader(ogretmenDers_11); O11 = ogretmenDers__11.ReadLine(); ogretmenDers__11.Close();
            FileStream ogretmenDers_12 = new FileStream("ogretmenDers12.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__12 = new StreamReader(ogretmenDers_12); O12 = ogretmenDers__12.ReadLine(); ogretmenDers__12.Close();


            FileStream tenefusDers_1 = new FileStream("tenefusDers1.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__1 = new StreamReader(tenefusDers_1); t1 = tenefusDers__1.ReadLine(); tenefusDers__1.Close();
            FileStream tenefusDers_2 = new FileStream("tenefusDers2.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__2 = new StreamReader(tenefusDers_2); t2 = tenefusDers__2.ReadLine(); tenefusDers__2.Close();
            FileStream tenefusDers_3 = new FileStream("tenefusDers3.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__3 = new StreamReader(tenefusDers_3); t3 = tenefusDers__3.ReadLine(); tenefusDers__3.Close();
            FileStream tenefusDers_4 = new FileStream("tenefusDers4.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__4 = new StreamReader(tenefusDers_4); t4 = tenefusDers__4.ReadLine(); tenefusDers__4.Close();
            FileStream tenefusDers_5 = new FileStream("tenefusDers5.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__5 = new StreamReader(tenefusDers_5); t5 = tenefusDers__5.ReadLine(); tenefusDers__5.Close();
            FileStream tenefusDers_6 = new FileStream("tenefusDers6.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__6 = new StreamReader(tenefusDers_6); t6 = tenefusDers__6.ReadLine(); tenefusDers__6.Close();
            FileStream tenefusDers_7 = new FileStream("tenefusDers7.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__7 = new StreamReader(tenefusDers_7); t7 = tenefusDers__7.ReadLine(); tenefusDers__7.Close();
            FileStream tenefusDers_8 = new FileStream("tenefusDers8.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__8 = new StreamReader(tenefusDers_8); t8 = tenefusDers__8.ReadLine(); tenefusDers__8.Close();
            FileStream tenefusDers_9 = new FileStream("tenefusDers9.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__9 = new StreamReader(tenefusDers_9); t9 = tenefusDers__9.ReadLine(); tenefusDers__9.Close();
            FileStream tenefusDers_10 = new FileStream("tenefusDers10.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__10 = new StreamReader(tenefusDers_10); t10 = tenefusDers__10.ReadLine(); tenefusDers__10.Close();
            FileStream tenefusDers_11 = new FileStream("tenefusDers11.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__11 = new StreamReader(tenefusDers_11); t11 = tenefusDers__11.ReadLine(); tenefusDers__11.Close();
            FileStream tenefusDers_12 = new FileStream("tenefusDers12.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__12 = new StreamReader(tenefusDers_12); t12 = tenefusDers__12.ReadLine(); tenefusDers__12.Close();



        }


        torenAraclari TorenAraclari = new torenAraclari();
        private void button2_Click(object sender, EventArgs e)
        {
            TorenAraclari.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();

            ses = "Okul_Zili_Öğrenci_Zil_Sesi-(Çayır_Çimen_Geze_Geze).mp3";





            // textBoxlardaki zaman konrtolünü yapar
            if (o1 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o2 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o3 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o4 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o5 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o6 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o7 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o8 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o9 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o10 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o11 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (o12 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O12 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O11 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O10 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O9 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O8 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O7 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O6 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O5 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O4 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O3 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O2 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (O1 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t12 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t11 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t10 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t9 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t8 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t7 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t6 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t5 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t4 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t3 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t2 == label2.Text)
            {
                zilCal.URL = ses;
            }
            if (t1 == label2.Text)
            {
                zilCal.URL = ses;
            }


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // textBoxu kilitleme 
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

            //******************************************************************************************************************************************

            MessageBox.Show("Kaydedildi", "Dosya Kayıt İslemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // textBox taki verileri txt dosyalarına aktarma
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

            //******************************************************************************************************************************************

            //txt dosyalarındaki veriyi textBoxlara aktarma
            FileStream ogrenciDers_1 = new FileStream("ogrenciDers1.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__1 = new StreamReader(ogrenciDers_1); o1 = ogrenciDers__1.ReadLine(); ogrenciDers__1.Close();
            FileStream ogrenciDers_2 = new FileStream("ogrenciDers2.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__2 = new StreamReader(ogrenciDers_2); o2 = ogrenciDers__2.ReadLine(); ogrenciDers__2.Close();
            FileStream ogrenciDers_3 = new FileStream("ogrenciDers3.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__3 = new StreamReader(ogrenciDers_3); o3 = ogrenciDers__3.ReadLine(); ogrenciDers__3.Close();
            FileStream ogrenciDers_4 = new FileStream("ogrenciDers4.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__4 = new StreamReader(ogrenciDers_4); o4 = ogrenciDers__4.ReadLine(); ogrenciDers__4.Close();
            FileStream ogrenciDers_5 = new FileStream("ogrenciDers5.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__5 = new StreamReader(ogrenciDers_5); o5 = ogrenciDers__5.ReadLine(); ogrenciDers__5.Close();
            FileStream ogrenciDers_6 = new FileStream("ogrenciDers6.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__6 = new StreamReader(ogrenciDers_6); o6 = ogrenciDers__6.ReadLine(); ogrenciDers__6.Close();
            FileStream ogrenciDers_7 = new FileStream("ogrenciDers7.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__7 = new StreamReader(ogrenciDers_7); o7 = ogrenciDers__7.ReadLine(); ogrenciDers__7.Close();
            FileStream ogrenciDers_8 = new FileStream("ogrenciDers8.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__8 = new StreamReader(ogrenciDers_8); o8 = ogrenciDers__8.ReadLine(); ogrenciDers__8.Close();
            FileStream ogrenciDers_9 = new FileStream("ogrenciDers9.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__9 = new StreamReader(ogrenciDers_9); o9 = ogrenciDers__9.ReadLine(); ogrenciDers__9.Close();
            FileStream ogrenciDers_10 = new FileStream("ogrenciDers10.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__10 = new StreamReader(ogrenciDers_10); o10 = ogrenciDers__10.ReadLine(); ogrenciDers__10.Close();
            FileStream ogrenciDers_11 = new FileStream("ogrenciDers11.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__11 = new StreamReader(ogrenciDers_11); o11 = ogrenciDers__11.ReadLine(); ogrenciDers__11.Close();
            FileStream ogrenciDers_12 = new FileStream("ogrenciDers12.txt", FileMode.Open, FileAccess.Read); StreamReader ogrenciDers__12 = new StreamReader(ogrenciDers_12); o12 = ogrenciDers__12.ReadLine(); ogrenciDers__12.Close();


            FileStream ogretmenDers_1 = new FileStream("ogretmenDers1.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__1 = new StreamReader(ogretmenDers_1); O1 = ogretmenDers__1.ReadLine(); ogretmenDers__1.Close();
            FileStream ogretmenDers_2 = new FileStream("ogretmenDers2.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__2 = new StreamReader(ogretmenDers_2); O2 = ogretmenDers__2.ReadLine(); ogretmenDers__2.Close();
            FileStream ogretmenDers_3 = new FileStream("ogretmenDers3.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__3 = new StreamReader(ogretmenDers_3); O3 = ogretmenDers__3.ReadLine(); ogretmenDers__3.Close();
            FileStream ogretmenDers_4 = new FileStream("ogretmenDers4.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__4 = new StreamReader(ogretmenDers_4); O4 = ogretmenDers__4.ReadLine(); ogretmenDers__4.Close();
            FileStream ogretmenDers_5 = new FileStream("ogretmenDers5.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__5 = new StreamReader(ogretmenDers_5); O5 = ogretmenDers__5.ReadLine(); ogretmenDers__5.Close();
            FileStream ogretmenDers_6 = new FileStream("ogretmenDers6.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__6 = new StreamReader(ogretmenDers_6); O6 = ogretmenDers__6.ReadLine(); ogretmenDers__6.Close();
            FileStream ogretmenDers_7 = new FileStream("ogretmenDers7.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__7 = new StreamReader(ogretmenDers_7); O7 = ogretmenDers__7.ReadLine(); ogretmenDers__7.Close();
            FileStream ogretmenDers_8 = new FileStream("ogretmenDers8.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__8 = new StreamReader(ogretmenDers_8); O8 = ogretmenDers__8.ReadLine(); ogretmenDers__8.Close();
            FileStream ogretmenDers_9 = new FileStream("ogretmenDers9.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__9 = new StreamReader(ogretmenDers_9); O9 = ogretmenDers__9.ReadLine(); ogretmenDers__9.Close();
            FileStream ogretmenDers_10 = new FileStream("ogretmenDers10.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__10 = new StreamReader(ogretmenDers_10); O10 = ogretmenDers__10.ReadLine(); ogretmenDers__10.Close();
            FileStream ogretmenDers_11 = new FileStream("ogretmenDers11.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__11 = new StreamReader(ogretmenDers_11); O11 = ogretmenDers__11.ReadLine(); ogretmenDers__11.Close();
            FileStream ogretmenDers_12 = new FileStream("ogretmenDers12.txt", FileMode.Open, FileAccess.Read); StreamReader ogretmenDers__12 = new StreamReader(ogretmenDers_12); O12 = ogretmenDers__12.ReadLine(); ogretmenDers__12.Close();


            FileStream tenefusDers_1 = new FileStream("tenefusDers1.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__1 = new StreamReader(tenefusDers_1); t1 = tenefusDers__1.ReadLine(); tenefusDers__1.Close();
            FileStream tenefusDers_2 = new FileStream("tenefusDers2.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__2 = new StreamReader(tenefusDers_2); t2 = tenefusDers__2.ReadLine(); tenefusDers__2.Close();
            FileStream tenefusDers_3 = new FileStream("tenefusDers3.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__3 = new StreamReader(tenefusDers_3); t3 = tenefusDers__3.ReadLine(); tenefusDers__3.Close();
            FileStream tenefusDers_4 = new FileStream("tenefusDers4.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__4 = new StreamReader(tenefusDers_4); t4 = tenefusDers__4.ReadLine(); tenefusDers__4.Close();
            FileStream tenefusDers_5 = new FileStream("tenefusDers5.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__5 = new StreamReader(tenefusDers_5); t5 = tenefusDers__5.ReadLine(); tenefusDers__5.Close();
            FileStream tenefusDers_6 = new FileStream("tenefusDers6.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__6 = new StreamReader(tenefusDers_6); t6 = tenefusDers__6.ReadLine(); tenefusDers__6.Close();
            FileStream tenefusDers_7 = new FileStream("tenefusDers7.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__7 = new StreamReader(tenefusDers_7); t7 = tenefusDers__7.ReadLine(); tenefusDers__7.Close();
            FileStream tenefusDers_8 = new FileStream("tenefusDers8.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__8 = new StreamReader(tenefusDers_8); t8 = tenefusDers__8.ReadLine(); tenefusDers__8.Close();
            FileStream tenefusDers_9 = new FileStream("tenefusDers9.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__9 = new StreamReader(tenefusDers_9); t9 = tenefusDers__9.ReadLine(); tenefusDers__9.Close();
            FileStream tenefusDers_10 = new FileStream("tenefusDers10.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__10 = new StreamReader(tenefusDers_10); t10 = tenefusDers__10.ReadLine(); tenefusDers__10.Close();
            FileStream tenefusDers_11 = new FileStream("tenefusDers11.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__11 = new StreamReader(tenefusDers_11); t11 = tenefusDers__11.ReadLine(); tenefusDers__11.Close();
            FileStream tenefusDers_12 = new FileStream("tenefusDers12.txt", FileMode.Open, FileAccess.Read); StreamReader tenefusDers__12 = new StreamReader(tenefusDers_12); t12 = tenefusDers__12.ReadLine(); tenefusDers__12.Close();

            //******************************************************************************************************************************************

            // textBoxların kenarlıklarını silme
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


            // textBoxların kilitlerini açma
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

            // textBoxlara kenarlık ekleme
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
