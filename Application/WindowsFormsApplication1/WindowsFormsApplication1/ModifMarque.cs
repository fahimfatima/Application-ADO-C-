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
    public partial class ModifMarque : Form
    {
        public ModifMarque()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //methode effacer
        void effacer()
        {
            marque.Clear();
            model.Clear();
            label4.Text="";
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
        //activer la connection 
        private void ModifMarque_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            
        }
        //BOUTON MODIFIER
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("voulez vous vraiment modifier cette reference?", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                requete.Connection = maconnexion;
                requete.CommandText = "update Marque set marque=@Marque,model=@Model where reference=@reference";
                requete.Parameters.Clear();
                requete.Parameters.AddWithValue("@reference", SqlDbType.VarChar).Value = label4.Text;
                requete.Parameters.AddWithValue("@Marque", SqlDbType.VarChar).Value = marque.Text;
                requete.Parameters.AddWithValue("@Model", SqlDbType.VarChar).Value = model.Text;
                int x = requete.ExecuteNonQuery();
                if (x == 0)
                    MessageBox.Show("Aucune Modification !");
                else
                {
                    MessageBox.Show("Modification de  cette refecence Bien Fait !");
                    
                    remplissage();
                }
            }
            else
            {
                MessageBox.Show("vous avez anuller la modification !");
            }
        }
        //selectionner ligne dans le tableau et afficher dans les texts boxs 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label4.Text = row.Cells[0].Value.ToString();
                marque.Text = row.Cells[1].Value.ToString();
                model.Text = row.Cells[2].Value.ToString(); 
            }
        }

        private void reference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //quitter veres interface gestion marque 
        private void button4_Click(object sender, EventArgs e)
        {
            gestionmarque gm = new gestionmarque();
            gm.Show();
            this.Hide();

        }


    }
}
