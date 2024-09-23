using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketManagmnetSystem
{
    public partial class BuyProduct : Form
    {
        int SerialNumber;
        public BuyProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BuyProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            labelTotalAmount = new Label();
            buttonBuyingBuy = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            buttonBuyingRefresh = new Guna.UI2.WinForms.Guna2Button();
            DataGridViewBuyingCart = new Guna.UI2.WinForms.Guna2DataGridView();
            DataGridViewBuyingDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBuyingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtBuyingQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            buttonBuyingRemove = new Guna.UI2.WinForms.Guna2Button();
            buttonBuyingAddToCart = new Guna.UI2.WinForms.Guna2Button();
            txtBuyingName = new Guna.UI2.WinForms.Guna2TextBox();
            txtBuyingId = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            buttonBuyingLogout = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            this.comboboxSearchCategoryb = new ComboBox();
            this.buttonProductSearchb = new Guna.UI2.WinForms.Guna2Button();
            ((ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)DataGridViewBuyingCart).BeginInit();
            ((ISupportInitialize)DataGridViewBuyingDetails).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(889, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(213, 0);
            label1.Name = "label1";
            label1.Size = new Size(479, 39);
            label1.TabIndex = 29;
            label1.Text = "Online Market Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Controls.Add(this.buttonProductSearchb);
            panel1.Controls.Add(this.comboboxSearchCategoryb);
            panel1.Controls.Add(labelTotalAmount);
            panel1.Controls.Add(buttonBuyingBuy);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonBuyingRefresh);
            panel1.Controls.Add(DataGridViewBuyingCart);
            panel1.Controls.Add(DataGridViewBuyingDetails);
            panel1.Controls.Add(txtBuyingPrice);
            panel1.Controls.Add(txtBuyingQuantity);
            panel1.Controls.Add(buttonBuyingRemove);
            panel1.Controls.Add(buttonBuyingAddToCart);
            panel1.Controls.Add(txtBuyingName);
            panel1.Controls.Add(txtBuyingId);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(102, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 439);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new Point(575, 412);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(37, 15);
            labelTotalAmount.TabIndex = 45;
            labelTotalAmount.Text = "------";
            // 
            // buttonBuyingBuy
            // 
            buttonBuyingBuy.BorderColor = Color.Transparent;
            buttonBuyingBuy.CustomizableEdges = customizableEdges3;
            buttonBuyingBuy.DisabledState.BorderColor = Color.DarkGray;
            buttonBuyingBuy.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuyingBuy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuyingBuy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuyingBuy.FillColor = Color.LightCyan;
            buttonBuyingBuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyingBuy.ForeColor = Color.Blue;
            buttonBuyingBuy.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBuyingBuy.Location = new Point(700, 410);
            buttonBuyingBuy.Name = "buttonBuyingBuy";
            buttonBuyingBuy.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonBuyingBuy.Size = new Size(93, 23);
            buttonBuyingBuy.TabIndex = 44;
            buttonBuyingBuy.Text = "BUY";
            buttonBuyingBuy.Click += buttonBuyingBuy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(476, 410);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 43;
            label3.Text = "Total Amout :";
            label3.Click += label3_Click;
            // 
            // buttonBuyingRefresh
            // 
            buttonBuyingRefresh.BorderColor = Color.Transparent;
            buttonBuyingRefresh.CustomizableEdges = customizableEdges5;
            buttonBuyingRefresh.DisabledState.BorderColor = Color.DarkGray;
            buttonBuyingRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuyingRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuyingRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuyingRefresh.FillColor = Color.MediumSpringGreen;
            buttonBuyingRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyingRefresh.ForeColor = Color.White;
            buttonBuyingRefresh.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBuyingRefresh.Location = new Point(363, 406);
            buttonBuyingRefresh.Name = "buttonBuyingRefresh";
            buttonBuyingRefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            buttonBuyingRefresh.Size = new Size(93, 23);
            buttonBuyingRefresh.TabIndex = 42;
            buttonBuyingRefresh.Text = "REFRESH";
            buttonBuyingRefresh.Click += buttonBuyingRefresh_Click;
            // 
            // DataGridViewBuyingCart
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewBuyingCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewBuyingCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewBuyingCart.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewBuyingCart.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewBuyingCart.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingCart.Location = new Point(276, 220);
            DataGridViewBuyingCart.Name = "DataGridViewBuyingCart";
            DataGridViewBuyingCart.RowHeadersVisible = false;
            DataGridViewBuyingCart.Size = new Size(531, 154);
            DataGridViewBuyingCart.TabIndex = 40;
            DataGridViewBuyingCart.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewBuyingCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewBuyingCart.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewBuyingCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewBuyingCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewBuyingCart.ThemeStyle.BackColor = Color.White;
            DataGridViewBuyingCart.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewBuyingCart.ThemeStyle.HeaderStyle.Height = 30;
            DataGridViewBuyingCart.ThemeStyle.ReadOnly = false;
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.Height = 25;
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingCart.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewBuyingCart.CellClick += DataGridViewBuyingCart_CellClick;
            // 
            // DataGridViewBuyingDetails
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewBuyingDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridViewBuyingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewBuyingDetails.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridViewBuyingDetails.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewBuyingDetails.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingDetails.Location = new Point(276, 37);
            DataGridViewBuyingDetails.Name = "DataGridViewBuyingDetails";
            DataGridViewBuyingDetails.RowHeadersVisible = false;
            DataGridViewBuyingDetails.Size = new Size(531, 156);
            DataGridViewBuyingDetails.TabIndex = 39;
            DataGridViewBuyingDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewBuyingDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewBuyingDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewBuyingDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewBuyingDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewBuyingDetails.ThemeStyle.BackColor = Color.White;
            DataGridViewBuyingDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewBuyingDetails.ThemeStyle.HeaderStyle.Height = 30;
            DataGridViewBuyingDetails.ThemeStyle.ReadOnly = false;
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.Height = 25;
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewBuyingDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewBuyingDetails.CellClick += DataGridViewBuyingDetails_CellClick;
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.BorderThickness = 0;
            txtBuyingPrice.CustomizableEdges = customizableEdges7;
            txtBuyingPrice.DefaultText = "";
            txtBuyingPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuyingPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuyingPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingPrice.Font = new Font("Segoe UI", 9F);
            txtBuyingPrice.ForeColor = Color.Blue;
            txtBuyingPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingPrice.Location = new Point(13, 191);
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.PasswordChar = '\0';
            txtBuyingPrice.PlaceholderForeColor = Color.Blue;
            txtBuyingPrice.PlaceholderText = "Product Price";
            txtBuyingPrice.SelectedText = "";
            txtBuyingPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBuyingPrice.Size = new Size(237, 26);
            txtBuyingPrice.TabIndex = 37;
            // 
            // txtBuyingQuantity
            // 
            txtBuyingQuantity.BorderThickness = 0;
            txtBuyingQuantity.CustomizableEdges = customizableEdges9;
            txtBuyingQuantity.DefaultText = "";
            txtBuyingQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuyingQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuyingQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingQuantity.Font = new Font("Segoe UI", 9F);
            txtBuyingQuantity.ForeColor = Color.Blue;
            txtBuyingQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingQuantity.Location = new Point(13, 146);
            txtBuyingQuantity.Name = "txtBuyingQuantity";
            txtBuyingQuantity.PasswordChar = '\0';
            txtBuyingQuantity.PlaceholderForeColor = Color.Blue;
            txtBuyingQuantity.PlaceholderText = "Product Quantity";
            txtBuyingQuantity.SelectedText = "";
            txtBuyingQuantity.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtBuyingQuantity.Size = new Size(237, 26);
            txtBuyingQuantity.TabIndex = 36;
            // 
            // buttonBuyingRemove
            // 
            buttonBuyingRemove.BorderColor = Color.Transparent;
            buttonBuyingRemove.CustomizableEdges = customizableEdges11;
            buttonBuyingRemove.DisabledState.BorderColor = Color.DarkGray;
            buttonBuyingRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuyingRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuyingRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuyingRemove.FillColor = Color.Cyan;
            buttonBuyingRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyingRemove.ForeColor = Color.White;
            buttonBuyingRemove.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBuyingRemove.Location = new Point(13, 324);
            buttonBuyingRemove.Name = "buttonBuyingRemove";
            buttonBuyingRemove.ShadowDecoration.CustomizableEdges = customizableEdges12;
            buttonBuyingRemove.Size = new Size(137, 26);
            buttonBuyingRemove.TabIndex = 35;
            buttonBuyingRemove.Text = "Remove";
            buttonBuyingRemove.Click += buttonBuyingRemove_Click;
            // 
            // buttonBuyingAddToCart
            // 
            buttonBuyingAddToCart.BorderColor = Color.Transparent;
            buttonBuyingAddToCart.CustomizableEdges = customizableEdges13;
            buttonBuyingAddToCart.DisabledState.BorderColor = Color.DarkGray;
            buttonBuyingAddToCart.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuyingAddToCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuyingAddToCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuyingAddToCart.FillColor = Color.RoyalBlue;
            buttonBuyingAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyingAddToCart.ForeColor = Color.White;
            buttonBuyingAddToCart.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBuyingAddToCart.Location = new Point(13, 278);
            buttonBuyingAddToCart.Name = "buttonBuyingAddToCart";
            buttonBuyingAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges14;
            buttonBuyingAddToCart.Size = new Size(137, 26);
            buttonBuyingAddToCart.TabIndex = 34;
            buttonBuyingAddToCart.Text = "ADD TO CART";
            buttonBuyingAddToCart.Click += buttonBuyingAddToCart_Click;
            // 
            // txtBuyingName
            // 
            txtBuyingName.BorderThickness = 0;
            txtBuyingName.CustomizableEdges = customizableEdges15;
            txtBuyingName.DefaultText = "";
            txtBuyingName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuyingName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuyingName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingName.Font = new Font("Segoe UI", 9F);
            txtBuyingName.ForeColor = Color.Blue;
            txtBuyingName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingName.Location = new Point(13, 101);
            txtBuyingName.Name = "txtBuyingName";
            txtBuyingName.PasswordChar = '\0';
            txtBuyingName.PlaceholderForeColor = Color.Blue;
            txtBuyingName.PlaceholderText = "Product Name";
            txtBuyingName.SelectedText = "";
            txtBuyingName.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtBuyingName.Size = new Size(237, 26);
            txtBuyingName.TabIndex = 33;
            // 
            // txtBuyingId
            // 
            txtBuyingId.BorderThickness = 0;
            txtBuyingId.CustomizableEdges = customizableEdges17;
            txtBuyingId.DefaultText = "";
            txtBuyingId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuyingId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuyingId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingId.Font = new Font("Segoe UI", 9F);
            txtBuyingId.ForeColor = Color.Blue;
            txtBuyingId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingId.Location = new Point(13, 56);
            txtBuyingId.Name = "txtBuyingId";
            txtBuyingId.PasswordChar = '\0';
            txtBuyingId.PlaceholderForeColor = Color.Blue;
            txtBuyingId.PlaceholderText = "Product Id";
            txtBuyingId.SelectedText = "";
            txtBuyingId.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtBuyingId.ShadowDecoration.Enabled = true;
            txtBuyingId.Size = new Size(237, 26);
            txtBuyingId.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(276, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 31;
            label2.Text = "Product Buying";
            // 
            // buttonBuyingLogout
            // 
            buttonBuyingLogout.BorderColor = Color.Transparent;
            buttonBuyingLogout.CustomizableEdges = customizableEdges19;
            buttonBuyingLogout.DisabledState.BorderColor = Color.DarkGray;
            buttonBuyingLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuyingLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuyingLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuyingLogout.FillColor = Color.Violet;
            buttonBuyingLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyingLogout.ForeColor = Color.White;
            buttonBuyingLogout.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBuyingLogout.Location = new Point(3, 450);
            buttonBuyingLogout.Name = "buttonBuyingLogout";
            buttonBuyingLogout.ShadowDecoration.CustomizableEdges = customizableEdges20;
            buttonBuyingLogout.Size = new Size(93, 26);
            buttonBuyingLogout.TabIndex = 41;
            buttonBuyingLogout.Text = "LOGOUT";
            buttonBuyingLogout.Click += buttonBuyingLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // comboboxSearchCategoryb
            // 
            this.comboboxSearchCategoryb.BackColor = SystemColors.ButtonHighlight;
            this.comboboxSearchCategoryb.ForeColor = Color.Blue;
            this.comboboxSearchCategoryb.FormattingEnabled = true;
            this.comboboxSearchCategoryb.Location = new Point(575, 9);
            this.comboboxSearchCategoryb.Name = "comboboxSearchCategoryb";
            this.comboboxSearchCategoryb.Size = new Size(136, 23);
            this.comboboxSearchCategoryb.TabIndex = 47;
            this.comboboxSearchCategoryb.Text = "Select Category";
            // 
            // buttonProductSearchb
            // 
            this.buttonProductSearchb.BorderColor = Color.Transparent;
            this.buttonProductSearchb.CustomizableEdges = customizableEdges1;
            this.buttonProductSearchb.DisabledState.BorderColor = Color.DarkGray;
            this.buttonProductSearchb.DisabledState.CustomBorderColor = Color.DarkGray;
            this.buttonProductSearchb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            this.buttonProductSearchb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            this.buttonProductSearchb.FillColor = Color.MediumSpringGreen;
            this.buttonProductSearchb.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.buttonProductSearchb.ForeColor = Color.White;
            this.buttonProductSearchb.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            this.buttonProductSearchb.Location = new Point(717, 9);
            this.buttonProductSearchb.Name = "buttonProductSearchb";
            this.buttonProductSearchb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.buttonProductSearchb.Size = new Size(76, 23);
            this.buttonProductSearchb.TabIndex = 48;
            this.buttonProductSearchb.Text = "SEARCH";
            this.buttonProductSearchb.Click += this.buttonProductSearchb_Click;
            // 
            // BuyProduct
            // 
            ClientSize = new Size(934, 481);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBuyingLogout);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BuyProduct_Load;
            ((ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)DataGridViewBuyingCart).EndInit();
            ((ISupportInitialize)DataGridViewBuyingDetails).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void populate()
        {
            string query = @"
    SELECT 
        p.[Product Id], 
        p.[Product Name], 
        p.[Product Quantity], 
        p.[Product Price], 
        c.[Categories Id],  
        c.[Categories Name] AS [Product Category]
    FROM 
        ProductTable p
    INNER JOIN 
        CategoriesTable c
    ON 
        p.[Product Category] = c.[Categories Id]";

            DataTable dt = new DataTable();

            try
            {
                // Ensure the connection is only opened if it's closed
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    sda.Fill(dt);
                }

                DataGridViewBuyingDetails.DataSource = dt;

                // Optionally hide the Category ID column
                DataGridViewBuyingDetails.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate data: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void populate1()
        {
            string query = @"
    SELECT
        b.[SerialNumber],  -- Add the Serial Number column
        b.[Cart Id],
        b.[Cart Name],
        b.[Price],
        p.[Product Id],
        b.[Quantity]  -- Add the Quantity column
    FROM
        BuyingTable b
    INNER JOIN
        ProductTable p
    ON
        b.[Cart Id] = p.[Product Id]";  // Correct join condition here

            DataTable dt = new DataTable();

            try
            {
                // Ensure the connection is only opened if it's closed
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    sda.Fill(dt);
                }

                // Clear existing data source to refresh DataGridView
                DataGridViewBuyingCart.DataSource = null;  // Add this line

                // Set the new data source
                DataGridViewBuyingCart.DataSource = dt;

                // Optionally hide the Category ID column if necessary (optional)
                DataGridViewBuyingCart.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate data: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }





        private void BuyProduct_Load(object sender, EventArgs e)
        {
            populate();

            DataGridViewBuyingDetails.CellClick += DataGridViewBuyingDetails_CellClick;
            DataGridViewBuyingCart.CellClick += DataGridViewBuyingCart_CellClick;

            FillSearchCategory1();

            populate1();
        }

        private void buttonBuyingAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the connection is open
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Get the available quantity of the product from ProductTable
                int availableQuantity = 0;
                string getQuantityQuery = "SELECT [Product Quantity] FROM ProductTable WHERE [Product Id] = @ProductId";

                using (SqlCommand cmd = new SqlCommand(getQuantityQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ProductId", txtBuyingId.Text);

                    // Execute the query and get the available quantity
                    availableQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Check if the available quantity is greater than 0 and the selected quantity is less than or equal to the available quantity
                int selectedQuantity = Convert.ToInt32(txtBuyingQuantity.Text);

                if (availableQuantity <= 0)
                {
                    MessageBox.Show("This product is not available.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if the product is not available
                }

                if (selectedQuantity <= 0)
                {
                    MessageBox.Show("Please select a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if the selected quantity is not valid
                }

                if (selectedQuantity > availableQuantity)
                {
                    MessageBox.Show("Selected quantity exceeds available stock. Available quantity: " + availableQuantity, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if selected quantity is more than available quantity
                }

                // Insert query into BuyingTable
                string query = "INSERT INTO BuyingTable ([Cart Id], [Cart Name], [Quantity], [Price]) VALUES (@Id, @Name, @Quantity, @Price)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("@Id", txtBuyingId.Text);
                    cmd.Parameters.AddWithValue("@Name", txtBuyingName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                    cmd.Parameters.AddWithValue("@Price", txtBuyingPrice.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh UI after adding the product
                populate1();

                // Clear input fields after adding the product
                txtBuyingId.Text = "";
                txtBuyingName.Text = "";
                txtBuyingQuantity.Text = "";
                txtBuyingPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void buttonBuyingLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridViewBuyingDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row clicked is valid (not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = this.DataGridViewBuyingDetails.Rows[e.RowIndex];

                // Populate the textboxes with data from the selected row
                txtBuyingId.Text = row.Cells[0].Value.ToString();  // Assuming ProductId is in column 0
                txtBuyingName.Text = row.Cells[1].Value.ToString(); // Assuming ProductName is in column 1
                txtBuyingQuantity.Text = row.Cells[2].Value.ToString(); // Assuming Price is in column 2
                txtBuyingPrice.Text = row.Cells[3].Value.ToString(); // Assuming Quantity is in column 3

                // Make all textboxes except quantity read-only
                txtBuyingId.ReadOnly = true;
                txtBuyingName.ReadOnly = true;
                txtBuyingPrice.ReadOnly = true;

                // Only the quantity textbox should be editable
                txtBuyingQuantity.ReadOnly = false;
            }
        }

        private void buttonBuyingRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialNumber > 0)
                {
                    // Delete the selected product based on SerialNumber
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM BuyingTable WHERE [SerialNumber] = @SerialNumber", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@SerialNumber", this.SerialNumber);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();
                    }

                    // Step 1: Get the maximum SerialNumber from BuyingTable
                    int maxSerialNumber = 0;
                    string getMaxSerialQuery = "SELECT ISNULL(MAX([SerialNumber]), 0) FROM BuyingTable";

                    using (SqlCommand cmd = new SqlCommand(getMaxSerialQuery, con))
                    {
                        maxSerialNumber = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Step 2: Use maxSerialNumber in the DBCC CHECKIDENT command
                    string reseedQuery = $"DBCC CHECKIDENT('BuyingTable', RESEED, {maxSerialNumber})";

                    using (SqlCommand cmd = new SqlCommand(reseedQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Is Removed.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data grid
                    populate1();

                    // Reset form fields
                    SerialNumber = 0;
                    txtBuyingId.Text = "";
                    txtBuyingName.Text = "";
                    txtBuyingPrice.Text = "";
                    txtBuyingQuantity.Text = "";
                }
                else
                {
                    MessageBox.Show("Please select any Product to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();  // Ensure the connection is closed
                }
            }
        }





        private void DataGridViewBuyingCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a row, not on the header
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow row = DataGridViewBuyingCart.Rows[e.RowIndex];

                // Assign the values to the respective text boxes
                SerialNumber = Convert.ToInt32(row.Cells[0].Value);
                txtBuyingId.Text = row.Cells[1].Value.ToString();  // Product Id
                txtBuyingName.Text = row.Cells[2].Value.ToString();  // Product Name
                txtBuyingQuantity.Text = row.Cells[3].Value.ToString();  // Product Quantity
                txtBuyingPrice.Text = row.Cells[4].Value.ToString();  // Product Price
                //comboboxBuyingCategories.SelectedValue = row.Cells[4].Value;  // Product Category (Category ID)
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyingBuy_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Hide();
                Buy1 buy1 = new Buy1();
                buy1.Show();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while processing the purchase: " + ex.Message);
            }
        }
        public static List<SellingDetailItem> SellingDetailsList = new List<SellingDetailItem>();
        private void buttonBuyingRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount = 0;
                SellingDetailsList.Clear();  // Clear the previous list before adding new items

                // Loop through all rows in DataGridViewBuyingCart
                foreach (DataGridViewRow row in DataGridViewBuyingCart.Rows)
                {
                    if (row.Cells[3].Value != null && row.Cells[1].Value != null)  // Assuming Price is in column 3 and Product Id is in column 1
                    {
                        // Get the selected quantity, product ID, price, and product name
                        int selectedProductId = Convert.ToInt32(row.Cells[1].Value);
                        string productName = row.Cells[2].Value.ToString();  // Assuming Product Name is in column 2
                        int selectedQuantity = Convert.ToInt32(row.Cells[5].Value);  // Assuming Quantity is in column 5
                        decimal productPrice = Convert.ToDecimal(row.Cells[3].Value);  // Price is in column 3

                        // Calculate total for this row (quantity * price)
                        decimal rowTotal = selectedQuantity * productPrice;

                        // Add this row's total to the overall total amount
                        totalAmount += rowTotal;

                        // Create a selling detail item for this product and add it to the static list
                        SellingDetailsList.Add(new SellingDetailItem
                        {
                            ProductId = selectedProductId,
                            ProductName = productName,   // Add product name here
                            Quantity = selectedQuantity,
                            Price = productPrice
                        });

                        // Update ProductTable logic - reduce the product quantity in ProductTable
                        UpdateProductQuantityInDatabase(selectedProductId, selectedQuantity);  // Update database
                    }
                }

                // Display the total amount in the label
                labelTotalAmount.Text = " " + totalAmount.ToString("C");  // "C" for currency formatting

                // Refresh the ProductTable details to show the updated quantities
                populate();  // This will reload the DataGridViewBuyingDetails

                // At this point, SellingDetailsList is updated with the new data

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total or updating product quantity: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateProductQuantityInDatabase(int productId, int quantitySold)
        {
            try
            {
                // Open the connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query to update the product quantity in the database
                string updateQuery = "UPDATE ProductTable SET [Product Quantity] = [Product Quantity] - @QuantitySold WHERE [Product Id] = @ProductId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product quantity: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void FillSearchCategory1()
        {
            string query = "SELECT [Categories Id], [Categories Name] FROM CategoriesTable";
            DataTable dt = new DataTable();

            try
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader sda = cmd.ExecuteReader();
                    dt.Load(sda);
                }


                comboboxSearchCategoryb.DisplayMember = "Categories Name";
                comboboxSearchCategoryb.ValueMember = "Categories Id";
                comboboxSearchCategoryb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public class SellingDetailItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }  // Add this property
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }

        private void buttonProductSearchb_Click(object sender, EventArgs e)
        {
            
            // Ensure that a category is selected
            if (comboboxSearchCategoryb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected category ID
            int selectedCategoryId = (int)comboboxSearchCategoryb.SelectedValue;

            // Query to fetch products based on selected category
            string query = @"
    SELECT 
        p.[Product Id], 
        p.[Product Name], 
        p.[Product Quantity], 
        p.[Product Price], 
        c.[Categories Id], 
        c.[Categories Name] AS [Product Category]
    FROM 
        ProductTable p
    INNER JOIN 
        CategoriesTable c
    ON 
        p.[Product Category] = c.[Categories Id]
    WHERE 
        p.[Product Category] = @CategoryId";

            DataTable dt = new DataTable();

            try
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", selectedCategoryId);  // Category ID parameter
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }


                // Display the filtered products in the DataGridView
                DataGridViewBuyingDetails.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
