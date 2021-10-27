using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Number
{
	public partial class Form1 : Form
	{
		Random numberGenerator;
		int generateNum;
		int PCNumber;
		int playerNumber;
		int playerScore = 0;
		int PCScore = 0;
		int i = 1;
		int guessNumberMinBound = 1;
		int guessNumberMaxBound = 101;
		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void Form1_Load(object sender, EventArgs e)
		{

			numberGenerator = new Random();
			generateNum = numberGenerator.Next(1, 101);
			PCNumber = numberGenerator.Next(1, 101);
			gbPlayer.Enabled = false;
			gbPC.Enabled = false;

		}
		private void btnPlayerSubmit_Click(object sender, EventArgs e)
		{
			bool isPlayerNumberInteger = int.TryParse(txtPlayerNum.Text, out playerNumber);
			if (!isPlayerNumberInteger)
			{
				MessageBox.Show("Entered is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			bool isPlayerNumberFromCorrectRange = playerNumber >= 1 && playerNumber <= 100;
			if (!isPlayerNumberFromCorrectRange)
			{
				MessageBox.Show("Enter the number from correct range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (playerNumber > generateNum)
			{
				lblPlayerRes.Text = "Entered number is greater";
				lblPCNum.Text = PCNumber.ToString();
				gbPlayer.Enabled = false;
				gbPC.Enabled = true;
			}
			else if (playerNumber < generateNum)
			{
				lblPlayerRes.Text = "Entered number is less";
				lblPCNum.Text = PCNumber.ToString();
				gbPlayer.Enabled = false;
				gbPC.Enabled = true;
			}
			else
			{
				MessageBox.Show("The Player Wins!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gbPC.Enabled = false;
				gbPlayer.Enabled = false;
				playerScore += 1;
				lblPlayerScore.Text = playerScore.ToString();
			}

			if (rbMediumMode.Checked == true)
			{
				MediumMode();
			}
			else if (rbHardMode.Checked == true)
			{
				HardMode();
			}
		}


		private void btnPCSubmit_Click(object sender, EventArgs e)
		{
			if (rbGreaterThan.Checked || rbLessThan.Checked)
			{
				gbPC.Enabled = false;
				gbPlayer.Enabled = true;
			}
			else
			{
				MessageBox.Show("The PC Wins!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PCScore += 1;
				lblPCScore.Text = PCScore.ToString();
				gbPC.Enabled = false;
				gbPlayer.Enabled = false;
			}

		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (gbPC.Enabled == true)
			{
				MessageBox.Show("Do you want to restart the game?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			}
			txtPlayerNum.Clear();
			lblPlayerRes.Text = "";
			lblPCNum.Text = "";
			gbPlayer.Enabled = true;
			gbPC.Enabled = false;

			if (rbHardMode.Checked == true)
			{
				rbGreaterThan.Visible = rbEqual.Visible = rbLessThan.Visible = false;
			}
			else
			{
				rbGreaterThan.Visible = rbEqual.Visible = rbLessThan.Visible = true;
			}
		}

		private void btnCleanResult_Click(object sender, EventArgs e)
		{
			if (rbHardMode.Checked == true)
			{
				lstResult.Items.Add($"Game {i}. {lblPlayerScore.Text} : {lblPCScore.Text} mode:Hard");
			}
			else if (rbEasyMode.Checked == true)
			{
				lstResult.Items.Add($"Game {i}. {lblPlayerScore.Text} : {lblPCScore.Text} mode:Easy");
			}
			else
			{
				lstResult.Items.Add($"Game {i}. {lblPlayerScore.Text} : {lblPCScore.Text} mode:Medium");
			}

			i++;
			lblPlayerScore.Text = "0";
			lblPCScore.Text = "0";
			PCScore = 0;
			playerScore = 0;
		}

		private void btnCleanResults_Click(object sender, EventArgs e)
		{
			lstResult.Items.Clear();
			i = 1;
		}

		public void MediumMode()
		{
			int mid = (guessNumberMinBound + guessNumberMaxBound) / 2;
			if (rbLessThan.Checked == true)
			{
				mid = playerNumber;
				PCNumber = numberGenerator.Next(mid, guessNumberMaxBound);
				lblPCNum.Text = PCNumber.ToString();
			}
			else if (rbGreaterThan.Checked == true)
			{
				mid = playerNumber;
				PCNumber = numberGenerator.Next(guessNumberMinBound, mid);
				lblPCNum.Text = PCNumber.ToString();
			}
			else
			{
				PCNumber = numberGenerator.Next(1, 101);
				lblPCNum.Text = PCNumber.ToString();
			}
			
		}

		public void HardMode()
		{
			PCNumber = numberGenerator.Next(playerNumber - 2, playerNumber + 3);
			if (PCNumber == playerNumber)
			{
				MessageBox.Show("The PC Wins!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gbPC.Enabled = false;
				gbPlayer.Enabled = false;
				PCScore += 1;
				lblPCScore.Text = PCScore.ToString();
			}
			lblPCNum.Text = "";
			lblPCNum.Text = PCNumber.ToString();
		}
	}
}
