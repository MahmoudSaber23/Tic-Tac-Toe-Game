using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Playfrm : Form
    {
        public Playfrm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == "" || txtName2.Text == "")
            {
                MessageBox.Show("Please Enter Players Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form GamePlay = new GamePlayfrm(txtName1.Text, txtName2.Text);
                GamePlay.ShowDialog();
            }

        }
    }
}
