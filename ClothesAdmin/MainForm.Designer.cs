using ClothesAdmin.Models;

namespace ClothesAdmin
{
    partial class MainForm
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
        private void InitializeComponent(User user)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.productsBtn = new System.Windows.Forms.Button();
            this.productsBtnBorder = new System.Windows.Forms.Panel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.salesBtnBorder = new System.Windows.Forms.Panel();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.pruductLabelTitle = new System.Windows.Forms.Label();
            this.brandTitle = new System.Windows.Forms.Label();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridPanelProduct = new System.Windows.Forms.Panel();
            this.newProductBtn = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.salesPanel = new System.Windows.Forms.Panel();
            this.dataGridPanelSales = new System.Windows.Forms.Panel();
            this.textBoxSeachSales = new System.Windows.Forms.TextBox();
            this.newSaleBtn = new System.Windows.Forms.Button();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.salesLabelTitle = new System.Windows.Forms.Label();
            this.productEditBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.productActivateBtn = new System.Windows.Forms.Button();
            this.pictureBoxUser2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchIconSale = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchIconProduct = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.navbarPanel.SuspendLayout();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.dataGridPanelProduct.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.salesPanel.SuspendLayout();
            this.dataGridPanelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Black;
            this.navbarPanel.Controls.Add(this.button1);
            this.navbarPanel.Controls.Add(this.UserPanel);
            this.navbarPanel.Controls.Add(this.brandTitle);
            this.navbarPanel.Controls.Add(this.productsBtn);
            this.navbarPanel.Controls.Add(this.productsBtnBorder);
            this.navbarPanel.Controls.Add(this.salesBtn);
            this.navbarPanel.Controls.Add(this.salesBtnBorder);
            this.navbarPanel.Controls.Add(this.pictureBox1);
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(174, 523);
            this.navbarPanel.TabIndex = 0;
            this.navbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Location = new System.Drawing.Point(36, 254);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(91, 24);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "PRODUCTS";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsBtnBorder
            // 
            this.productsBtnBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.productsBtnBorder.Location = new System.Drawing.Point(56, 278);
            this.productsBtnBorder.Name = "productsBtnBorder";
            this.productsBtnBorder.Size = new System.Drawing.Size(50, 3);
            this.productsBtnBorder.TabIndex = 3;
            this.productsBtnBorder.Visible = false;
            this.productsBtnBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.productsBtnBorder_Paint);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.Transparent;
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.FlatAppearance.BorderSize = 0;
            this.salesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.ForeColor = System.Drawing.Color.White;
            this.salesBtn.Location = new System.Drawing.Point(36, 203);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(91, 24);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "SALES";
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // salesBtnBorder
            // 
            this.salesBtnBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.salesBtnBorder.Location = new System.Drawing.Point(56, 227);
            this.salesBtnBorder.Name = "salesBtnBorder";
            this.salesBtnBorder.Size = new System.Drawing.Size(50, 3);
            this.salesBtnBorder.TabIndex = 5;
            this.salesBtnBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.salesBtnBorder_Paint);
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.LightGray;
            this.productsPanel.Controls.Add(this.pruductLabelTitle);
            this.productsPanel.Controls.Add(this.dataGridPanelProduct);
            this.productsPanel.Location = new System.Drawing.Point(175, 0);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(733, 523);
            this.productsPanel.TabIndex = 1;
            this.productsPanel.Visible = false;
            this.productsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productsPanel_Paint);
            // 
            // pruductLabelTitle
            // 
            this.pruductLabelTitle.AutoSize = true;
            this.pruductLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.pruductLabelTitle.Location = new System.Drawing.Point(300, 25);
            this.pruductLabelTitle.Name = "pruductLabelTitle";
            this.pruductLabelTitle.Size = new System.Drawing.Size(126, 37);
            this.pruductLabelTitle.TabIndex = 0;
            this.pruductLabelTitle.Text = "Products";
            // 
            // brandTitle
            // 
            this.brandTitle.AutoSize = true;
            this.brandTitle.BackColor = System.Drawing.Color.Transparent;
            this.brandTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTitle.ForeColor = System.Drawing.Color.White;
            this.brandTitle.Location = new System.Drawing.Point(14, 139);
            this.brandTitle.Name = "brandTitle";
            this.brandTitle.Size = new System.Drawing.Size(146, 24);
            this.brandTitle.TabIndex = 1;
            this.brandTitle.Text = "Fashion Forward";
            this.brandTitle.Click += new System.EventHandler(this.brandTitle_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AllowUserToResizeColumns = false;
            this.productsDataGrid.AllowUserToResizeRows = false;
            this.productsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.productsDataGrid.GridColor = System.Drawing.Color.White;
            this.productsDataGrid.Location = new System.Drawing.Point(17, 65);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.RowHeadersVisible = false;
            this.productsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsDataGrid.ShowEditingIcon = false;
            this.productsDataGrid.Size = new System.Drawing.Size(650, 358);
            this.productsDataGrid.TabIndex = 0;
            this.productsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGrid_CellContentClick);
            // 
            // dataGridPanelProduct
            // 
            this.dataGridPanelProduct.BackColor = System.Drawing.Color.White;
            this.dataGridPanelProduct.Controls.Add(this.newProductBtn);
            this.dataGridPanelProduct.Controls.Add(this.productEditBtn);
            this.dataGridPanelProduct.Controls.Add(this.productActivateBtn);
            this.dataGridPanelProduct.Controls.Add(this.productDeleteBtn);
            this.dataGridPanelProduct.Controls.Add(this.textBoxSearchProduct);
            this.dataGridPanelProduct.Controls.Add(this.pictureBoxSearchIconProduct);
            this.dataGridPanelProduct.Controls.Add(this.productsDataGrid);
            this.dataGridPanelProduct.Location = new System.Drawing.Point(26, 74);
            this.dataGridPanelProduct.Name = "dataGridPanelProduct";
            this.dataGridPanelProduct.Size = new System.Drawing.Size(680, 436);
            this.dataGridPanelProduct.TabIndex = 1;
            this.dataGridPanelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridPanelProduct_Paint);
            // 
            // newProductBtn
            // 
            this.newProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(159)))));
            this.newProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newProductBtn.FlatAppearance.BorderSize = 0;
            this.newProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductBtn.Location = new System.Drawing.Point(17, 19);
            this.newProductBtn.Name = "newProductBtn";
            this.newProductBtn.Size = new System.Drawing.Size(90, 34);
            this.newProductBtn.TabIndex = 1;
            this.newProductBtn.Text = "New ";
            this.newProductBtn.UseVisualStyleBackColor = false;
            this.newProductBtn.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.Black;
            this.UserPanel.Controls.Add(this.pictureBoxUser2);
            this.UserPanel.Controls.Add(this.userNameLabel);
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(174, 61);
            this.UserPanel.TabIndex = 6;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(71, 25);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 17);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User";
            this.userNameLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.Location = new System.Drawing.Point(505, 22);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(136, 25);
            this.textBoxSearchProduct.TabIndex = 2;
            this.textBoxSearchProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salesPanel
            // 
            this.salesPanel.BackColor = System.Drawing.Color.LightGray;
            this.salesPanel.Controls.Add(this.salesLabelTitle);
            this.salesPanel.Controls.Add(this.dataGridPanelSales);
            this.salesPanel.Location = new System.Drawing.Point(175, 3);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(733, 520);
            this.salesPanel.TabIndex = 4;
            this.salesPanel.Visible = false;
            // 
            // dataGridPanelSales
            // 
            this.dataGridPanelSales.BackColor = System.Drawing.Color.White;
            this.dataGridPanelSales.Controls.Add(this.newSaleBtn);
            this.dataGridPanelSales.Controls.Add(this.textBoxSeachSales);
            this.dataGridPanelSales.Controls.Add(this.pictureBoxSearchIconSale);
            this.dataGridPanelSales.Controls.Add(this.salesDataGrid);
            this.dataGridPanelSales.Location = new System.Drawing.Point(26, 71);
            this.dataGridPanelSales.Name = "dataGridPanelSales";
            this.dataGridPanelSales.Size = new System.Drawing.Size(680, 436);
            this.dataGridPanelSales.TabIndex = 2;
            this.dataGridPanelSales.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridPanelSales_Paint);
            // 
            // textBoxSeachSales
            // 
            this.textBoxSeachSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeachSales.Location = new System.Drawing.Point(505, 22);
            this.textBoxSeachSales.Name = "textBoxSeachSales";
            this.textBoxSeachSales.Size = new System.Drawing.Size(136, 25);
            this.textBoxSeachSales.TabIndex = 2;
            this.textBoxSeachSales.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // newSaleBtn
            // 
            this.newSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(159)))));
            this.newSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newSaleBtn.FlatAppearance.BorderSize = 0;
            this.newSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSaleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSaleBtn.Location = new System.Drawing.Point(17, 19);
            this.newSaleBtn.Name = "newSaleBtn";
            this.newSaleBtn.Size = new System.Drawing.Size(90, 34);
            this.newSaleBtn.TabIndex = 1;
            this.newSaleBtn.Text = "New ";
            this.newSaleBtn.UseVisualStyleBackColor = false;
            this.newSaleBtn.Click += new System.EventHandler(this.newSaleBtn_Click);
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AllowUserToResizeColumns = false;
            this.salesDataGrid.AllowUserToResizeRows = false;
            this.salesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.salesDataGrid.GridColor = System.Drawing.Color.White;
            this.salesDataGrid.Location = new System.Drawing.Point(17, 65);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.RowHeadersVisible = false;
            this.salesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesDataGrid.ShowEditingIcon = false;
            this.salesDataGrid.Size = new System.Drawing.Size(650, 358);
            this.salesDataGrid.TabIndex = 0;
            this.salesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGrid_CellContentClick);
            // 
            // salesLabelTitle
            // 
            this.salesLabelTitle.AutoSize = true;
            this.salesLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabelTitle.Location = new System.Drawing.Point(337, 22);
            this.salesLabelTitle.Name = "salesLabelTitle";
            this.salesLabelTitle.Size = new System.Drawing.Size(79, 37);
            this.salesLabelTitle.TabIndex = 3;
            this.salesLabelTitle.Text = "Sales";
            // 
            // productEditBtn
            // 
            this.productEditBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.productEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productEditBtn.FlatAppearance.BorderSize = 0;
            this.productEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productEditBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEditBtn.Location = new System.Drawing.Point(125, 19);
            this.productEditBtn.Name = "productEditBtn";
            this.productEditBtn.Size = new System.Drawing.Size(90, 34);
            this.productEditBtn.TabIndex = 7;
            this.productEditBtn.Text = "EDIT";
            this.productEditBtn.UseVisualStyleBackColor = false;
            this.productEditBtn.Visible = false;
            this.productEditBtn.Click += new System.EventHandler(this.productEditBtn_Click);
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(59)))));
            this.productDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDeleteBtn.FlatAppearance.BorderSize = 0;
            this.productDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteBtn.Location = new System.Drawing.Point(231, 19);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(102, 34);
            this.productDeleteBtn.TabIndex = 6;
            this.productDeleteBtn.Text = "DESACTIVATE";
            this.productDeleteBtn.UseVisualStyleBackColor = false;
            this.productDeleteBtn.Visible = false;
            this.productDeleteBtn.Click += new System.EventHandler(this.productDeleteBtn_Click);
            // 
            // productActivateBtn
            // 
            this.productActivateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.productActivateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productActivateBtn.FlatAppearance.BorderSize = 0;
            this.productActivateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productActivateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productActivateBtn.Location = new System.Drawing.Point(231, 19);
            this.productActivateBtn.Name = "productActivateBtn";
            this.productActivateBtn.Size = new System.Drawing.Size(102, 34);
            this.productActivateBtn.TabIndex = 8;
            this.productActivateBtn.Text = "ACTIVATE";
            this.productActivateBtn.UseVisualStyleBackColor = false;
            this.productActivateBtn.Visible = false;
            this.productActivateBtn.Click += new System.EventHandler(this.productActivateBtn_Click);
            // 
            // pictureBoxUser2
            // 
            this.pictureBoxUser2.Image = global::ClothesAdmin.Properties.Resources.user_profile_white_32px1;
            this.pictureBoxUser2.Location = new System.Drawing.Point(36, 16);
            this.pictureBoxUser2.Name = "pictureBoxUser2";
            this.pictureBoxUser2.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUser2.TabIndex = 7;
            this.pictureBoxUser2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClothesAdmin.Properties.Resources.icons8_logout_30__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSearchIconSale
            // 
            this.pictureBoxSearchIconSale.Image = global::ClothesAdmin.Properties.Resources.icons8_search_24;
            this.pictureBoxSearchIconSale.Location = new System.Drawing.Point(643, 22);
            this.pictureBoxSearchIconSale.Name = "pictureBoxSearchIconSale";
            this.pictureBoxSearchIconSale.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxSearchIconSale.TabIndex = 3;
            this.pictureBoxSearchIconSale.TabStop = false;
            // 
            // pictureBoxSearchIconProduct
            // 
            this.pictureBoxSearchIconProduct.Image = global::ClothesAdmin.Properties.Resources.icons8_search_24;
            this.pictureBoxSearchIconProduct.Location = new System.Drawing.Point(643, 22);
            this.pictureBoxSearchIconProduct.Name = "pictureBoxSearchIconProduct";
            this.pictureBoxSearchIconProduct.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxSearchIconProduct.TabIndex = 3;
            this.pictureBoxSearchIconProduct.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "LogOut";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 522);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.salesPanel);
            this.Controls.Add(this.productsPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.dataGridPanelProduct.ResumeLayout(false);
            this.dataGridPanelProduct.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.salesPanel.ResumeLayout(false);
            this.salesPanel.PerformLayout();
            this.dataGridPanelSales.ResumeLayout(false);
            this.dataGridPanelSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Panel borderVentas;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Panel borderProductos;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Panel salesBtnBorder;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Panel productsBtnBorder;
        private System.Windows.Forms.Label brandTitle;
        private System.Windows.Forms.Label pruductLabelTitle;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Panel dataGridPanelProduct;
        private System.Windows.Forms.Button newProductBtn;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.PictureBox pictureBoxUser2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox pictureBoxSearchIconProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Panel dataGridPanelSales;
        private System.Windows.Forms.TextBox textBoxSeachSales;
        private System.Windows.Forms.PictureBox pictureBoxSearchIconSale;
        private System.Windows.Forms.Button newSaleBtn;
        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.Label salesLabelTitle;
        private System.Windows.Forms.Button productEditBtn;
        private System.Windows.Forms.Button productDeleteBtn;
        private System.Windows.Forms.Button productActivateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}