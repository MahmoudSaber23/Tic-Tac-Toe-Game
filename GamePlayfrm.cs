using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class GamePlayfrm : Form
    {

        string Player1Name;
        string Player2Name;

        public GamePlayfrm(string player1name,string player2name)
        {
            InitializeComponent();

            Player1Name = player1name;
            Player2Name = player2name;

            RestartGame();
        }

        private void GamePlayfrm_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);

            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            // Draw Horizontal Line
            e.Graphics.DrawLine(pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(pen, 400, 460, 1050, 460);


            // Vertical Line
            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 840, 140, 840, 620);
        }

        enum enPlayer
        {
            Player1,
            Player2
        }

        enPlayer PlayerTurn = enPlayer.Player1;

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;

            public bool GameOver;

            public short PlayCount;
        }

        stGameStatus GameStatus;


        public void ChangeImage(Button btn)
        {

            if (GameStatus.GameOver)
                return;

            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        btn.Tag = "X";
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = Player2Name;
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = Player1Name;
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount==9&&!GameStatus.GameOver)
            {
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
                EndGameStatus();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChangeImage(btn);
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Aquamarine;
                btn2.BackColor = Color.Aquamarine;
                btn3.BackColor = Color.Aquamarine;


                if(btn1.Tag.ToString()=="X")
                {  
                    GameStatus.Winner = enWinner.Player1;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                }

                GameStatus.GameOver = true;
                EndGameStatus();
                return true;

            }
            return false;
        }

        public void CheckWinner()
        {
            //CheckRows
            if (CheckValues(btn1, btn2, btn3)) return;
            if (CheckValues(btn4, btn5, btn6)) return;
            if (CheckValues(btn7, btn8, btn9)) return;


            //CheckCols
            if (CheckValues(btn1, btn4, btn7)) return;
            if (CheckValues(btn2, btn5, btn8)) return;
            if (CheckValues(btn3, btn6, btn9)) return;


            //CheckDiagonal
            if (CheckValues(btn1, btn5, btn9)) return;
            if (CheckValues(btn3, btn5, btn7)) return;
        }

        public void EndGameStatus()
        {
            lblTurn.Text = "Game Over!";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:

                    lblWinner.Text = Player1Name;
                    break;

                case enWinner.Player2:
                    lblWinner.Text = Player2Name;
                    break;

                default:

                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over!", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor= Color.Transparent;
        }
        public void RestartGame()
        {
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = Player1Name;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            lblWinner.Text = "In Progress";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
} 
