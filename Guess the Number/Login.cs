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

namespace Guess_the_Number
{
	public partial class Login : Form
	{

		public Login()
		{
			InitializeComponent();
		}

		private void btnRegistration_Click(object sender, EventArgs e)
		{
			Registration reg = new Registration();
			reg.Show();
			this.Hide();
		}
		Form1 form = new Form1();
		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MB68QJ7\SQLEXPRESS;Initial Catalog=RegistrationDB;Integrated Security=True");
			string query = "Select * from register Where Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim()+"'";
			SqlDataAdapter sda = new SqlDataAdapter(query, con);
			DataTable dt1 = new DataTable();
			sda.Fill(dt1);
			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Please, input username and password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (dt1.Rows.Count == 1)
			{
				MessageBox.Show("Login Succesfully", "Congratulations!", MessageBoxButtons.OK);
				this.Hide();
				form.Show();
			}
			else
			{
				MessageBox.Show("Please,check your username and password", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}
	}
}
