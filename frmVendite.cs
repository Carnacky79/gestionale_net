using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace WarehouseManagementSystem
{
	public partial class frmVendite : Form
	{
		SqlCommand cmd;
		SqlConnection con;
		SqlDataReader rdr;
		ConnectionString cs = new ConnectionString();

		public frmVendite()
		{
			InitializeComponent();
		}
		private void auto()
		{
		}
		public static string GetUniqueKey(int maxSize)
		{
			char[] chars = new char[62];
			chars = "123456789".ToCharArray();
			byte[] data = new byte[1];
			RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
			crypto.GetNonZeroBytes(data);
			data = new byte[maxSize];
			crypto.GetNonZeroBytes(data);
			StringBuilder result = new StringBuilder(maxSize);
			foreach (byte b in data)
			{
				result.Append(chars[b % (chars.Length)]);
			}
			return result.ToString();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmInvoice_Load(object sender, EventArgs e)
		{
			GetData();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmCustomersRecord1 frm = new frmCustomersRecord1();
			frm.lblUser.Text = lblUser.Text;
			frm.lblUserType.Text = lblUserType.Text;
			frm.Visible = true;
		}

		private void txtSaleQty_TextChanged(object sender, EventArgs e)
		{
			int val1 = 0;
			int val2 = 0;
			int.TryParse(txtPrice.Text, out val1);
			int.TryParse(txtSaleQty.Text, out val2);
			int I = (val1 * val2);
			txtTotalAmount.Text = I.ToString();
		}

		public double subtot()
		{
			int i = 0;
			int j = 0;
			int k = 0;
			i = 0;
			j = 0;
			k = 0;


			try
			{


			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return k;

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void GetData()
		{
			try
			{
				con = new SqlConnection(cs.DBConn);
				con.Open();
				String sql = "SELECT Product.ProductID,Product.ProductName,Product.Price,Temp_Stock.Quantity from Temp_Stock, Product where Temp_Stock.ProductID = Product.ProductID group by Product.productID,Product.productname,Product.Price,Temp_Stock.Quantity having(Temp_Stock.Quantity > 0) order by ProductName";

				//String sql = "SELECT Product.ProductID,ProductName,Features,Price,sum(Quantity) from Temp_Stock,Product where Temp_Stock.ProductID=Product.ProductID and ProductName like '" + txtProduct.Text + "%' group by product.ProductID,productname,Price,Features,Quantity having(quantity>0) order by ProductName";
				cmd = new SqlCommand(sql, con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				dataGridView1.Rows.Clear();
				while (rdr.Read() == true)
				{
					dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Reset()
		{

			txtPrice.Text = "";
			txtAvailableQty.Text = "";
			txtSaleQty.Text = "";
			txtTotalAmount.Text = "";
			txtIdProduct.Text = "";
			txtProductName.Text = "";

			Save.Enabled = true;
			Delete.Enabled = false;
			btnUpdate.Enabled = true;
			Button7.Enabled = true;

		}

		private void NewRecord_Click(object sender, EventArgs e)
		{
			Reset();
			Reset();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				delete_records();
			}
		}
		private void delete_records()
		{

			try
			{

				int RowsAffected = 0;
				con = new SqlConnection(cs.DBConn);
				con.Open();
				string cq1 = "";
				cmd = new SqlCommand(cq1);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				con.Close();
				con = new SqlConnection(cs.DBConn);
				con.Open();
				string cq = "";
				cmd = new SqlCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0)
				{
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Reset();
				}
				else
				{
					MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Reset();
				}
				if (con.State == ConnectionState.Open)
				{
					con.Close();
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmInvoice_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			frmMainMenu frm = new frmMainMenu();
			frm.lblUser.Text = lblUser.Text;
			frm.lblUserType.Text = lblUserType.Text;
			frm.Show();
		}

		private void txtSaleQty_Validating(object sender, CancelEventArgs e)
		{

			int val1 = 0;
			int val2 = 0;
			int.TryParse(txtAvailableQty.Text, out val1);
			int.TryParse(txtSaleQty.Text, out val2);
			if (val2 > val1)
			{
				MessageBox.Show("Le quantità di vendita sono superiori alle quantità disponibili", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSaleQty.Text = "";
				txtTotalAmount.Text = "";
				txtSaleQty.Focus();
				return;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Cursor = Cursors.Default;
			timer1.Enabled = false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			GetData();
			Reset();
			btnUpdate.Enabled = true;
			MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtSaleQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
		
		private void txtTotalPayment_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtTaxPer_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allows 0-9, backspace, and decimal
			if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
			{
				e.Handled = true;
				return;
			}
		}
		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
			{
				dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				DataGridViewRow dr = dataGridView1.SelectedRows[0];
				txtIdProduct.Text = dr.Cells[0].Value.ToString();
				txtProductName.Text = dr.Cells[1].Value.ToString();
				txtPrice.Text = dr.Cells[2].Value.ToString();
				txtAvailableQty.Text = dr.Cells[3].Value.ToString();
				txtSaleQty.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			int vendite = 0;

			if (txtSaleQty.Text == "")
			{
				MessageBox.Show("Please enter no. of sale quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSaleQty.Focus();
				return;
			}
			else
			{
				int a = Convert.ToInt32(txtAvailableQty.Text);
				int b = Convert.ToInt32(txtSaleQty.Text);				

				if(a>= b)
				{
					vendite = a - b;

					try
					{
						con = new SqlConnection(cs.DBConn);
						con.Open();
						String sql = "UPDATE [Temp_Stock] SET[Temp_Stock].Quantity = " + Convert.ToString(vendite) + " WHERE[Temp_Stock].ProductID = '" + txtIdProduct.Text + "'";
						cmd = new SqlCommand(sql, con);
						rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
						dataGridView1.Rows.Clear();
						GetData();
						Reset();
						con.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Le quantità di vendita sono superiori alle quantità disponibili", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtSaleQty.Focus();
					return;

				}
			}

			
		}
	}
}