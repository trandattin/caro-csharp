using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            
            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark, pctbAvt);

            NewGame();
        }

        #region Methods 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewGame()
        {
            ChessBoard.DrawChessBoard();
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Quit()
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion Methods
    }
}
