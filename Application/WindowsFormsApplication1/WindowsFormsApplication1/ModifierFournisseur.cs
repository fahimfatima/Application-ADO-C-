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
    public partial class ModifierFournisseur : Form
    {
        public ModifierFournisseur()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            Code.Text = " ";
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
        //charger combobox pour code
        void chargercomboboxcode()
        {
            requete = new SqlCommand("select code_fer from Founisseur", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    Code.Items.Add(DR.GetString(i));
                }
            }
            DR.Close();

        }
        //activer le connection
        private void ModifierFournisseur_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            chargercomboboxcode();
        }
       
        //modifier fournisseur
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("voulez vous vraiment modifier cet Founisseur?", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                requete.Connection = maconnexion;
                requete.CommandText = "update Founisseur set Nom_fer=@nom,Prénom_fer=@prenom,Civillite=@civilite,Telephone=@tele,Adresse=@email where code_fer=@Code";
                requete.Parameters.Clear();
                requete.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = Code.Text;
                requete.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = nom.Text;
                requete.Parameters.AddWithValue("@prenom", SqlDbType.VarChar).Value = prenom.Text;
                string civilite = "";
                if (radioButton1.Checked)
                    civilite = "Monsieur";
                if (radioButton2.Checked)
                    civilite = "Madame";
                requete.Parameters.AddWithValue("@civilite", SqlDbType.VarChar).Value = civilite;
                requete.Parameters.AddWithValue("@tele", SqlDbType.VarChar).Value = tele.Text;
                requete.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email.Text;
                try
                {
                    int x = requete.ExecuteNonQuery();
                    if (x == 0)
                        MessageBox.Show("Aucune Modification !");
                    else
                    {
                        MessageBox.Show("Modification de Founisseur " + Code.Text + " Bien Fait !");

                        remplissage();
                    }
                }
                catch
               {

                   MessageBox.Show("Erreur  de Modification cet Founisseur ,vérifier tous les champs!!");
               }
                
            }
            else
            {
                MessageBox.Show("vous avez anuller la modification !");
            }
        }
        //boutton new
        private void button3_Click(object sender, EventArgs e)
        {
            this.effacer();
        }
        //boutton quitter
        private void button4_Click(object sender, EventArgs e)
        {
            Fournisseur fr = new Fournisseur();
            fr.Show();
            this.Hide();
        }
        //selectionner code et affciher les info dans les text box
        private void Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete.CommandText = "select * from Founisseur ";
            requete.Connection = maconnexion;
            IDataReader dr = requete.ExecuteReader();
            while (dr.Read())
            {
                nom.Text = dr.GetValue(1).ToString();
                prenom.Text = dr.GetValue(2).ToString();
                string a = dr.GetValue(3).ToString();
                if (a == "Monsieur")
                { radioButton1.Checked = true; }
                if (a == "Madame")
                { radioButton2.Checked = true; }
                tele.Text = dr.GetValue(4).ToString();
                email.Text = dr.GetValue(5).ToString();

            }
            dr.Close();
        }
        
    }
}
