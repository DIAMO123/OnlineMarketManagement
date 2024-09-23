namespace OnlineMarketManagmnetSystem
{
    partial class Rocketend
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rocketend));
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            rbkashendlogout = new Guna.UI2.WinForms.Guna2Button();
            rbuttonBkashendotpConfirm = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(225, 136);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 33;
            label2.Text = "Loading......";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(120, 181);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(314, 23);
            progressBar1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(62, 33);
            label1.Name = "label1";
            label1.Size = new Size(435, 37);
            label1.TabIndex = 31;
            label1.Text = "Please Wait To Confirm Payment";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // rbkashendlogout
            // 
            rbkashendlogout.BorderColor = Color.Transparent;
            rbkashendlogout.CustomizableEdges = customizableEdges1;
            rbkashendlogout.DisabledState.BorderColor = Color.DarkGray;
            rbkashendlogout.DisabledState.CustomBorderColor = Color.DarkGray;
            rbkashendlogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rbkashendlogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rbkashendlogout.FillColor = Color.FromArgb(128, 128, 255);
            rbkashendlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbkashendlogout.ForeColor = Color.White;
            rbkashendlogout.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            rbkashendlogout.Location = new Point(360, 259);
            rbkashendlogout.Name = "rbkashendlogout";
            rbkashendlogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rbkashendlogout.Size = new Size(101, 26);
            rbkashendlogout.TabIndex = 35;
            rbkashendlogout.Text = "Logout";
            rbkashendlogout.Click += rbkashendlogout_Click;
            // 
            // rbuttonBkashendotpConfirm
            // 
            rbuttonBkashendotpConfirm.BorderColor = Color.Transparent;
            rbuttonBkashendotpConfirm.CustomizableEdges = customizableEdges3;
            rbuttonBkashendotpConfirm.DisabledState.BorderColor = Color.DarkGray;
            rbuttonBkashendotpConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            rbuttonBkashendotpConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rbuttonBkashendotpConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rbuttonBkashendotpConfirm.FillColor = Color.FromArgb(128, 128, 255);
            rbuttonBkashendotpConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbuttonBkashendotpConfirm.ForeColor = Color.White;
            rbuttonBkashendotpConfirm.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            rbuttonBkashendotpConfirm.Location = new Point(120, 259);
            rbuttonBkashendotpConfirm.Name = "rbuttonBkashendotpConfirm";
            rbuttonBkashendotpConfirm.ShadowDecoration.CustomizableEdges = customizableEdges4;
            rbuttonBkashendotpConfirm.Size = new Size(154, 26);
            rbuttonBkashendotpConfirm.TabIndex = 34;
            rbuttonBkashendotpConfirm.Text = "Continue Shopping";
            rbuttonBkashendotpConfirm.Click += rbuttonBkashendotpConfirm_Click;
            // 
            // Rocketend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(592, 325);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(rbkashendlogout);
            Controls.Add(rbuttonBkashendotpConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rocketend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rocketend";
            Load += Rocketend_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Button rbkashendlogout;
        private Guna.UI2.WinForms.Guna2Button rbuttonBkashendotpConfirm;
    }
}