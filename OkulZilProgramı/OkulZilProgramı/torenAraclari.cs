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
    public partial class torenAraclari : Form
    {
        public torenAraclari()
        {
            InitializeComponent();
        }

        private void torenAraclari_Load(object sender, EventArgs e)
        {
            button1.Text = "Saygı duruşu 1dk";
            button2.Text = "Saygı duruşu 2dk";
            button3.Text = "İstiklal Marşı";
        }

        // knk sen çıktı alırken dosya yollarıı ayarlarsın

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "1dk.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "2dk.mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "marş.mp3";
        }
    }
}
