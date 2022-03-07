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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        //definire la connexion
        SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
        SqlCommand requete = new SqlCommand();
        //quitter veres le menu general
        private void button4_Click(object sender, EventArgs e)
        {

            menu m = new menu();
            m.Show();
            this.Hide();
            
        }
        //aller veres l'ajouter article
        private void button1_Click(object sender, EventArgs e)
        {
            Article ar = new Article();
            ar.Show();
            this.Hide();
        }
        //aller veres modifier article
        private void button2_Click(object sender, EventArgs e)
        {
            ArticleModifier ARM = new ArticleModifier();
            ARM.Show();
            this.Hide();
        }
        //remplissage data grid les articles achat sortie 
        void remplissage()
        {

            requete.CommandText = "select  SUM( Achat.quantite) as'quantite achater',Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie  from  Article inner join Achat on Article.code_barre=Achat.code_barre group by Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView1.DataSource = DT;
        }
        //remplissage data grid les articles commander entree
        void remplissage1()
        {

            requete.CommandText = "select   SUM( Commande.quantite) as'quantite commander',Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie from  Article inner join Commande on Article.code_barre=Commande.code_barre group by Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView3.DataSource = DT;
        }
        //remplissage date grid
        void remplissage2()
        {

            requete.CommandText = "select Article.*  from Article ";
            requete.Connection = maconnexion;
            IDataReader DR = requete.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridView2.DataSource = DT;
        }
        //activer le connection
        private void Stock_Load(object sender, EventArgs e)
        {
            if (maconnexion.State != ConnectionState.Open)
            {
                maconnexion.Open();
            }
            remplissage();
            remplissage1();
            remplissage2();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //aller veres le statistique d'article
        private void button5_Click(object sender, EventArgs e)
        {
            statistique_ARTICLE sr = new statistique_ARTICLE();
            sr.Show();
            this.Hide();
        }

       
        
    }
}
