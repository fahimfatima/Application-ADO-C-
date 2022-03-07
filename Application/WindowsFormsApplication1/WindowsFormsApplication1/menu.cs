using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        //quitter veres interface ce connetre
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
             
        }
        //aller au  gestion stock
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
            this.Hide();
        }
        //aller gestion technicien
        private void technicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Technicien tech = new Technicien();
            tech.Show();
            this.Hide();
        }
        //aller au gestion fournisseur
        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fournisseur f = new Fournisseur();
            f.Show();
            this.Hide();
        }
        //aller au gestion marque
        private void modélToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionmarque gm = new gestionmarque();
            gm.Show();
            this.Hide();
        }
        //aller au gestion categorie
        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gategorie g = new Gategorie();
            g.Show();
            this.Hide();
        }
        //aller au gestion commande
        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commande c = new commande();
            c.Show();
            this.Hide();
        }
        //aller gestion achat
        private void achatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Achat ach = new Achat();
            ach.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
