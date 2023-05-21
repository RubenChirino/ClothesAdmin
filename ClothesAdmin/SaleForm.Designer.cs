namespace ClothesAdmin
{
    partial class SaleForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelClientDNI = new System.Windows.Forms.Label();
            this.comboBoxClientDNI = new System.Windows.Forms.ComboBox();
            this.navbarPanel.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Black;
            this.navbarPanel.Controls.Add(this.btnBack);
            this.navbarPanel.Controls.Add(this.title);
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(834, 50);
            this.navbarPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(706, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 27);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(96, 24);
            this.title.TabIndex = 1;
            this.title.Text = "New sale";
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.White;
            this.panelInputs.Controls.Add(this.labelProduct);
            this.panelInputs.Controls.Add(this.comboBoxProduct);
            this.panelInputs.Controls.Add(this.labelClientDNI);
            this.panelInputs.Controls.Add(this.comboBoxClientDNI);
            this.panelInputs.Controls.Add(this.saveBtn);
            this.panelInputs.Location = new System.Drawing.Point(35, 80);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(753, 127);
            this.panelInputs.TabIndex = 3;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputs_Paint);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(159)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(556, 34);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(171, 45);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(240, 34);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(56, 17);
            this.labelProduct.TabIndex = 20;
            this.labelProduct.Text = "Product";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(243, 54);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(280, 24);
            this.comboBoxProduct.TabIndex = 21;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // labelClientDNI
            // 
            this.labelClientDNI.AutoSize = true;
            this.labelClientDNI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientDNI.Location = new System.Drawing.Point(33, 34);
            this.labelClientDNI.Name = "labelClientDNI";
            this.labelClientDNI.Size = new System.Drawing.Size(69, 17);
            this.labelClientDNI.TabIndex = 23;
            this.labelClientDNI.Text = "Client DNI";
            // 
            // comboBoxClientDNI
            // 
            this.comboBoxClientDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxClientDNI.FormattingEnabled = true;
            this.comboBoxClientDNI.Location = new System.Drawing.Point(36, 54);
            this.comboBoxClientDNI.Name = "comboBoxClientDNI";
            this.comboBoxClientDNI.Size = new System.Drawing.Size(171, 24);
            this.comboBoxClientDNI.TabIndex = 24;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 246);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.panelInputs);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelClientDNI;
        private System.Windows.Forms.ComboBox comboBoxClientDNI;
    }
}