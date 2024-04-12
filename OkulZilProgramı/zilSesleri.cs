using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulZilProgramı
{
    public partial class zilSesleri : Form
    {
        public zilSesleri()
        {
            InitializeComponent();
        }

        private void zilSesleri_Load(object sender, EventArgs e)
        {
            button1.Text = "EBA_Teneffüs_Müziği_İyi_Kalite";
            button2.Text = "Okul_zili_hababam_sınıfı";
            button3.Text = "Okul_Zili_Öğrenci_Zil_Sesi-(Çayır_Çimen_Geze_Geze)";
            button4.Text = "Okul_Zili_Öğrenci_Zil_Sesi_(Barış_Manço_Anlıyorsun_Değil_Mi)";

            label1.Text = "Zil seslerinden birini seçiniz";
        }

        string audio;

        private void button1_Click(object sender, EventArgs e)
        {
            audio = "C:\\Users\\sbuyu\\OneDrive\\Masaüstü\\OkulZilProgramı\\OkulZilProgramı\\zilSesleri\\EBA_Teneffüs_Müziği_İyi_Kalite.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            audio = "C:\\Users\\sbuyu\\OneDrive\\Masaüstü\\OkulZilProgramı\\OkulZilProgramı\\zilSesleri\\Okul_zili_hababam_sınıfı.mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            audio = "C:\\Users\\sbuyu\\OneDrive\\Masaüstü\\OkulZilProgramı\\OkulZilProgramı\\zilSesleri\\Okul_Zili_Öğrenci_Zil_Sesi-(Çayır_Çimen_Geze_Geze).mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            audio = "C:\\Users\\sbuyu\\OneDrive\\Masaüstü\\OkulZilProgramı\\OkulZilProgramı\\zilSesleri\\Okul_Zili_Öğrenci_Zil_Sesi_(Barış_Manço_Anlıyorsun_Değil_Mi).mp3";
        }
        
    }
}
