using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Home : Form
    {
        //Form gọi cái Form NewGame, Tutorial
        public Home()
        {
            InitializeComponent();
        }
        private void btNewGame_Click(object sender, EventArgs e)
        {
            Level fLevel = new Level();
            fLevel.FormClosed += new FormClosedEventHandler(fLevel_Closed);
            fLevel.Show();
            this.Hide();   
        }
        private void fNewGame_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void fLevel_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            
        }
        private void btTutorial_Click(object sender, EventArgs e)
        {
            Tutorial fTutorial = new Tutorial();
            fTutorial.FormClosed += new FormClosedEventHandler(fTutorial_Closed);
            fTutorial.Show();
            this.Hide();
        }
        private void fTutorial_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
