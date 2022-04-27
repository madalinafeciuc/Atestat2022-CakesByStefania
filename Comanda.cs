using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atestat_2022_Cofetarie
{
    public partial class Comanda : Form
    {
        public Comanda()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Comenzi.mdf;Integrated Security=True;Connect Timeout=30");


        private void back_btn_Click(object sender, EventArgs e)
        {
            MeniuPrajituri menuPraj = new MeniuPrajituri();
            this.Hide();
            menuPraj.Closed += (s, args) => this.Close();
            menuPraj.Show();
        }

        private void nume_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cratima = (char)0x2D;

           if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != cratima)
           {
              e.Handled = true;
           }
            else if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Nu se pot adauga spatii. Folositi cratima in caz ca aveti mai mult de un nume.");
            }
        }

        private void prenume_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cratima = (char)0x2D;

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != cratima)
            {
                e.Handled = true;
            }
            else if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Nu se pot adauga spatii. Folositi cratima in caz ca aveti mai mult de un prenume.");
            }
        }

        private void nrBuc_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            else if(e.Handled=(e.KeyChar==(char)Keys.Space))
            {
                MessageBox.Show("Nu se pot adauga spatii. Folositi doar numere.");
            }
        }

        private void comanda_btn_Click(object sender, EventArgs e)
        {
            if(nume_txtBox.Text=="" || prenume_txtBox.Text=="" || nrBuc_txtBox.Text=="")
            {
                MessageBox.Show("Verificati daca ati completat toate campurile");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into dbo.Comenzi(Nume, Prenume, Nume_prajitura, Nr_buc, Observatii)Values('" + nume_txtBox.Text + "', '" + prenume_txtBox.Text + "', '" + prajitura_txtBox.Text + "', '" + nrBuc_txtBox.Text + "', '"+obs_txtBox.Text+"')", con);
                
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Comanda finalizata cu succes!");

                con.Close();



                MainMenu menu = new MainMenu();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                obs_txtBox.ReadOnly = false;
                checkBox1.Text = "Da";
            }
            else
            {
                obs_txtBox.ReadOnly = true;
                obs_txtBox.Text = string.Empty;
                checkBox1.Text = "Nu";
            }
            
        }
    }
}
