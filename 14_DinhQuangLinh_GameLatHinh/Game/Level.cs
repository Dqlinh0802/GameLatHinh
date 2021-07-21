using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }
        //Tạo các class dùng chung và các giá trị của các mức độ
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btDe_Click(object sender, EventArgs e)
        {
            DC.cot = 4;
            DC.dong = 2;
            DC.countDown = 30;
            NewGame fNewGame = new NewGame();
            fNewGame.FormClosed += new FormClosedEventHandler(fNewGame_Closed);
            fNewGame.Show();
            this.Hide();
        }
        private void fNewGame_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btTrungBinh_Click(object sender, EventArgs e)
        {
            DC.cot = 5;
            DC.dong = 2;
            DC.countDown = 45;
            NewGame fNewGame = new NewGame();
            fNewGame.FormClosed += new FormClosedEventHandler(fNewGame_Closed);
            fNewGame.Show();
            this.Hide();
        }
        private void btKho_Click(object sender, EventArgs e)
        {
            DC.cot = 6;
            DC.dong = 2;
            DC.countDown = 60;
            NewGame fNewGame = new NewGame();
            fNewGame.FormClosed += new FormClosedEventHandler(fNewGame_Closed);
            fNewGame.Show();
            this.Hide();
        }

        private void Level_Load(object sender, EventArgs e)
        {

        }
    }
    public static class DC
    {
        static public int dong;
        static public int cot;
        static public int countDown;
    }
}
