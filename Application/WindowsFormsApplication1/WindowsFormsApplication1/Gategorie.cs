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
    public partial class Gategorie : Form
    {
        public Gategorie()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select *from Catégorie";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //activer la connection
        private void Gategorie_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
        }

        //BOUTTON QUITTER
        private void button4_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
        //boutton pour ajouter categorie
        private void button1_Click(object sender, EventArgs e)
        {
            AjouterGategorie ag = new AjouterGategorie();
            ag.Show();
            this.Hide();
        }
        //boutton pour modifier categorie
        private void button2_Click(object sender, EventArgs e)
        {
            ModifierGategorie mg = new ModifierGategorie();
            mg.Show();
            this.Hide();
        }

       
    }
}
