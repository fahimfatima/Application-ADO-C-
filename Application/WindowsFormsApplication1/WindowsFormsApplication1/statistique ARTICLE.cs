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
    public partial class statistique_ARTICLE : Form
    {
        public statistique_ARTICLE()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //charger combobox pour lible
        void chargercomboboxliblle()
        {
            requete = new SqlCommand("select DISTINCT libelle from Article", maconnexion);
            IDataReader DR = requete.ExecuteReader();
            while (DR.Read())
            {

                for (int i = 0; i < DR.FieldCount; i++)
                {
                    libelle.Items.Add(DR.GetString(i));
                }
                
            }
            DR.Close();
            marque.Items.Clear(); 
            
        }
       //activer la connection 
        private void statistique_ARTICLE_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            
            chargercomboboxliblle();
             
            
        }
        //apres la selection libelle automatiquement  charger les marques de ce article
        private void libelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = new SqlCommand("select DISTINCT marque from Article where libelle=@libelle ", maconnexion);
            requete.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = libelle.Text;
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
        //apres la selection marque automatiquement  afficher la quantite de ce article
        private void marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete.CommandText = "select COUNT(marque) from Article where marque=@marque and libelle=@libelle";
            requete.Parameters.Clear();
            requete.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = marque.Text;
            requete.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = libelle.Text;
            SqlDataReader dr = requete.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0].ToString();
            }
            dr.Close();
            
                       
        }

        private void marque_Click(object sender, EventArgs e)
        {
           
        }

        private void marque_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void libelle_SelectedValueChanged(object sender, EventArgs e)
        {
            marque.Items.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //boutton quitter
        private void button4_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }
    }
}
