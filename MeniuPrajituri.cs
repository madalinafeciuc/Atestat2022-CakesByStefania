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
    public partial class MeniuPrajituri : Form
    {
        public MeniuPrajituri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        

        private void amandina_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[0];
            comanda.prajitura_txtBox.Text = "Amandina";
        }

        private void diplomat_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[1];
            comanda.prajitura_txtBox.Text = "Diplomat";
        }

        private void ecler_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[2];
            comanda.prajitura_txtBox.Text = "Ecler";
        }

        private void macarons_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[3];
            comanda.prajitura_txtBox.Text = "Macarons";
        }

        private void nunta_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[4];
            comanda.prajitura_txtBox.Text = "Tort de nunta";
        }

        private void pavlova_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[5];
            comanda.prajitura_txtBox.Text = "Pavlova";
        }

        private void savarina_btn_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            this.Hide();
            comanda.Closed += (s, args) => this.Close();
            comanda.Show();

            comanda.prajituri_pic.Image = imageList1.Images[6];
            comanda.prajitura_txtBox.Text = "Savarina";
        }
    }
}
