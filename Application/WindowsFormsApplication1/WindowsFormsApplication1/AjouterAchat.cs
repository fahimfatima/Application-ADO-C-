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
    public partial class AjouterAchat : Form
    {
        public AjouterAchat()
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
            article.Text = "Sélectionner";
            marque.Text = "Sélectionner";
            fernisseur.Text = "Sélectionner";
            quantite.Clear();
            numfac.Clear();
            nbv.Clear();
            observation.Clear();

        }
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select * from  Achat";
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
            requete.CommandText = "select count(*) from  Achat where reference=@reference";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;

        }
        //charger combobox pour Article
        void chargercomboboxfernisseur()
        {
            requete = new SqlCommand("select  code_fer from Founisseur", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    fernisseur.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //charger combobox pour code technicien
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
        private void AjouterAchat_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            chargercomboboxarticle();
            chargercomboboxfernisseur();
        }
        //boutton ajouter
        private void button5_Click(object sender, EventArgs e)
        {
            if (reference.Text == " " || article.Text == " " || article.Text == "" || marque.Text == " " || fernisseur.Text == " " || quantite.Text == " " || prixunit.Text == "")
            {
                MessageBox.Show("entez les information de tous les champs!!");

            }
            else
            {
                if (TechnicienExist(reference.Text) == 0)
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter cette  Achat car tu ne peux pas le modifier?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Achat values(@reference,@date_Achat,@code_barre,@article,@marque,@code_technicien,@prixunitare,@quantite,@num_bin_livrision,@num_facture,@montant,@observation)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = reference.Text;
                        requete.Parameters.AddWithValue("@date_Achat", SqlDbType.Date).Value = date.Value;
                        requete.Parameters.AddWithValue("@code_barre", SqlDbType.VarChar).Value = code_barre.Text;
                        requete.Parameters.AddWithValue("@article", SqlDbType.VarChar).Value = article.Text;
                        requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = marque.Text;
                        requete.Parameters.AddWithValue("@code_technicien", SqlDbType.VarChar).Value = fernisseur.Text;
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
                        requete.Parameters.AddWithValue("@num_bin_livrision ", SqlDbType.Int).Value = nbv.Text;
                        requete.Parameters.AddWithValue("@num_facture ", SqlDbType.Int).Value = numfac.Text;
                        requete.Parameters.AddWithValue("@montant ", SqlDbType.Int).Value = label13.Text;
                        requete.Parameters.AddWithValue("@observation", SqlDbType.VarChar).Value = observation.Text;

                        try
                        {
                            int x = requete.ExecuteNonQuery();
                            if (x == 0)
                                MessageBox.Show("vous n'avez pas fait l'ajout du  Achat!!");
                            else
                            {
                                MessageBox.Show("vous avez  faire fait l'ajout du Achat son reference: " + reference.Text);
                               
                                remplissage();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur  d'ajouter cet Achat ,vérifier tous les champs!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La reference pour cette  Achat  est déjà utiliser !!");
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
        //actualiser liste derelonte de la marque
        private void article_SelectedValueChanged(object sender, EventArgs e)
        {
            marque.Items.Clear();
        }
        //aficher mon et prenom apres selectionner technicien
        private void fernisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select Nom_fer,Prénom_fer from Founisseur where code_fer=@fernisseur ", maconnexion);
            requete.Parameters.AddWithValue("@fernisseur", SqlDbType.VarChar).Value = fernisseur.Text;
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
        //new
        private void button6_Click(object sender, EventArgs e)
        {
            effacer();
        }
        //quitter veres gestion achat
        private void button4_Click(object sender, EventArgs e)
        {
            Achat ach = new Achat();
            ach.Show();
            this.Hide();
        }
        //aficher libelle apres selectionner code_barre
        private void code_barre_SelectedIndexChanged(object sender, EventArgs e)
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
        //actualiser  liste box de article(libelle)
        private void code_barre_SelectedValueChanged(object sender, EventArgs e)
        {
            article.Items.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
