﻿
namespace Guess_the_Number
{
	partial class Registration
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
			this.gbRegister = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.gbRegister.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbRegister
			// 
			this.gbRegister.Controls.Add(this.btnRegister);
			this.gbRegister.Controls.Add(this.txtPassword);
			this.gbRegister.Controls.Add(this.label4);
			this.gbRegister.Controls.Add(this.txtUsername);
			this.gbRegister.Controls.Add(this.label3);
			this.gbRegister.Controls.Add(this.txtLastname);
			this.gbRegister.Controls.Add(this.label2);
			this.gbRegister.Controls.Add(this.txtFirstname);
			this.gbRegister.Controls.Add(this.label1);
			this.gbRegister.Location = new System.Drawing.Point(160, 55);
			this.gbRegister.Name = "gbRegister";
			this.gbRegister.Size = new System.Drawing.Size(475, 320);
			this.gbRegister.TabIndex = 0;
			this.gbRegister.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firstname";
			// 
			// txtFirstname
			// 
			this.txtFirstname.Location = new System.Drawing.Point(172, 55);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(189, 22);
			this.txtFirstname.TabIndex = 1;
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(172, 83);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(189, 22);
			this.txtLastname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lastname";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(172, 111);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(189, 22);
			this.txtUsername.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(172, 139);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(189, 22);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(97, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(253, 181);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(108, 45);
			this.btnRegister.TabIndex = 8;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbRegister);
			this.Name = "Registration";
			this.Text = "Registration";
			this.gbRegister.ResumeLayout(false);
			this.gbRegister.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbRegister;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLastname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFirstname;
	}
}