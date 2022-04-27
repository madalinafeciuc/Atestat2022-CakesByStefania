using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atestat_2022_Cofetarie
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Comenzi.mdf;Integrated Security=True;Connect Timeout=30");

        private void Comenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comenziDataSet.Comenzi' table. You can move, or remove it, as needed.
            
            dataBind();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        public void dataBind()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Nume as Nume, Prenume as Prenume, Nume_prajitura as Nume_prajitura, Nr_buc as Nr_buc, Observatii as Observatii From dbo.Comenzi", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
