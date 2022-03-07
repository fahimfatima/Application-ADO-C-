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
    public partial class AjouterFournisseur : Form
    {
        public AjouterFournisseur()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            Code.Clear();
            nom.Clear();
            prenom.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tele.Clear();
            email.Clear();
        }
        //remplissage date grid
        void remplissage()
        {

            requete.CommandText = "select *from Founisseur";
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
            requete.CommandText = "select count(*) from Founisseur where code_fer=@Code";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;

        }
        //activer le connection
        private void AjouterFournisseur_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
        }
        //boutton ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            if (Code.Text == " " || nom.Text == " " || prenom.Text == "" || tele.Text == " " || email.Text == " ")
            {
                MessageBox.Show("entez les information de tous les champs!!");
            }
            else
            {
                if (TechnicienExist(Code.Text) != 0)
                {
                   
                        MessageBox.Show("Le Fournisseur  est déjà utiliser !!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter un fournisseur?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Founisseur values(@code_fer,@Nom_fer,@Prénom_fer,@Civillite,@Telephone,@Adresse)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@code_fer", SqlDbType.VarChar).Value = Code.Text;
                        requete.Parameters.AddWithValue("@Nom_fer", SqlDbType.VarChar).Value = nom.Text;
                        requete.Parameters.AddWithValue("@Prénom_fer", SqlDbType.VarChar).Value = prenom.Text;
                        string civilite = "";
                        if (radioButton1.Checked)
                            civilite = "Monsieur";
                        if (radioButton2.Checked)
                            civilite = "Madame";
                        requete.Parameters.AddWithValue("@Civillite", SqlDbType.VarChar).Value = civilite;
                        requete.Parameters.AddWithValue("@Telephone", SqlDbType.VarChar).Value = tele.Text;
                        requete.Parameters.AddWithValue("@Adresse", SqlDbType.VarChar).Value = email.Text;
                        try
                        {
                            int x = requete.ExecuteNonQuery();
                            if (x == 0)
                                MessageBox.Show("vous n'avez pas fait l'ajout du  Fournisseur!!");
                            else
                            {
                                MessageBox.Show("vous avez  faire fait l'ajout du Fournisseur son code: " + Code.Text);
                                remplissage();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur  d'ajouter cet Founisseur ,vérifier tous les champs!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("vous avez anuller l'ajouter !");
                    }    
                }
            }        
        }
        
        //BOUTTON QUITTER
        private void button4_Click(object sender, EventArgs e)
        {

            Fournisseur fr = new Fournisseur();
            fr.Show();
            this.Hide();
        }
        //BOUTTON NEW
        private void button3_Click(object sender, EventArgs e)
        {
            effacer();
        }

        
    }
}
