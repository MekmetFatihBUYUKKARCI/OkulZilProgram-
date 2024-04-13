namespace OkulZilProgramı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            maskedTextBox7 = new MaskedTextBox();
            maskedTextBox8 = new MaskedTextBox();
            maskedTextBox9 = new MaskedTextBox();
            maskedTextBox10 = new MaskedTextBox();
            maskedTextBox11 = new MaskedTextBox();
            maskedTextBox12 = new MaskedTextBox();
            maskedTextBox13 = new MaskedTextBox();
            maskedTextBox14 = new MaskedTextBox();
            maskedTextBox15 = new MaskedTextBox();
            maskedTextBox16 = new MaskedTextBox();
            maskedTextBox17 = new MaskedTextBox();
            maskedTextBox18 = new MaskedTextBox();
            maskedTextBox19 = new MaskedTextBox();
            maskedTextBox20 = new MaskedTextBox();
            maskedTextBox21 = new MaskedTextBox();
            maskedTextBox22 = new MaskedTextBox();
            maskedTextBox23 = new MaskedTextBox();
            maskedTextBox24 = new MaskedTextBox();
            zilCal = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zilCal).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 99);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(79, 61);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 168);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(79, 58);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 234);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(79, 61);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 553);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 9);
            label3.Name = "label3";
            label3.Size = new Size(91, 27);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(566, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(322, 97);
            maskedTextBox1.Mask = "00:00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(51, 27);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button4
            // 
            button4.Font = new Font("Niagara Solid", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(566, 188);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(121, 49);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.Location = new Point(304, 59);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label6.Location = new Point(418, 59);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 100);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 13;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 129);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(192, 161);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 15;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(192, 260);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 18;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(192, 228);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 17;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(192, 195);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 16;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(192, 355);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 21;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(192, 323);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 20;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(192, 292);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 19;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(192, 450);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 24;
            label16.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(192, 418);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 23;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(192, 389);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 22;
            label18.Text = "label18";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(322, 126);
            maskedTextBox2.Mask = "00:00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(51, 27);
            maskedTextBox2.TabIndex = 25;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(322, 192);
            maskedTextBox3.Mask = "00:00:00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(51, 27);
            maskedTextBox3.TabIndex = 27;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(323, 158);
            maskedTextBox4.Mask = "00:00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(51, 27);
            maskedTextBox4.TabIndex = 26;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            maskedTextBox4.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(322, 257);
            maskedTextBox5.Mask = "00:00:00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(51, 27);
            maskedTextBox5.TabIndex = 29;
            maskedTextBox5.ValidatingType = typeof(DateTime);
            maskedTextBox5.MaskInputRejected += maskedTextBox5_MaskInputRejected;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(322, 225);
            maskedTextBox6.Mask = "00:00:00";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(51, 27);
            maskedTextBox6.TabIndex = 28;
            maskedTextBox6.ValidatingType = typeof(DateTime);
            maskedTextBox6.MaskInputRejected += maskedTextBox6_MaskInputRejected;
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.Location = new Point(323, 447);
            maskedTextBox7.Mask = "00:00:00";
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(51, 27);
            maskedTextBox7.TabIndex = 35;
            maskedTextBox7.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox8
            // 
            maskedTextBox8.Location = new Point(323, 415);
            maskedTextBox8.Mask = "00:00:00";
            maskedTextBox8.Name = "maskedTextBox8";
            maskedTextBox8.Size = new Size(51, 27);
            maskedTextBox8.TabIndex = 34;
            maskedTextBox8.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox9
            // 
            maskedTextBox9.Location = new Point(323, 382);
            maskedTextBox9.Mask = "00:00:00";
            maskedTextBox9.Name = "maskedTextBox9";
            maskedTextBox9.Size = new Size(51, 27);
            maskedTextBox9.TabIndex = 33;
            maskedTextBox9.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox10
            // 
            maskedTextBox10.Location = new Point(324, 348);
            maskedTextBox10.Mask = "00:00:00";
            maskedTextBox10.Name = "maskedTextBox10";
            maskedTextBox10.Size = new Size(51, 27);
            maskedTextBox10.TabIndex = 32;
            maskedTextBox10.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox11
            // 
            maskedTextBox11.Location = new Point(323, 316);
            maskedTextBox11.Mask = "00:00:00";
            maskedTextBox11.Name = "maskedTextBox11";
            maskedTextBox11.Size = new Size(51, 27);
            maskedTextBox11.TabIndex = 31;
            maskedTextBox11.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox12
            // 
            maskedTextBox12.Location = new Point(323, 287);
            maskedTextBox12.Mask = "00:00:00";
            maskedTextBox12.Name = "maskedTextBox12";
            maskedTextBox12.Size = new Size(51, 27);
            maskedTextBox12.TabIndex = 30;
            maskedTextBox12.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox13
            // 
            maskedTextBox13.Location = new Point(441, 447);
            maskedTextBox13.Mask = "00:00:00";
            maskedTextBox13.Name = "maskedTextBox13";
            maskedTextBox13.Size = new Size(51, 27);
            maskedTextBox13.TabIndex = 47;
            maskedTextBox13.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox14
            // 
            maskedTextBox14.Location = new Point(441, 415);
            maskedTextBox14.Mask = "00:00:00";
            maskedTextBox14.Name = "maskedTextBox14";
            maskedTextBox14.Size = new Size(51, 27);
            maskedTextBox14.TabIndex = 46;
            maskedTextBox14.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox15
            // 
            maskedTextBox15.Location = new Point(441, 382);
            maskedTextBox15.Mask = "00:00:00";
            maskedTextBox15.Name = "maskedTextBox15";
            maskedTextBox15.Size = new Size(51, 27);
            maskedTextBox15.TabIndex = 45;
            maskedTextBox15.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox16
            // 
            maskedTextBox16.Location = new Point(442, 348);
            maskedTextBox16.Mask = "00:00:00";
            maskedTextBox16.Name = "maskedTextBox16";
            maskedTextBox16.Size = new Size(51, 27);
            maskedTextBox16.TabIndex = 44;
            maskedTextBox16.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox17
            // 
            maskedTextBox17.Location = new Point(441, 316);
            maskedTextBox17.Mask = "00:00:00";
            maskedTextBox17.Name = "maskedTextBox17";
            maskedTextBox17.Size = new Size(51, 27);
            maskedTextBox17.TabIndex = 43;
            maskedTextBox17.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox18
            // 
            maskedTextBox18.Location = new Point(441, 287);
            maskedTextBox18.Mask = "00:00:00";
            maskedTextBox18.Name = "maskedTextBox18";
            maskedTextBox18.Size = new Size(51, 27);
            maskedTextBox18.TabIndex = 42;
            maskedTextBox18.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox19
            // 
            maskedTextBox19.Location = new Point(440, 257);
            maskedTextBox19.Mask = "00:00:00";
            maskedTextBox19.Name = "maskedTextBox19";
            maskedTextBox19.Size = new Size(51, 27);
            maskedTextBox19.TabIndex = 41;
            maskedTextBox19.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox20
            // 
            maskedTextBox20.Location = new Point(440, 225);
            maskedTextBox20.Mask = "00:00:00";
            maskedTextBox20.Name = "maskedTextBox20";
            maskedTextBox20.Size = new Size(51, 27);
            maskedTextBox20.TabIndex = 40;
            maskedTextBox20.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox21
            // 
            maskedTextBox21.Location = new Point(440, 192);
            maskedTextBox21.Mask = "00:00:00";
            maskedTextBox21.Name = "maskedTextBox21";
            maskedTextBox21.Size = new Size(51, 27);
            maskedTextBox21.TabIndex = 39;
            maskedTextBox21.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox22
            // 
            maskedTextBox22.Location = new Point(441, 158);
            maskedTextBox22.Mask = "00:00:00";
            maskedTextBox22.Name = "maskedTextBox22";
            maskedTextBox22.Size = new Size(51, 27);
            maskedTextBox22.TabIndex = 38;
            maskedTextBox22.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox23
            // 
            maskedTextBox23.Location = new Point(440, 126);
            maskedTextBox23.Mask = "00:00:00";
            maskedTextBox23.Name = "maskedTextBox23";
            maskedTextBox23.Size = new Size(51, 27);
            maskedTextBox23.TabIndex = 37;
            maskedTextBox23.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox24
            // 
            maskedTextBox24.Location = new Point(440, 97);
            maskedTextBox24.Mask = "00:00:00";
            maskedTextBox24.Name = "maskedTextBox24";
            maskedTextBox24.Size = new Size(51, 27);
            maskedTextBox24.TabIndex = 36;
            maskedTextBox24.ValidatingType = typeof(DateTime);
            // 
            // zilCal
            // 
            zilCal.Enabled = true;
            zilCal.Location = new Point(408, 536);
            zilCal.Name = "zilCal";
            zilCal.OcxState = (AxHost.State)resources.GetObject("zilCal.OcxState");
            zilCal.Size = new Size(223, 52);
            zilCal.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(135, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 444);
            panel1.TabIndex = 49;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 600);
            Controls.Add(panel1);
            Controls.Add(zilCal);
            Controls.Add(maskedTextBox13);
            Controls.Add(maskedTextBox14);
            Controls.Add(maskedTextBox15);
            Controls.Add(maskedTextBox16);
            Controls.Add(maskedTextBox17);
            Controls.Add(maskedTextBox18);
            Controls.Add(maskedTextBox19);
            Controls.Add(maskedTextBox20);
            Controls.Add(maskedTextBox21);
            Controls.Add(maskedTextBox22);
            Controls.Add(maskedTextBox23);
            Controls.Add(maskedTextBox24);
            Controls.Add(maskedTextBox7);
            Controls.Add(maskedTextBox8);
            Controls.Add(maskedTextBox9);
            Controls.Add(maskedTextBox10);
            Controls.Add(maskedTextBox11);
            Controls.Add(maskedTextBox12);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zilCal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private Button button4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox7;
        private MaskedTextBox maskedTextBox8;
        private MaskedTextBox maskedTextBox9;
        private MaskedTextBox maskedTextBox10;
        private MaskedTextBox maskedTextBox11;
        private MaskedTextBox maskedTextBox12;
        private MaskedTextBox maskedTextBox13;
        private MaskedTextBox maskedTextBox14;
        private MaskedTextBox maskedTextBox15;
        private MaskedTextBox maskedTextBox16;
        private MaskedTextBox maskedTextBox17;
        private MaskedTextBox maskedTextBox18;
        private MaskedTextBox maskedTextBox19;
        private MaskedTextBox maskedTextBox20;
        private MaskedTextBox maskedTextBox21;
        private MaskedTextBox maskedTextBox22;
        private MaskedTextBox maskedTextBox23;
        private MaskedTextBox maskedTextBox24;
        private AxWMPLib.AxWindowsMediaPlayer zilCal;
        private Panel panel1;
    }
}
