using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_2022_Cofetarie
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cakes_btn_Click(object sender, EventArgs e)
        {
            MeniuPrajituri prajituri = new MeniuPrajituri();
            this.Hide();
            prajituri.Closed += (s, args) => this.Close();
            prajituri.Show();
        }

        private void comenzi_btn_Click(object sender, EventArgs e)
        {
            Comenzi comenzi = new Comenzi();
            this.Hide();
            comenzi.Closed += (s, args) => this.Close();
            comenzi.Show();
        }
    }
}
