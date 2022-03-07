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
    public partial class inscrire : Form
    {
        public inscrire()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode existe
        int CompteExist(string x)
        {
            requete.Connection = maconnexion;
            requete.CommandText = "select count(*) from Compte where email=@email";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = x;
            int N = (int)requete.ExecuteScalar();
            return N;
        }
        //activer la connection
        private void inscrire_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //quitter veres se connecter
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        //methode effacer
        void effacer()
        {
            nom.Clear();
            prenom.Clear();
            email.Clear();
            motpasse.Clear();
            conpass.Clear();
            dateTimePicker1.Value = DateTime.Today;


        }
        //bouuton inscrire
        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == " " || prenom.Text == " " || email.Text == "" || motpasse.Text == "" || conpass.Text == " ")
            {
                MessageBox.Show("entez les information de tous les champs apres l'inscription!!");
            }
            else
            {
                if (CompteExist(email.Text) == 0)
                {
                    DialogResult dr = MessageBox.Show("voulez vous vraiment s'inscrire?", "confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        requete.Connection = maconnexion;
                        requete.CommandText = "insert into Compte values(@nom,@prenom,@email,@mot_passe,@confirmer_passe,@date_creation)";
                        requete.Parameters.Clear();
                        requete.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = nom.Text;
                        requete.Parameters.AddWithValue("@prenom", SqlDbType.VarChar).Value = prenom.Text;
                        requete.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email.Text;
                        requete.Parameters.AddWithValue("@mot_passe", SqlDbType.VarChar).Value = motpasse.Text;
                        try
                        {
                            if (conpass.Text != motpasse.Text)
                            {
                                MessageBox.Show("Confirmer  le mot de passe doit être la  même valeur de Mot de passe!! ");
                            }
                            else
                            {
                                requete.Parameters.AddWithValue("@confirmer_passe", SqlDbType.VarChar).Value = conpass.Text;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur!!");
                        }
                        requete.Parameters.AddWithValue("@date_creation", SqlDbType.Date).Value = dateTimePicker1.Value;
                        try
                        {
                            int x = requete.ExecuteNonQuery();
                            if (x == 0)
                                 MessageBox.Show("vous n'avez pas fait l'inscription!!");
                            else
                            {
                                MessageBox.Show("vous avez  faire fait l'inscription ");
                            this.effacer();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur!!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Cet email  est déjà utiliser !!");
                }
            }
        }
        //afficher le mot de passe
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                conpass.UseSystemPasswordChar = false;
            }
            else
            {
                conpass.UseSystemPasswordChar = true;
            }
        }
        //afficher le mot de passe
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                motpasse.UseSystemPasswordChar = false;
            }
            else
            {
                motpasse.UseSystemPasswordChar = true;
            }
        }
    }

}
