namespace WindowsFormsApplication1
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modélToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCatégorieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionStokToolStripMenuItem,
            this.gestionVenteToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.gestionCatégorieToolStripMenuItem,
            this.gestionCatégorieToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionStokToolStripMenuItem
            // 
            this.gestionStokToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionStokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.gestionStokToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionStokToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.gestionStokToolStripMenuItem.Name = "gestionStokToolStripMenuItem";
            this.gestionStokToolStripMenuItem.Size = new System.Drawing.Size(172, 31);
            this.gestionStokToolStripMenuItem.Text = "Gestion Stock";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.Color.DarkBlue;
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // gestionVenteToolStripMenuItem
            // 
            this.gestionVenteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionVenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.technicienToolStripMenuItem,
            this.commandeToolStripMenuItem});
            this.gestionVenteToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionVenteToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.gestionVenteToolStripMenuItem.Name = "gestionVenteToolStripMenuItem";
            this.gestionVenteToolStripMenuItem.Size = new System.Drawing.Size(172, 31);
            this.gestionVenteToolStripMenuItem.Text = "Gestion Vente";
            // 
            // technicienToolStripMenuItem
            // 
            this.technicienToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.technicienToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicienToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.technicienToolStripMenuItem.Name = "technicienToolStripMenuItem";
            this.technicienToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.technicienToolStripMenuItem.Text = "Technicien";
            this.technicienToolStripMenuItem.Click += new System.EventHandler(this.technicienToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.commandeToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fournisseurToolStripMenuItem,
            this.achatToolStripMenuItem});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(173, 31);
            this.gestionToolStripMenuItem.Text = "Gestion Achat";
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.fournisseurToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournisseurToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // achatToolStripMenuItem
            // 
            this.achatToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.achatToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achatToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.achatToolStripMenuItem.Name = "achatToolStripMenuItem";
            this.achatToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.achatToolStripMenuItem.Text = "Achat";
            this.achatToolStripMenuItem.Click += new System.EventHandler(this.achatToolStripMenuItem_Click);
            // 
            // gestionCatégorieToolStripMenuItem
            // 
            this.gestionCatégorieToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionCatégorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modélToolStripMenuItem});
            this.gestionCatégorieToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionCatégorieToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.gestionCatégorieToolStripMenuItem.Name = "gestionCatégorieToolStripMenuItem";
            this.gestionCatégorieToolStripMenuItem.Size = new System.Drawing.Size(189, 31);
            this.gestionCatégorieToolStripMenuItem.Text = "Gestion Marque";
            // 
            // modélToolStripMenuItem
            // 
            this.modélToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.modélToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modélToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.modélToolStripMenuItem.Name = "modélToolStripMenuItem";
            this.modélToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.modélToolStripMenuItem.Text = "Marque";
            this.modélToolStripMenuItem.Click += new System.EventHandler(this.modélToolStripMenuItem_Click);
            // 
            // gestionCatégorieToolStripMenuItem1
            // 
            this.gestionCatégorieToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.gestionCatégorieToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégorieToolStripMenuItem});
            this.gestionCatégorieToolStripMenuItem1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionCatégorieToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.gestionCatégorieToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.DarkGray;
            this.gestionCatégorieToolStripMenuItem1.Name = "gestionCatégorieToolStripMenuItem1";
            this.gestionCatégorieToolStripMenuItem1.Size = new System.Drawing.Size(213, 31);
            this.gestionCatégorieToolStripMenuItem1.Text = "Gestion Catégorie";
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.catégorieToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catégorieToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.catégorieToolStripMenuItem.Text = "Catégorie";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.catégorieToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(829, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(123, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion D\'inventaire \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(370, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 71);
            this.label2.TabIndex = 3;
            this.label2.Text = "   Stock\r\n";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Suivi_des_stocks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 397);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Menu Général";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modélToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCatégorieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}