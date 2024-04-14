namespace OkulZilProgramı
{
    partial class torenAraclari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(torenAraclari));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(74, 74);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 92);
            button2.Name = "button2";
            button2.Size = new Size(74, 73);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 171);
            button3.Name = "button3";
            button3.Size = new Size(74, 67);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(99, 78);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(215, 104);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // torenAraclari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 248);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "torenAraclari";
            Text = "torenAraclari";
            Load += torenAraclari_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}