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
    public partial class ModifierGategorie : Form
    {
        public ModifierGategorie()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
           code_Catégorie.Text = "";
           cat.Text="";
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
        //activer la connection 
        private void ModifierGategorie_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            
        }
        //boutton new
        private void button3_Click(object sender, EventArgs e)
        {
            effacer();
        }
        //boutton mofidier
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("voulez vous vraiment modifier cette Catégorie?", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                requete.Connection = maconnexion;
                requete.CommandText = "update Catégorie set nom_Catégorie=@cat where code_Catégorie=@code_Catégorie";
                requete.Parameters.Clear();
                requete.Parameters.AddWithValue("@code_Catégorie", SqlDbType.VarChar).Value =code_Catégorie.Text;
                requete.Parameters.AddWithValue("@cat", SqlDbType.VarChar).Value = cat.Text;
                int x = requete.ExecuteNonQuery();
                if (x == 0)
                    MessageBox.Show("Aucune Modification !");
                else
                {
                    MessageBox.Show("Modification de  cette Catégorie Bien Fait !");
                    
                    remplissage();
                }
            }
            else
            {
                MessageBox.Show("vous avez anuller la modification !");
            }
        }
       
        //boutton categorie
        private void button4_Click(object sender, EventArgs e)
        {
            Gategorie g = new Gategorie();
            g.Show();
            this.Hide();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
        //selectionner une ligne dans le tablaue et afficher dans les texts boxs
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                code_Catégorie.Text = row.Cells[0].Value.ToString();
                cat.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
