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
    public partial class ArticleModifier : Form
    {
        public ArticleModifier()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            code_barre.Text = "selectinner";
            libelle.Clear();
            prix_unitaire.Clear();
            TVA.Clear();
            TTC.Text = " 0 ";
            nom_Catégorie.Text = "selectinner";
            marque.Text = "selectinner";
            model.Text = "selectinner";
            Garantie.Clear();
            Description.Clear();
            Observation.Clear();

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
                    nom_Catégorie.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //charger combobox pour article
        void chargercomboboxarticle()
        {
            requete = new SqlCommand("select  code_barre from Article", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    code_barre.Items.Add(DR.GetString(i));
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
        private void ArticleModifier_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            chargercomboboxcategorie();
            chargercomboboxmarque();
            chargercomboboxarticle();
        }
        //boutton quitter
        private void button3_Click(object sender, EventArgs e)
        {
            this.effacer();
        }
        //BOUTTON QUITTER
        private void button2_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }
        //boutton modifier
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("voulez vous vraiment modifier cette reference?", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (code_barre.Text == "" || libelle.Text == "" || prix_unitaire.Text == "" || TVA.Text == "" || TTC.Text == "" || nom_Catégorie.Text == "" || marque.Text == "" || model.Text == "" || Garantie.Text == "" || Observation.Text == "" || Description.Text == "")
                {
                    MessageBox.Show("entez les information de tous les champs apres la modification !!");
                }
                else
                {
                    requete.Connection = maconnexion;
                    requete.CommandText = "update Article set libelle=@libelle,prix_unitaire=@prix_unitaire,TVA=@TVA,TTC=@TTC,nom_Catégorie=@nom_Catégorie,marque=@marque,model=@model,Garantie=@Garantie,Observation=@Observation,Description=@Description where code_barre=@code_barre";

                    requete.Parameters.Clear();
                    requete.Parameters.AddWithValue("@code_barre", SqlDbType.VarChar).Value = code_barre.Text;
                    requete.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = libelle.Text;
                    try
                    {
                        if (int.Parse(prix_unitaire.Text) <= 0)
                        {
                            MessageBox.Show("Le prix unitaire doit être >=0 !!");
                        }
                        else
                        {
                            requete.Parameters.AddWithValue("@prix_unitaire", SqlDbType.Int).Value = prix_unitaire.Text;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erreur !!");
                    }

                    try
                    {
                        if (int.Parse(TVA.Text) < 5 || int.Parse(TVA.Text) > 30)
                        {
                            MessageBox.Show("TVA  doit etre entre 5% et 30% !!");
                        }
                        else
                        {
                            requete.Parameters.AddWithValue("@TVA", SqlDbType.Int).Value = TVA.Text;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erreur !!");
                    }
                    TTC.Text = prix_unitaire.Text + (int.Parse(prix_unitaire.Text) * (int.Parse(TVA.Text) / 100));

                    requete.Parameters.AddWithValue("@TTC", SqlDbType.Int).Value = TTC.Text;
                    requete.Parameters.AddWithValue("@nom_Catégorie", SqlDbType.VarChar).Value = nom_Catégorie.Text;
                    requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = marque.Text;
                    requete.Parameters.AddWithValue("@model", SqlDbType.VarChar).Value = model.Text;
                    try
                    {
                        if (int.Parse(Garantie.Text) > 6)
                        {
                            MessageBox.Show("La garantie  ne doit pas dépasser 6 mois !!");
                        }
                        else
                        {
                            requete.Parameters.AddWithValue("@Garantie", SqlDbType.Int).Value = Garantie.Text;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erreur !!");
                    }

                    requete.Parameters.AddWithValue("@Observation", SqlDbType.VarChar).Value = Observation.Text;
                    requete.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = Description.Text;
                    try
                    {
                        int x = requete.ExecuteNonQuery();
                        if (x == 0)
                            MessageBox.Show("vous n'avez pas faire la modification  acun article !!");
                        else
                        {
                            MessageBox.Show("vous avez  faire la modification d'article son Code Barre est " + code_barre.Text);

                        }



                        
                    }
                    catch
                    {
                        MessageBox.Show("Erreur  de modifier cette article ,vérifier tous les champs!!");
                    }

                    remplissage();
                }

            }
            else
            {
                MessageBox.Show("vous avez anuller la modification !");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        //selectionner code et afficher les text boxs
        private void codebarre_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete.CommandText = "select * from Article ";
            requete.Connection = maconnexion;
            IDataReader dr = requete.ExecuteReader();
            while (dr.Read())
            {
                libelle.Text = dr.GetValue(1).ToString();
                prix_unitaire.Text = dr.GetValue(2).ToString();
                TVA.Text = dr.GetValue(3).ToString();
                TTC.Text = dr.GetValue(4).ToString();
                nom_Catégorie.Text = dr.GetValue(5).ToString();
                marque.Text = dr.GetValue(6).ToString();
                model.Text = dr.GetValue(7).ToString();
                Garantie.Text = dr.GetValue(8).ToString();
                Observation.Text = dr.GetValue(9).ToString();
                Description.Text = dr.GetValue(10).ToString();


            }
            dr.Close();
        }


    }
}
