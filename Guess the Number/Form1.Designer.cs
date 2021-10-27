
namespace Guess_the_Number
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbPlayer = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblPlayerRes = new System.Windows.Forms.Label();
			this.btnPlayerSubmit = new System.Windows.Forms.Button();
			this.txtPlayerNum = new System.Windows.Forms.TextBox();
			this.gbPC = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnPCSubmit = new System.Windows.Forms.Button();
			this.rbEqual = new System.Windows.Forms.RadioButton();
			this.rbLessThan = new System.Windows.Forms.RadioButton();
			this.lblPCNum = new System.Windows.Forms.Label();
			this.rbGreaterThan = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbMediumMode = new System.Windows.Forms.RadioButton();
			this.rbHardMode = new System.Windows.Forms.RadioButton();
			this.rbEasyMode = new System.Windows.Forms.RadioButton();
			this.btnSaveResult = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPCScore = new System.Windows.Forms.Label();
			this.lblPlayerScore = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gbResult = new System.Windows.Forms.GroupBox();
			this.btnCleanResults = new System.Windows.Forms.Button();
			this.lstResult = new System.Windows.Forms.ListBox();
			this.gbPlayer.SuspendLayout();
			this.gbPC.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPlayer
			// 
			this.gbPlayer.Controls.Add(this.label2);
			this.gbPlayer.Controls.Add(this.label5);
			this.gbPlayer.Controls.Add(this.lblPlayerRes);
			this.gbPlayer.Controls.Add(this.btnPlayerSubmit);
			this.gbPlayer.Controls.Add(this.txtPlayerNum);
			this.gbPlayer.Location = new System.Drawing.Point(27, 21);
			this.gbPlayer.Name = "gbPlayer";
			this.gbPlayer.Size = new System.Drawing.Size(315, 312);
			this.gbPlayer.TabIndex = 0;
			this.gbPlayer.TabStop = false;
			this.gbPlayer.Text = "Player";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(24, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Result:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "Player Number:";
			// 
			// lblPlayerRes
			// 
			this.lblPlayerRes.AutoSize = true;
			this.lblPlayerRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPlayerRes.Location = new System.Drawing.Point(97, 168);
			this.lblPlayerRes.Name = "lblPlayerRes";
			this.lblPlayerRes.Size = new System.Drawing.Size(0, 18);
			this.lblPlayerRes.TabIndex = 2;
			// 
			// btnPlayerSubmit
			// 
			this.btnPlayerSubmit.Location = new System.Drawing.Point(66, 89);
			this.btnPlayerSubmit.Name = "btnPlayerSubmit";
			this.btnPlayerSubmit.Size = new System.Drawing.Size(137, 44);
			this.btnPlayerSubmit.TabIndex = 1;
			this.btnPlayerSubmit.Text = "Submit";
			this.btnPlayerSubmit.UseVisualStyleBackColor = true;
			this.btnPlayerSubmit.Click += new System.EventHandler(this.btnPlayerSubmit_Click);
			// 
			// txtPlayerNum
			// 
			this.txtPlayerNum.Location = new System.Drawing.Point(137, 41);
			this.txtPlayerNum.Name = "txtPlayerNum";
			this.txtPlayerNum.Size = new System.Drawing.Size(100, 22);
			this.txtPlayerNum.TabIndex = 0;
			// 
			// gbPC
			// 
			this.gbPC.Controls.Add(this.label6);
			this.gbPC.Controls.Add(this.btnPCSubmit);
			this.gbPC.Controls.Add(this.rbEqual);
			this.gbPC.Controls.Add(this.rbLessThan);
			this.gbPC.Controls.Add(this.lblPCNum);
			this.gbPC.Controls.Add(this.rbGreaterThan);
			this.gbPC.Location = new System.Drawing.Point(348, 21);
			this.gbPC.Name = "gbPC";
			this.gbPC.Size = new System.Drawing.Size(320, 312);
			this.gbPC.TabIndex = 1;
			this.gbPC.TabStop = false;
			this.gbPC.Text = "PC";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(96, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "PC Number:";
			// 
			// btnPCSubmit
			// 
			this.btnPCSubmit.Location = new System.Drawing.Point(109, 89);
			this.btnPCSubmit.Name = "btnPCSubmit";
			this.btnPCSubmit.Size = new System.Drawing.Size(137, 44);
			this.btnPCSubmit.TabIndex = 6;
			this.btnPCSubmit.Text = "Submit";
			this.btnPCSubmit.UseVisualStyleBackColor = true;
			this.btnPCSubmit.Click += new System.EventHandler(this.btnPCSubmit_Click);
			// 
			// rbEqual
			// 
			this.rbEqual.AutoSize = true;
			this.rbEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbEqual.Location = new System.Drawing.Point(239, 166);
			this.rbEqual.Name = "rbEqual";
			this.rbEqual.Size = new System.Drawing.Size(40, 24);
			this.rbEqual.TabIndex = 5;
			this.rbEqual.TabStop = true;
			this.rbEqual.Text = "=";
			this.rbEqual.UseVisualStyleBackColor = true;
			// 
			// rbLessThan
			// 
			this.rbLessThan.AutoSize = true;
			this.rbLessThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbLessThan.Location = new System.Drawing.Point(166, 166);
			this.rbLessThan.Name = "rbLessThan";
			this.rbLessThan.Size = new System.Drawing.Size(40, 24);
			this.rbLessThan.TabIndex = 4;
			this.rbLessThan.TabStop = true;
			this.rbLessThan.Text = "<";
			this.rbLessThan.UseVisualStyleBackColor = true;
			// 
			// lblPCNum
			// 
			this.lblPCNum.AutoSize = true;
			this.lblPCNum.Location = new System.Drawing.Point(186, 44);
			this.lblPCNum.Name = "lblPCNum";
			this.lblPCNum.Size = new System.Drawing.Size(0, 17);
			this.lblPCNum.TabIndex = 0;
			// 
			// rbGreaterThan
			// 
			this.rbGreaterThan.AutoSize = true;
			this.rbGreaterThan.Checked = true;
			this.rbGreaterThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbGreaterThan.Location = new System.Drawing.Point(99, 166);
			this.rbGreaterThan.Name = "rbGreaterThan";
			this.rbGreaterThan.Size = new System.Drawing.Size(40, 24);
			this.rbGreaterThan.TabIndex = 3;
			this.rbGreaterThan.TabStop = true;
			this.rbGreaterThan.Text = ">";
			this.rbGreaterThan.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbMediumMode);
			this.groupBox3.Controls.Add(this.rbHardMode);
			this.groupBox3.Controls.Add(this.rbEasyMode);
			this.groupBox3.Controls.Add(this.btnSaveResult);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.lblPCScore);
			this.groupBox3.Controls.Add(this.lblPlayerScore);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(674, 21);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(293, 312);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Game";
			// 
			// rbMediumMode
			// 
			this.rbMediumMode.AutoSize = true;
			this.rbMediumMode.Location = new System.Drawing.Point(112, 169);
			this.rbMediumMode.Name = "rbMediumMode";
			this.rbMediumMode.Size = new System.Drawing.Size(78, 21);
			this.rbMediumMode.TabIndex = 11;
			this.rbMediumMode.Text = "Medium";
			this.rbMediumMode.UseVisualStyleBackColor = true;
			// 
			// rbHardMode
			// 
			this.rbHardMode.AutoSize = true;
			this.rbHardMode.Location = new System.Drawing.Point(205, 169);
			this.rbHardMode.Name = "rbHardMode";
			this.rbHardMode.Size = new System.Drawing.Size(60, 21);
			this.rbHardMode.TabIndex = 10;
			this.rbHardMode.Text = "Hard";
			this.rbHardMode.UseVisualStyleBackColor = true;
			// 
			// rbEasyMode
			// 
			this.rbEasyMode.AutoSize = true;
			this.rbEasyMode.Checked = true;
			this.rbEasyMode.Location = new System.Drawing.Point(29, 168);
			this.rbEasyMode.Name = "rbEasyMode";
			this.rbEasyMode.Size = new System.Drawing.Size(60, 21);
			this.rbEasyMode.TabIndex = 9;
			this.rbEasyMode.TabStop = true;
			this.rbEasyMode.Text = "Easy";
			this.rbEasyMode.UseVisualStyleBackColor = true;
			// 
			// btnSaveResult
			// 
			this.btnSaveResult.Location = new System.Drawing.Point(46, 89);
			this.btnSaveResult.Name = "btnSaveResult";
			this.btnSaveResult.Size = new System.Drawing.Size(199, 54);
			this.btnSaveResult.TabIndex = 8;
			this.btnSaveResult.Text = "Save and Clean Result";
			this.btnSaveResult.UseVisualStyleBackColor = true;
			this.btnSaveResult.Click += new System.EventHandler(this.btnCleanResult_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(29, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 85);
			this.button1.TabIndex = 0;
			this.button1.Text = "New Game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(184, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 36);
			this.label4.TabIndex = 3;
			this.label4.Text = ":";
			// 
			// lblPCScore
			// 
			this.lblPCScore.AutoSize = true;
			this.lblPCScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPCScore.Location = new System.Drawing.Point(213, 37);
			this.lblPCScore.Name = "lblPCScore";
			this.lblPCScore.Size = new System.Drawing.Size(32, 36);
			this.lblPCScore.TabIndex = 2;
			this.lblPCScore.Text = "0";
			this.lblPCScore.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblPlayerScore
			// 
			this.lblPlayerScore.AutoSize = true;
			this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPlayerScore.Location = new System.Drawing.Point(146, 37);
			this.lblPlayerScore.Name = "lblPlayerScore";
			this.lblPlayerScore.Size = new System.Drawing.Size(32, 36);
			this.lblPlayerScore.TabIndex = 1;
			this.lblPlayerScore.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(40, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Result";
			// 
			// gbResult
			// 
			this.gbResult.Controls.Add(this.btnCleanResults);
			this.gbResult.Controls.Add(this.lstResult);
			this.gbResult.Location = new System.Drawing.Point(1023, 21);
			this.gbResult.Name = "gbResult";
			this.gbResult.Size = new System.Drawing.Size(308, 311);
			this.gbResult.TabIndex = 2;
			this.gbResult.TabStop = false;
			this.gbResult.Text = "Results";
			// 
			// btnCleanResults
			// 
			this.btnCleanResults.Location = new System.Drawing.Point(197, 274);
			this.btnCleanResults.Name = "btnCleanResults";
			this.btnCleanResults.Size = new System.Drawing.Size(75, 23);
			this.btnCleanResults.TabIndex = 1;
			this.btnCleanResults.Text = "Clean";
			this.btnCleanResults.UseVisualStyleBackColor = true;
			this.btnCleanResults.Click += new System.EventHandler(this.btnCleanResults_Click);
			// 
			// lstResult
			// 
			this.lstResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lstResult.FormattingEnabled = true;
			this.lstResult.ItemHeight = 22;
			this.lstResult.Location = new System.Drawing.Point(24, 44);
			this.lstResult.Name = "lstResult";
			this.lstResult.Size = new System.Drawing.Size(248, 224);
			this.lstResult.TabIndex = 0;
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1383, 427);
			this.Controls.Add(this.gbResult);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.gbPC);
			this.Controls.Add(this.gbPlayer);
			this.Name = "Form1";
			this.Text = "Guess the number";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbPlayer.ResumeLayout(false);
			this.gbPlayer.PerformLayout();
			this.gbPC.ResumeLayout(false);
			this.gbPC.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.gbResult.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPlayer;
		private System.Windows.Forms.RadioButton rbEqual;
		private System.Windows.Forms.RadioButton rbLessThan;
		private System.Windows.Forms.RadioButton rbGreaterThan;
		private System.Windows.Forms.Button btnPlayerSubmit;
		private System.Windows.Forms.TextBox txtPlayerNum;
		private System.Windows.Forms.GroupBox gbPC;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnPCSubmit;
		private System.Windows.Forms.Label lblPCNum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPCScore;
		private System.Windows.Forms.Label lblPlayerScore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblPlayerRes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSaveResult;
		private System.Windows.Forms.GroupBox gbResult;
		private System.Windows.Forms.ListBox lstResult;
		private System.Windows.Forms.Button btnCleanResults;
		private System.Windows.Forms.RadioButton rbHardMode;
		private System.Windows.Forms.RadioButton rbEasyMode;
		private System.Windows.Forms.RadioButton rbMediumMode;
	}
}

