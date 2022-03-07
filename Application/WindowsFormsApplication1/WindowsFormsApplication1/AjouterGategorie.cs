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
    public partial class AjouterGategorie : Form
    {
        public AjouterGategorie()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            code.Clear();
            nom.Clear();
        }
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
        //methode existe
        int gatExist(string x)
        {
            requete.Connection = maconnexion;
            requete.CommandText = "select count(*) from Catégorie where code_Catégorie=@code";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@code", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;
        }
        //activer le connection
        private void AjouterGategorie_Load(object sender, EventArgs e)
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
            if (code.Text == " " || nom.Text == " ")
            {
                MessageBox.Show("entez les information de tous les champs!!");
            }
            else
            {

                if (gatExist(code.Text) != 0)
                {

                    MessageBox.Show("La Catégorie  est déjà utiliser !!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter un Catégorie?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Catégorie values(@code_Catégorie,@nom_Catégorie)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@code_Catégorie", SqlDbType.VarChar).Value = code.Text;
                        requete.Parameters.AddWithValue("@nom_Catégorie", SqlDbType.VarChar).Value = nom.Text;
                        int x = requete.ExecuteNonQuery();
                        if (x == 0)
                        { MessageBox.Show("vous n'avez pas fait l'ajout du  Catégorie!!"); }
                        else
                        {
                            MessageBox.Show("vous avez  faire fait l'ajout du Catégorie son code: " + code.Text);

                            remplissage();
                        }

                    }else{  MessageBox.Show("vous avez anuller l'ajout !");}
                }

            }
        }
        //BOUTTON QUITTER
        private void button4_Click(object sender, EventArgs e)
        {
            Gategorie g = new Gategorie();
            g.Show();
            this.Hide();
        }
        //boutton new
        private void button3_Click(object sender, EventArgs e)
        {
            effacer();
        }

       
    }
}
