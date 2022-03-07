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
    public partial class AjouterCommande : Form
    {
        public AjouterCommande()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            reference.Clear();
            date.Value = DateTime.Today; ;
            article.Text="Sélectionner";
            marque.Text = "Sélectionner";
            technicien.Text ="Sélectionner";
            quantite.Clear();
            observation.Clear();
           
        }
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select * from Commande";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //methode existe
        int TechnicienExist(string x)
        {
            requete.Connection = maconnexion;
            requete.CommandText = "select count(*) from Commande where reference=@reference";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;

        }
        //charger combobox pour technicien
        void chargercomboboxtechnicien()
        {
            requete = new SqlCommand("select  code_tech from Technicien", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    technicien.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //charger combobox pour code Article 
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
        //activer le connection
        private void AjouterCommande_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            chargercomboboxarticle();
            chargercomboboxtechnicien();
        }
        //boutton ajouter
        private void button5_Click(object sender, EventArgs e)
        {

            if (reference.Text == " " || article.Text == " " || article.Text == "" || marque.Text == " " || technicien.Text == " " || quantite.Text == " "||prixunit.Text=="")
            {
                MessageBox.Show("entez les information de tous les champs!!");

            }
            else
            {
                if (TechnicienExist(reference.Text) == 0)
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter cette  Commande car tu ne peux pas le modifier?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Commande values(@reference,@date_commande,@code_barre,@article,@marque,@code_technicien,@prixunitare,@quantite,@montant,@observation)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = reference.Text;
                        requete.Parameters.AddWithValue("@date_commande", SqlDbType.Date).Value = date.Value;
                        requete.Parameters.AddWithValue("@code_barre", SqlDbType.VarChar).Value = code_barre.Text;
                        requete.Parameters.AddWithValue("@article", SqlDbType.VarChar).Value = article.Text;
                        requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = marque.Text;
                        requete.Parameters.AddWithValue("@code_technicien", SqlDbType.VarChar).Value = technicien.Text;
                        try
                        {
                            if (int.Parse(quantite.Text) <= 0)
                            {
                                MessageBox.Show("La quantite  doit être >=0 !!");
                            }
                            else
                            {
                                requete.Parameters.AddWithValue("@quantite", SqlDbType.Int).Value = quantite.Text;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur !!");
                        }
                        requete.Parameters.AddWithValue("@prixunitare", SqlDbType.Int).Value = prixunit.Text;
                        var mont = int.Parse(quantite.Text) * int.Parse(prix.Text);
                        label13.Text = mont.ToString();
                        requete.Parameters.AddWithValue("@montant ", SqlDbType.Int).Value = label13.Text;
                        requete.Parameters.AddWithValue("@observation", SqlDbType.VarChar).Value = observation.Text;

                        try
                        {
                            int x = requete.ExecuteNonQuery();
                            if (x == 0)
                                MessageBox.Show("vous n'avez pas fait l'ajout du  Commande!!");
                            else
                            {
                                MessageBox.Show("vous avez  faire fait l'ajout du Commande son reference: " + reference.Text);
                                
                                remplissage();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur  d'ajouter cet Commande ,vérifier tous les champs!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La reference pour cette  Commande  est déjà utiliser !!");
                    }
                }
            }
        }
        //aaficher marque apres selectionner article
        private void article_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select DISTINCT marque from Article where libelle=@article ", maconnexion);
            requete.Parameters.AddWithValue("@article", SqlDbType.VarChar).Value = article.Text;
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
        //actualiser marque
        private void article_SelectedValueChanged(object sender, EventArgs e)
        {
            marque.Items.Clear();
        }
        //aficher mon et prenom apres selectionner technicien
        private void technicien_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select Nom_tech,Prénom_tech from Technicien where code_tech=@technicien ", maconnexion);
            requete.Parameters.AddWithValue("@technicien", SqlDbType.VarChar).Value = technicien.Text;
            IDataReader dr = requete.ExecuteReader();
            while (dr.Read())
            {

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    label9.Text = dr[0].ToString();
                    label12.Text = dr[1].ToString();
                }


            }
            dr.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void quantite_TextChanged(object sender, EventArgs e)
        {
           
        }
        //aaficher prix unitaire apres selectionner marque
        private void marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select  prix_unitaire from Article where marque=@marque ", maconnexion);
            requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = marque.Text;
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    prixunit.Items.Add(DR.GetInt32(i));
                    

                }


            }
            DR.Close();
        }
        //aficher libelle apres selectionner code_barre
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select  libelle from Article where code_barre=@code_barre ", maconnexion);
            requete.Parameters.AddWithValue("@code_barre", SqlDbType.VarChar).Value = code_barre.Text;
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    article.Items.Add(DR.GetString(i));


                }


            }
            DR.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //aficher ttc apres selectionner prix unitair
        private void prixunit_SelectedIndexChanged(object sender, EventArgs e)
        {

            requete = new SqlCommand("select DISTINCT TTC from Article where prix_unitaire=@prixunit ", maconnexion);
            requete.Parameters.AddWithValue("@prixunit", SqlDbType.VarChar).Value = prixunit.Text;
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {

                    prix.Text = DR[0].ToString();

                }


            }
            DR.Close();
        }
        //actualiser  le prix unitaire
        private void marque_SelectedValueChanged(object sender, EventArgs e)
        {
            prixunit.Items.Clear();
        }
        //quitter
        private void button4_Click(object sender, EventArgs e)
        {
            commande c = new commande();
            c.Show();
            this.Hide();
        }
        //new
        private void button6_Click(object sender, EventArgs e)
        {
            effacer();
        }

        //actualiser  l'article
        private void code_barre_SelectedValueChanged(object sender, EventArgs e)
        {
            article.Items.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
