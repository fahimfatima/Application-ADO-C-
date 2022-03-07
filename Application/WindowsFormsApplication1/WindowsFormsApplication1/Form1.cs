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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Afficher le mot de passe 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mot_passe.UseSystemPasswordChar = false;
            }
            else
            {
                mot_passe.UseSystemPasswordChar = true;
            }
        }
        //aller veres l'interface incription
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            inscrire f = new inscrire();
            f.Show();
            this.Hide();
        }
        //quitter l'application
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //bouton ce connecter
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection maconnexion = new SqlConnection(@"Data Source=DESKTOP-CSV5KO0\SQLEXPRESS;Initial Catalog=PROJET_INVONTAIRE_LP;Integrated Security=True");
                SqlCommand sc = new SqlCommand("select * from Compte where email =@email and mot_passe =@mot_passe", maconnexion);
                maconnexion.Open();
                sc.Parameters.AddWithValue("@email", email.Text);
                sc.Parameters.AddWithValue("@mot_passe", mot_passe.Text);
                SqlDataReader qdr = sc.ExecuteReader();
                if (qdr.HasRows == true)
                {
                    menu m = new menu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    label4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            email.Clear();
            mot_passe.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
