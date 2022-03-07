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
    public partial class Technicien : Form
    {
        public Technicien()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //remplissage date grid des techniciens qui ont passer les commandes
        void remplissage1()
        {

            requete.CommandText = "select sum(quantite)as'Qté commande passer par technicien',Technicien.code_tech,Technicien.Nom_tech,Technicien.Prénom_tech,Technicien.Adresse from Technicien inner join Commande on Technicien.code_tech=Commande.code_technicien group by Technicien.code_tech,Technicien.Nom_tech,Technicien.Prénom_tech,Technicien.Adresse";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //remplissage date grid des techniciens q
        void remplissage()
        {

            requete.CommandText = "select *from Technicien ";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView2.DataSource = DT;
        }

        //activer la connection
        private void Technicien_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage1();
            remplissage();
        }
        //Bouton Ajouter technicien
        private void button1_Click(object sender, EventArgs e)
        {
            AjouterTechnicien at = new AjouterTechnicien();
            at.Show();
            this.Hide();
        }
        //boutton Modifier technicien
        private void button2_Click(object sender, EventArgs e)
        {
            ModifierTechnicien mt = new ModifierTechnicien();
            mt.Show();
            this.Hide();
        }
        //boutton Quitter
        private void button4_Click(object sender, EventArgs e)
        {

            menu mn = new menu();
            mn.Show();
            this.Hide();
        }
    }
}
