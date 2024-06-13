namespace flappyBird
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
            flappyBird = new PictureBox();
            zemin = new PictureBox();
            boruAlt = new PictureBox();
            boruUst = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            boruUst1 = new PictureBox();
            boruAlt1 = new PictureBox();
            boruUst2 = new PictureBox();
            boruAlt2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruUst1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruUst2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt2).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(13, 180);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(73, 62);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(-1, 548);
            zemin.Name = "zemin";
            zemin.Size = new Size(1246, 63);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 1;
            zemin.TabStop = false;
            // 
            // boruAlt
            // 
            boruAlt.Image = (Image)resources.GetObject("boruAlt.Image");
            boruAlt.Location = new Point(198, 362);
            boruAlt.Name = "boruAlt";
            boruAlt.Size = new Size(100, 194);
            boruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            boruAlt.TabIndex = 2;
            boruAlt.TabStop = false;
            boruAlt.Click += boruAlt_Click;
            // 
            // boruUst
            // 
            boruUst.Image = (Image)resources.GetObject("boruUst.Image");
            boruUst.Location = new Point(351, 1);
            boruUst.Name = "boruUst";
            boruUst.Size = new Size(100, 219);
            boruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            boruUst.TabIndex = 3;
            boruUst.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Microsoft PhagsPa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(13, 614);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(123, 36);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score : 0";
            scoreText.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 200;
            gameTimer.Tick += gameTimerEvent;
            // 
            // boruUst1
            // 
            boruUst1.Image = (Image)resources.GetObject("boruUst1.Image");
            boruUst1.Location = new Point(823, 1);
            boruUst1.Name = "boruUst1";
            boruUst1.Size = new Size(100, 147);
            boruUst1.SizeMode = PictureBoxSizeMode.StretchImage;
            boruUst1.TabIndex = 3;
            boruUst1.TabStop = false;
            boruUst1.Click += boruUst1_Click;
            // 
            // boruAlt1
            // 
            boruAlt1.Image = (Image)resources.GetObject("boruAlt1.Image");
            boruAlt1.Location = new Point(927, 410);
            boruAlt1.Name = "boruAlt1";
            boruAlt1.Size = new Size(100, 146);
            boruAlt1.SizeMode = PictureBoxSizeMode.StretchImage;
            boruAlt1.TabIndex = 2;
            boruAlt1.TabStop = false;
            // 
            // boruUst2
            // 
            boruUst2.Image = (Image)resources.GetObject("boruUst2.Image");
            boruUst2.Location = new Point(1099, 1);
            boruUst2.Name = "boruUst2";
            boruUst2.Size = new Size(100, 289);
            boruUst2.SizeMode = PictureBoxSizeMode.StretchImage;
            boruUst2.TabIndex = 3;
            boruUst2.TabStop = false;
            // 
            // boruAlt2
            // 
            boruAlt2.Image = (Image)resources.GetObject("boruAlt2.Image");
            boruAlt2.Location = new Point(606, 289);
            boruAlt2.Name = "boruAlt2";
            boruAlt2.Size = new Size(100, 267);
            boruAlt2.SizeMode = PictureBoxSizeMode.StretchImage;
            boruAlt2.TabIndex = 2;
            boruAlt2.TabStop = false;
            boruAlt2.Click += boruAlt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1247, 659);
            Controls.Add(zemin);
            Controls.Add(boruAlt1);
            Controls.Add(boruUst2);
            Controls.Add(boruUst1);
            Controls.Add(boruAlt2);
            Controls.Add(boruAlt);
            Controls.Add(boruUst);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruUst1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruUst2).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox zemin;
        private PictureBox boruAlt;
        private PictureBox boruUst;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox boruUst1;
        private PictureBox boruAlt1;
        private PictureBox boruUst2;
        private PictureBox boruAlt2;
    }
}
