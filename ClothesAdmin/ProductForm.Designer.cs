namespace ClothesAdmin
{
    partial class ProductForm
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
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.numericBoxStock = new System.Windows.Forms.NumericUpDown();
            this.numericBoxPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxImageURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.navbarPanel.SuspendLayout();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Black;
            this.navbarPanel.Controls.Add(this.button2);
            this.navbarPanel.Controls.Add(this.title);
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(800, 50);
            this.navbarPanel.TabIndex = 0;
            this.navbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navbarPanel_Paint);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(129, 24);
            this.title.TabIndex = 1;
            this.title.Text = "New product";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(43, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(171, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.White;
            this.panelInputs.Controls.Add(this.button1);
            this.panelInputs.Controls.Add(this.labelName);
            this.panelInputs.Controls.Add(this.textBoxName);
            this.panelInputs.Controls.Add(this.labelPrice);
            this.panelInputs.Controls.Add(this.numericBoxPrice);
            this.panelInputs.Controls.Add(this.labelCategorie);
            this.panelInputs.Controls.Add(this.comboBoxCategorie);
            this.panelInputs.Controls.Add(this.labelDescription);
            this.panelInputs.Controls.Add(this.textBoxDescription);
            this.panelInputs.Controls.Add(this.labelColor);
            this.panelInputs.Controls.Add(this.textBoxColor);
            this.panelInputs.Controls.Add(this.labelImage);
            this.panelInputs.Controls.Add(this.textBoxImageURL);
            this.panelInputs.Controls.Add(this.labelStock);
            this.panelInputs.Controls.Add(this.numericBoxStock);
            this.panelInputs.Controls.Add(this.labelSize);
            this.panelInputs.Controls.Add(this.comboBoxSize);
            this.panelInputs.Location = new System.Drawing.Point(39, 88);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(730, 291);
            this.panelInputs.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(40, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(40, 103);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(76, 17);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxDescription.Location = new System.Drawing.Point(43, 123);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(171, 47);
            this.textBoxDescription.TabIndex = 3;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(40, 187);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 17);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock";
            // 
            // numericBoxStock
            // 
            this.numericBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numericBoxStock.Location = new System.Drawing.Point(43, 210);
            this.numericBoxStock.Name = "numericBoxStock";
            this.numericBoxStock.Size = new System.Drawing.Size(171, 22);
            this.numericBoxStock.TabIndex = 7;
            this.numericBoxStock.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericBoxPrice
            // 
            this.numericBoxPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numericBoxPrice.Location = new System.Drawing.Point(272, 54);
            this.numericBoxPrice.Name = "numericBoxPrice";
            this.numericBoxPrice.Size = new System.Drawing.Size(171, 22);
            this.numericBoxPrice.TabIndex = 9;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(269, 31);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 17);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(269, 103);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(40, 17);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(272, 123);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(171, 22);
            this.textBoxColor.TabIndex = 10;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(269, 187);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(31, 17);
            this.labelSize.TabIndex = 13;
            this.labelSize.Text = "Size";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(272, 208);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(171, 24);
            this.comboBoxSize.TabIndex = 14;
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(496, 54);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(171, 24);
            this.comboBoxCategorie.TabIndex = 16;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(493, 33);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(66, 17);
            this.labelCategorie.TabIndex = 15;
            this.labelCategorie.Text = "Categorie";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(493, 103);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(81, 17);
            this.labelImage.TabIndex = 18;
            this.labelImage.Text = "Image (URL)";
            // 
            // textBoxImageURL
            // 
            this.textBoxImageURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImageURL.Location = new System.Drawing.Point(496, 123);
            this.textBoxImageURL.Name = "textBoxImageURL";
            this.textBoxImageURL.Size = new System.Drawing.Size(171, 22);
            this.textBoxImageURL.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(159)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(496, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(706, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.panelInputs);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown numericBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.NumericUpDown numericBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxImageURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}