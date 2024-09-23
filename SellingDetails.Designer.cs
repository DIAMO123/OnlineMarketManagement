namespace OnlineMarketManagmnetSystem
{
    partial class SellingDetails
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingDetails));
            DataGridViewSellingDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            buttonBuyingRefresh = new Button();
            buttonSellBack = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSellingDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewSellingDetails
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewSellingDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewSellingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewSellingDetails.ColumnHeadersHeight = 30;
            DataGridViewSellingDetails.Columns.AddRange(new DataGridViewColumn[] { ProductId, Quantity, Price });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewSellingDetails.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewSellingDetails.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewSellingDetails.Location = new Point(164, 96);
            DataGridViewSellingDetails.Name = "DataGridViewSellingDetails";
            DataGridViewSellingDetails.RowHeadersVisible = false;
            DataGridViewSellingDetails.Size = new Size(531, 298);
            DataGridViewSellingDetails.TabIndex = 40;
            DataGridViewSellingDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewSellingDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewSellingDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewSellingDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewSellingDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewSellingDetails.ThemeStyle.BackColor = Color.White;
            DataGridViewSellingDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewSellingDetails.ThemeStyle.HeaderStyle.Height = 30;
            DataGridViewSellingDetails.ThemeStyle.ReadOnly = false;
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.Height = 25;
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewSellingDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewSellingDetails.CellContentClick += DataGridViewSellingDetails_CellContentClick;
            // 
            // ProductId
            // 
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.HeaderText = "price";
            Price.Name = "Price";
            // 
            // buttonBuyingRefresh
            // 
            buttonBuyingRefresh.BackColor = SystemColors.ActiveCaption;
            buttonBuyingRefresh.Location = new Point(184, 415);
            buttonBuyingRefresh.Name = "buttonBuyingRefresh";
            buttonBuyingRefresh.Size = new Size(75, 23);
            buttonBuyingRefresh.TabIndex = 41;
            buttonBuyingRefresh.Text = "Reset";
            buttonBuyingRefresh.UseVisualStyleBackColor = false;
            buttonBuyingRefresh.Click += buttonBuyingRefresh_Click;
            // 
            // buttonSellBack
            // 
            buttonSellBack.BackColor = Color.FromArgb(255, 128, 128);
            buttonSellBack.Location = new Point(29, 460);
            buttonSellBack.Name = "buttonSellBack";
            buttonSellBack.Size = new Size(75, 23);
            buttonSellBack.TabIndex = 42;
            buttonSellBack.Text = "Back";
            buttonSellBack.UseVisualStyleBackColor = false;
            buttonSellBack.Click += buttonSellBack_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(822, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(344, 27);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 44;
            label1.Text = "Sold Iteams";
            // 
            // SellingDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(866, 495);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonSellBack);
            Controls.Add(buttonBuyingRefresh);
            Controls.Add(DataGridViewSellingDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellingDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingDetails";
            ((System.ComponentModel.ISupportInitialize)DataGridViewSellingDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewSellingDetails;
        private Button buttonBuyingRefresh;
        private Button buttonSellBack;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Label label1;
    }
}