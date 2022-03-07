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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }
        //ajouter fournisseur
        private void button1_Click(object sender, EventArgs e)
        {
            AjouterFournisseur af = new AjouterFournisseur();
            af.Show();
            this.Hide();
        }
        //modifier fournisseur
        private void button2_Click(object sender, EventArgs e)
        {
            ModifierFournisseur mf= new ModifierFournisseur();
            mf.Show();
            this.Hide();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //remplissage date grid des fournisseurs
        void remplissage()
        {

            requete.CommandText = "select *from Founisseur";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView2.DataSource = DT;
        }
        //remplissage date grid des fournisseurs qui ont passer l'achat
        void remplissage1()
        {

            requete.CommandText = "select sum(quantite)as'Qté achat passer par Founisseur',Founisseur.code_fer,Founisseur.Nom_fer,Founisseur.Prénom_fer,Founisseur.Adresse from Founisseur inner join Achat on Achat.code_founisseur=Founisseur.code_fer group by Founisseur.code_fer,Founisseur.Nom_fer,Founisseur.Prénom_fer,Founisseur.Adresse";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //activer la connection
        private void Fournisseur_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            remplissage1();
        }
        //quitter
        private void button4_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
    }
}
