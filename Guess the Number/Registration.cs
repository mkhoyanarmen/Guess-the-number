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
	public partial class Registration : Form
	{

		public Registration()
		{
			InitializeComponent();
		}

		Login log = new Login();
		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (txtFirstname.Text == "" || txtLastname.Text == "" || txtPassword.Text =="" || txtUsername.Text == "")
			{
				MessageBox.Show("Please, check your datas", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MB68QJ7\SQLEXPRESS;Initial Catalog=RegistrationDB;Integrated Security=True");
				SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
		   ([Firstname]
		   ,[Lastname]
		   ,[Username]
		   ,[Password])

	 VALUES
		   ('" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')", con);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Register Succesfully!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Hide();
				log.Show();
			}
		}
	}
}
