namespace WarehouseManagementSystem
{
    partial class frmVendite
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendite));
			this.Label13 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtSaleQty = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtAvailableQty = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.NewRecord = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblUser = new System.Windows.Forms.Label();
			this.lblUserType = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtIdProduct = new System.Windows.Forms.TextBox();
			this.IdProduct = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Label13
			// 
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.Color.LightGray;
			this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label13.Location = new System.Drawing.Point(33, 22);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(68, 22);
			this.Label13.TabIndex = 96;
			this.Label13.Text = "Vendite";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txtTotalAmount);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.Button7);
			this.GroupBox1.Controls.Add(this.IdProduct);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtIdProduct);
			this.GroupBox1.Controls.Add(this.txtProductName);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.txtSaleQty);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.txtPrice);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.txtAvailableQty);
			this.GroupBox1.Location = new System.Drawing.Point(33, 59);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(537, 207);
			this.GroupBox1.TabIndex = 107;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Dettagli Prodotto";
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Location = new System.Drawing.Point(370, 103);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.ReadOnly = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(132, 24);
			this.txtTotalAmount.TabIndex = 93;
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label11.Location = new System.Drawing.Point(26, 106);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(92, 17);
			this.Label11.TabIndex = 89;
			this.Label11.Text = "Qtà da Vendere";
			// 
			// Button7
			// 
			this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button7.Location = new System.Drawing.Point(29, 178);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(87, 23);
			this.Button7.TabIndex = 6;
			this.Button7.Text = "&Vendi";
			this.Button7.UseVisualStyleBackColor = true;
			this.Button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label5.Location = new System.Drawing.Point(26, 33);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(94, 17);
			this.Label5.TabIndex = 74;
			this.Label5.Text = "Nome Prodotto";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(138, 28);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.Size = new System.Drawing.Size(364, 24);
			this.txtProductName.TabIndex = 1;
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label12.Location = new System.Drawing.Point(26, 67);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(78, 17);
			this.Label12.TabIndex = 87;
			this.Label12.Text = "Prezzo Unità";
			// 
			// txtSaleQty
			// 
			this.txtSaleQty.Location = new System.Drawing.Point(138, 99);
			this.txtSaleQty.Name = "txtSaleQty";
			this.txtSaleQty.Size = new System.Drawing.Size(89, 24);
			this.txtSaleQty.TabIndex = 4;
			this.txtSaleQty.TextChanged += new System.EventHandler(this.txtSaleQty_TextChanged);
			this.txtSaleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleQty_KeyPress);
			this.txtSaleQty.Validating += new System.ComponentModel.CancelEventHandler(this.txtSaleQty_Validating);
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label9.Location = new System.Drawing.Point(271, 67);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(92, 17);
			this.Label9.TabIndex = 75;
			this.Label9.Text = "Qtà Disponibile";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(138, 64);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(89, 24);
			this.txtPrice.TabIndex = 3;
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label10.Location = new System.Drawing.Point(271, 106);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(43, 17);
			this.Label10.TabIndex = 76;
			this.Label10.Text = "Totale";
			// 
			// txtAvailableQty
			// 
			this.txtAvailableQty.Location = new System.Drawing.Point(370, 64);
			this.txtAvailableQty.Name = "txtAvailableQty";
			this.txtAvailableQty.ReadOnly = true;
			this.txtAvailableQty.Size = new System.Drawing.Size(89, 24);
			this.txtAvailableQty.TabIndex = 5;
			// 
			// Panel1
			// 
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.btnUpdate);
			this.Panel1.Controls.Add(this.NewRecord);
			this.Panel1.Controls.Add(this.Delete);
			this.Panel1.Controls.Add(this.Save);
			this.Panel1.Location = new System.Drawing.Point(576, 39);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(112, 152);
			this.Panel1.TabIndex = 112;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(14, 113);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(84, 29);
			this.btnUpdate.TabIndex = 100;
			this.btnUpdate.Text = "&Aggiorna";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// NewRecord
			// 
			this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewRecord.Location = new System.Drawing.Point(14, 8);
			this.NewRecord.Name = "NewRecord";
			this.NewRecord.Size = new System.Drawing.Size(84, 29);
			this.NewRecord.TabIndex = 0;
			this.NewRecord.Text = "&Nuovo";
			this.NewRecord.UseVisualStyleBackColor = true;
			this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
			// 
			// Delete
			// 
			this.Delete.Enabled = false;
			this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Location = new System.Drawing.Point(14, 78);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(84, 29);
			this.Delete.TabIndex = 3;
			this.Delete.Text = "&Elimina";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(14, 43);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(84, 29);
			this.Save.TabIndex = 1;
			this.Save.Text = "&Salva";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(573, 9);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(39, 17);
			this.lblUser.TabIndex = 117;
			this.lblUser.Text = "label6";
			this.lblUser.Visible = false;
			// 
			// lblUserType
			// 
			this.lblUserType.AutoSize = true;
			this.lblUserType.Location = new System.Drawing.Point(618, 9);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(39, 17);
			this.lblUserType.TabIndex = 118;
			this.lblUserType.Text = "label6";
			this.lblUserType.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(33, 272);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(582, 282);
			this.dataGridView1.TabIndex = 119;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// Column8
			// 
			this.Column8.HeaderText = "ID Prodotto";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 80;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nome Prodotto";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 160;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Prezzo";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 70;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Quantità";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 70;
			// 
			// txtIdProduct
			// 
			this.txtIdProduct.Location = new System.Drawing.Point(138, 142);
			this.txtIdProduct.Name = "txtIdProduct";
			this.txtIdProduct.ReadOnly = true;
			this.txtIdProduct.Size = new System.Drawing.Size(176, 24);
			this.txtIdProduct.TabIndex = 1;
			// 
			// IdProduct
			// 
			this.IdProduct.AutoSize = true;
			this.IdProduct.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdProduct.Location = new System.Drawing.Point(26, 147);
			this.IdProduct.Name = "IdProduct";
			this.IdProduct.Size = new System.Drawing.Size(75, 17);
			this.IdProduct.TabIndex = 74;
			this.IdProduct.Text = "Prodotto ID";
			// 
			// frmVendite
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(703, 605);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblUserType);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label13);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmVendite";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vendite";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoice_FormClosing);
			this.Load += new System.EventHandler(this.frmInvoice_Load);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSaleQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtAvailableQty;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Save;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblUser;
		public System.Windows.Forms.Label lblUserType;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		internal System.Windows.Forms.Label IdProduct;
		internal System.Windows.Forms.TextBox txtIdProduct;
	}
}