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
    public partial class Marque : Form
    {
        public Marque()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            textBox1.Clear();
            textBox2.Clear();
            reference.Clear();
        }
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
        //methode existe
        int marqueExist(string x)
        {
            requete.Connection = maconnexion;
            requete.CommandText = "select count(*) from Marque where reference=@reference";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;
        }
        //activer le connection
        private void Marque_Load(object sender, EventArgs e)
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

            gestionmarque m = new gestionmarque();
            m.Show();
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

            if (reference.Text == " " || textBox1.Text == " " || textBox2.Text == "")
            {
                MessageBox.Show("entez les information de tous les champs!!");
            }
            else
            {
                if (marqueExist(reference.Text) != 0)
                {
                    MessageBox.Show("Cette reference s est déjà utiliser !!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment ajouter cette reference?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Marque values(@reference,@Marque,@Model)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = reference.Text;
                        requete.Parameters.AddWithValue("@Marque", SqlDbType.VarChar).Value = textBox1.Text;
                        requete.Parameters.AddWithValue("@Model", SqlDbType.VarChar).Value = textBox2.Text;
                        int x = requete.ExecuteNonQuery();
                        if (x == 0)
                            MessageBox.Show("vous n'avez pas fait l'ajout du reference!!");
                        else
                        {
                            MessageBox.Show("vous avez  faire fait l'ajout du reference: " + reference.Text);

                            remplissage();
                        }

                    }
                    else
                    {
                        MessageBox.Show("vous avez anuller l'ajouter !");
                    }

                }
            }
        }
    }
}
