﻿namespace WarehouseManagementSystem
{
    partial class frmCustomersRecord1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersRecord1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCustomers = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblUserType = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 91);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(845, 554);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCustomers);
			this.groupBox1.Location = new System.Drawing.Point(7, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 82);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cerca Cliente";
			// 
			// txtCustomers
			// 
			this.txtCustomers.Location = new System.Drawing.Point(16, 40);
			this.txtCustomers.Name = "txtCustomers";
			this.txtCustomers.Size = new System.Drawing.Size(218, 24);
			this.txtCustomers.TabIndex = 0;
			this.txtCustomers.TextChanged += new System.EventHandler(this.txtCustomers_TextChanged);
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Location = new System.Drawing.Point(271, 3);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(134, 82);
			this.GroupBox2.TabIndex = 17;
			this.GroupBox2.TabStop = false;
			// 
			// Button3
			// 
			this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button3.Location = new System.Drawing.Point(19, 23);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(94, 40);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "&Export Excel";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(459, 43);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(39, 17);
			this.lblUser.TabIndex = 18;
			this.lblUser.Text = "label1";
			this.lblUser.Visible = false;
			// 
			// lblUserType
			// 
			this.lblUserType.AutoSize = true;
			this.lblUserType.Location = new System.Drawing.Point(504, 43);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(39, 17);
			this.lblUserType.TabIndex = 19;
			this.lblUserType.Text = "label2";
			this.lblUserType.Visible = false;
			// 
			// frmCustomersRecord1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(856, 646);
			this.Controls.Add(this.lblUserType);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmCustomersRecord1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers Record";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomersRecord1_FormClosing);
			this.Load += new System.EventHandler(this.frmCustomersRecord_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomers;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button3;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}