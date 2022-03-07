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

namespace WindowsFormsApplication1
{
    public partial class gestionmarque : Form
    {
        public gestionmarque()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select *from Marque";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //activer la connection 
        private void gestionmarque_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
        }
        //botton quitter
        private void button4_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
        //boutton modifier une marque
        private void button2_Click(object sender, EventArgs e)
        {
            ModifMarque mm = new ModifMarque();
            mm.Show();
            this.Hide();
        }
        //boutton ajouter une marque
        private void button1_Click(object sender, EventArgs e)
        {
            Marque mrq = new Marque();
            mrq.Show();
            this.Hide();
        }

    }
}
