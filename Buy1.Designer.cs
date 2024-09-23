namespace OnlineMarketManagmnetSystem
{
    partial class Buy1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy1));
            Bkash = new PictureBox();
            label1 = new Label();
            Nagad = new PictureBox();
            Rocket = new PictureBox();
            VisaCard = new PictureBox();
            pictureBox2 = new PictureBox();
            Buy1Back = new Button();
            ((System.ComponentModel.ISupportInitialize)Bkash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nagad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rocket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisaCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Bkash
            // 
            Bkash.Image = (Image)resources.GetObject("Bkash.Image");
            Bkash.Location = new Point(123, 110);
            Bkash.Name = "Bkash";
            Bkash.Size = new Size(197, 158);
            Bkash.SizeMode = PictureBoxSizeMode.StretchImage;
            Bkash.TabIndex = 0;
            Bkash.TabStop = false;
            Bkash.Click += Bkash_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(288, 42);
            label1.Name = "label1";
            label1.Size = new Size(333, 37);
            label1.TabIndex = 1;
            label1.Text = "Select Payment Geteway";
            // 
            // Nagad
            // 
            Nagad.Image = (Image)resources.GetObject("Nagad.Image");
            Nagad.Location = new Point(401, 110);
            Nagad.Name = "Nagad";
            Nagad.Size = new Size(197, 158);
            Nagad.SizeMode = PictureBoxSizeMode.StretchImage;
            Nagad.TabIndex = 2;
            Nagad.TabStop = false;
            Nagad.Click += Nagad_Click;
            // 
            // Rocket
            // 
            Rocket.Image = (Image)resources.GetObject("Rocket.Image");
            Rocket.Location = new Point(679, 110);
            Rocket.Name = "Rocket";
            Rocket.Size = new Size(197, 158);
            Rocket.SizeMode = PictureBoxSizeMode.StretchImage;
            Rocket.TabIndex = 3;
            Rocket.TabStop = false;
            Rocket.Click += pictureBox3_Click;
            // 
            // VisaCard
            // 
            VisaCard.Image = (Image)resources.GetObject("VisaCard.Image");
            VisaCard.Location = new Point(123, 295);
            VisaCard.Name = "VisaCard";
            VisaCard.Size = new Size(197, 158);
            VisaCard.SizeMode = PictureBoxSizeMode.StretchImage;
            VisaCard.TabIndex = 4;
            VisaCard.TabStop = false;
            VisaCard.Click += VisaCard_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(888, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Buy1Back
            // 
            Buy1Back.BackColor = Color.Red;
            Buy1Back.ForeColor = SystemColors.ButtonHighlight;
            Buy1Back.Location = new Point(12, 430);
            Buy1Back.Name = "Buy1Back";
            Buy1Back.Size = new Size(75, 23);
            Buy1Back.TabIndex = 28;
            Buy1Back.Text = "Back";
            Buy1Back.UseVisualStyleBackColor = false;
            Buy1Back.Click += Buy1Back_Click;
            // 
            // Buy1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 481);
            Controls.Add(Buy1Back);
            Controls.Add(pictureBox2);
            Controls.Add(VisaCard);
            Controls.Add(Rocket);
            Controls.Add(Nagad);
            Controls.Add(label1);
            Controls.Add(Bkash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Buy1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buy1";
            ((System.ComponentModel.ISupportInitialize)Bkash).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nagad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rocket).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisaCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bkash;
        private Label label1;
        private PictureBox Nagad;
        private PictureBox Rocket;
        private PictureBox VisaCard;
        private PictureBox pictureBox2;
        private Button Buy1Back;
    }
}