namespace WindowsFormsApplication1
{
    partial class AjouterAchat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prixunit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.observation = new System.Windows.Forms.TextBox();
            this.quantite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.marque = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fernisseur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.code_barre = new System.Windows.Forms.ComboBox();
            this.code = new System.Windows.Forms.Label();
            this.numfac = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nbv = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(899, 134);
            this.dataGridView1.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(772, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 38);
            this.button4.TabIndex = 41;
            this.button4.Text = "Quitter ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(526, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 38);
            this.button5.TabIndex = 39;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(351, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ajouter Une Achat";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.ForeColor = System.Drawing.Color.Black;
            this.prix.Location = new System.Drawing.Point(93, 10);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(31, 13);
            this.prix.TabIndex = 24;
            this.prix.Text = "TTC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Prix TTC :";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 30);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // prixunit
            // 
            this.prixunit.FormattingEnabled = true;
            this.prixunit.Location = new System.Drawing.Point(214, 191);
            this.prixunit.Name = "prixunit";
            this.prixunit.Size = new System.Drawing.Size(121, 21);
            this.prixunit.TabIndex = 26;
            this.prixunit.SelectedIndexChanged += new System.EventHandler(this.prixunit_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Prix Unitaire ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prix);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(346, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 28);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(60, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(120, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Prénom";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(346, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 28);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(647, 442);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 38);
            this.button6.TabIndex = 40;
            this.button6.Text = "Nouveau";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(154, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(558, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 43);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Montant Achat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observation Achat";
            // 
            // observation
            // 
            this.observation.Location = new System.Drawing.Point(214, 362);
            this.observation.Name = "observation";
            this.observation.Size = new System.Drawing.Size(284, 20);
            this.observation.TabIndex = 12;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(214, 260);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(100, 20);
            this.quantite.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantité";
            // 
            // marque
            // 
            this.marque.FormattingEnabled = true;
            this.marque.Location = new System.Drawing.Point(214, 157);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(125, 21);
            this.marque.TabIndex = 9;
            this.marque.SelectedIndexChanged += new System.EventHandler(this.marque_SelectedIndexChanged);
            this.marque.SelectedValueChanged += new System.EventHandler(this.marque_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marque ";
            // 
            // fernisseur
            // 
            this.fernisseur.FormattingEnabled = true;
            this.fernisseur.Location = new System.Drawing.Point(214, 222);
            this.fernisseur.Name = "fernisseur";
            this.fernisseur.Size = new System.Drawing.Size(125, 21);
            this.fernisseur.TabIndex = 7;
            this.fernisseur.SelectedIndexChanged += new System.EventHandler(this.fernisseur_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code Fournisseur";
            // 
            // article
            // 
            this.article.FormattingEnabled = true;
            this.article.Location = new System.Drawing.Point(214, 122);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(125, 21);
            this.article.TabIndex = 5;
            this.article.SelectedIndexChanged += new System.EventHandler(this.article_SelectedIndexChanged);
            this.article.SelectedValueChanged += new System.EventHandler(this.article_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Atricle ";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(214, 59);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(176, 20);
            this.date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Achat";
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(214, 19);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(176, 20);
            this.reference.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.code_barre);
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Controls.Add(this.numfac);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nbv);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.prixunit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.observation);
            this.groupBox1.Controls.Add(this.quantite);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.marque);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fernisseur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.article);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reference);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(107, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 395);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // code_barre
            // 
            this.code_barre.FormattingEnabled = true;
            this.code_barre.Location = new System.Drawing.Point(214, 92);
            this.code_barre.Name = "code_barre";
            this.code_barre.Size = new System.Drawing.Size(125, 21);
            this.code_barre.TabIndex = 34;
            this.code_barre.SelectedIndexChanged += new System.EventHandler(this.code_barre_SelectedIndexChanged);
            this.code_barre.SelectedValueChanged += new System.EventHandler(this.code_barre_SelectedValueChanged);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.Black;
            this.code.Location = new System.Drawing.Point(6, 95);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(150, 18);
            this.code.TabIndex = 33;
            this.code.Text = "Code_Barre Article";
            // 
            // numfac
            // 
            this.numfac.Location = new System.Drawing.Point(214, 295);
            this.numfac.Name = "numfac";
            this.numfac.Size = new System.Drawing.Size(155, 20);
            this.numfac.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 18);
            this.label17.TabIndex = 31;
            this.label17.Text = "Num Bon Livrision";
            // 
            // nbv
            // 
            this.nbv.Location = new System.Drawing.Point(214, 329);
            this.nbv.Name = "nbv";
            this.nbv.Size = new System.Drawing.Size(155, 20);
            this.nbv.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "Num Facture";
            // 
            // AjouterAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 623);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterAchat";
            this.Text = "AjouterAchat";
            this.Load += new System.EventHandler(this.AjouterAchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox prixunit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox observation;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox marque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fernisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox article;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numfac;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nbv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox code_barre;
        private System.Windows.Forms.Label code;
    }
}