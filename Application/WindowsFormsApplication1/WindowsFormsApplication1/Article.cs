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
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            codebarre.Clear();
            libelle.Clear();
            prixunitaire.Clear();
            tva.Clear();
            label15.Text = " 0 ";
            categorie.Text = "selectinner";
            marque.Text = "selectinner";
            model.Text = "selectinner";
            garantie.Clear();
            description.Clear();
            observation.Clear();

        }
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select *from Article";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //methode existe
        int articlExist(string x)
        {
            requete.Connection = maconnexion;
            requete.CommandText = "select count(*) from Article where code_barre=@codebarre";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@codebarre", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;
        }
        //charger combobox pour categorie
        void chargercomboboxcategorie()
        {
            requete = new SqlCommand("select  DISTINCT nom_Catégorie from Catégorie", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    categorie.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //charger combobox pour marque
        void chargercomboboxmarque()
        {
            requete = new SqlCommand("select DISTINCT Marque from Marque", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    marque.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //charger combobox pour model
        void chargercomboboxmodel()
        {
            requete = new SqlCommand("select DISTINCT Model from Marque", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    model.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
       
        //activer le connection
        private void Article_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            chargercomboboxcategorie();
            chargercomboboxmarque();
            chargercomboboxmodel();

            
            
        }

        //BOUTTON QUITTER
        private void button2_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }
        //BOUTTON NEW
        private void button3_Click(object sender, EventArgs e)
        {
            this.effacer();
        }
        //BOUTTON AJOUTER
        private void button1_Click(object sender, EventArgs e)
        { 
            if (codebarre.Text == "" || libelle.Text == "" || prixunitaire.Text == "" ||  tva.Text == "" || categorie.Text == "" || marque.Text == "" || model.Text == "")
            {
                MessageBox.Show("entez les information de tous les champs apres l'ajout!!");
            }
            else
            {
                if (articlExist(codebarre.Text) == 0)
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter cet article?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Article values(@code_barre,@libelle,@prix_unitaire,@TVA,@TTC,@Categorie,@Modele,@marque,@Garantie,@Observation,@Description)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@code_barre", SqlDbType.VarChar).Value = codebarre.Text;
                        requete.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = libelle.Text;
                        try
                        {
                            if (int.Parse(prixunitaire.Text) <= 0)
                            {
                                MessageBox.Show("Le prix unitaire doit être >=0 !!");
                            }
                            else
                            {
                                requete.Parameters.AddWithValue("@prix_unitaire", SqlDbType.Int).Value = prixunitaire.Text;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur !!");
                        }
                        
                        try
                        {
                            if (int.Parse(tva.Text) <5 || int.Parse(tva.Text) >30)
                            {
                                MessageBox.Show("TVA  doit etre entre 5% et 30% !!");
                            }
                            else
                            {
                        requete.Parameters.AddWithValue("@TVA", SqlDbType.Int).Value = tva.Text;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur !!");
                        }
                        label15.Text = prixunitaire.Text + (int.Parse(prixunitaire.Text) * (int.Parse(tva.Text) / 100));
                        
                        requete.Parameters.AddWithValue("@TTC", SqlDbType.Int).Value =label15.Text;
                        requete.Parameters.AddWithValue("@Categorie", SqlDbType.VarChar).Value = categorie.Text;
                        requete.Parameters.AddWithValue("@Modele", SqlDbType.VarChar).Value = marque.Text;
                        requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = model.Text;
                        try
                        {
                            if (int.Parse(garantie.Text) >6)
                            {
                                MessageBox.Show("La garantie  ne doit pas dépasser 6 mois !!");
                            }
                            else
                            {
                                requete.Parameters.AddWithValue("@Garantie", SqlDbType.Int).Value = garantie.Text;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur !!");
                        }
                        
                        requete.Parameters.AddWithValue("@Observation", SqlDbType.VarChar).Value = observation.Text;
                        requete.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = description.Text;
                        try
                        {
                            int x = requete.ExecuteNonQuery();
                            if (x == 0)
                                MessageBox.Show("vous n'avez pas faire l'ajout acun article !!");
                            else
                            {
                                MessageBox.Show("vous avez  faire l'ajout un article son Code Barre est " + codebarre.Text);
                                
                            }

                        }
                        catch
                        {

                            MessageBox.Show("Erreur  d'ajouter cette article ,vérifier tous les champs!!");

                        }
                        
                        remplissage();
                    }
                    else
                    {
                        MessageBox.Show("Cet aticle est déjà ajouter !!");
                    }
                }
            }
        }

        private void categorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
