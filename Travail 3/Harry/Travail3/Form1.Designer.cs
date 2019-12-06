namespace Travail3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Joueur1 = new System.Windows.Forms.Label();
            this.lbl_Joueur2 = new System.Windows.Forms.Label();
            this.lbl_Joueur3 = new System.Windows.Forms.Label();
            this.lbl_Joueur4 = new System.Windows.Forms.Label();
            this.txt_RechercheJoueur = new System.Windows.Forms.TextBox();
            this.btn_RechercheJoueur = new System.Windows.Forms.Button();
            this.btn_JouerCarte = new System.Windows.Forms.Button();
            this.lbl_NomCarte = new System.Windows.Forms.Label();
            this.lbl_CategorieCarte = new System.Windows.Forms.Label();
            this.lbl_TypeCarte = new System.Windows.Forms.Label();
            this.lbl_AttaqueCarte = new System.Windows.Forms.Label();
            this.lbl_DefenseCarte = new System.Windows.Forms.Label();
            this.GrpBoxCarte = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Joueur1 = new System.Windows.Forms.Button();
            this.btn_Joueur2 = new System.Windows.Forms.Button();
            this.btn_Joueur3 = new System.Windows.Forms.Button();
            this.btn_Joueur4 = new System.Windows.Forms.Button();
            this.GrpBoxCarte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Joueur1
            // 
            this.lbl_Joueur1.AutoSize = true;
            this.lbl_Joueur1.Location = new System.Drawing.Point(659, 538);
            this.lbl_Joueur1.Name = "lbl_Joueur1";
            this.lbl_Joueur1.Size = new System.Drawing.Size(13, 13);
            this.lbl_Joueur1.TabIndex = 2;
            this.lbl_Joueur1.Text = "1";
            // 
            // lbl_Joueur2
            // 
            this.lbl_Joueur2.AutoSize = true;
            this.lbl_Joueur2.Location = new System.Drawing.Point(405, 340);
            this.lbl_Joueur2.Name = "lbl_Joueur2";
            this.lbl_Joueur2.Size = new System.Drawing.Size(13, 13);
            this.lbl_Joueur2.TabIndex = 3;
            this.lbl_Joueur2.Text = "2";
            // 
            // lbl_Joueur3
            // 
            this.lbl_Joueur3.AutoSize = true;
            this.lbl_Joueur3.Location = new System.Drawing.Point(679, 242);
            this.lbl_Joueur3.Name = "lbl_Joueur3";
            this.lbl_Joueur3.Size = new System.Drawing.Size(13, 13);
            this.lbl_Joueur3.TabIndex = 4;
            this.lbl_Joueur3.Text = "3";
            // 
            // lbl_Joueur4
            // 
            this.lbl_Joueur4.AutoSize = true;
            this.lbl_Joueur4.Location = new System.Drawing.Point(971, 340);
            this.lbl_Joueur4.Name = "lbl_Joueur4";
            this.lbl_Joueur4.Size = new System.Drawing.Size(13, 13);
            this.lbl_Joueur4.TabIndex = 5;
            this.lbl_Joueur4.Text = "4";
            // 
            // txt_RechercheJoueur
            // 
            this.txt_RechercheJoueur.Location = new System.Drawing.Point(41, 30);
            this.txt_RechercheJoueur.Name = "txt_RechercheJoueur";
            this.txt_RechercheJoueur.Size = new System.Drawing.Size(100, 20);
            this.txt_RechercheJoueur.TabIndex = 6;
            // 
            // btn_RechercheJoueur
            // 
            this.btn_RechercheJoueur.Location = new System.Drawing.Point(156, 28);
            this.btn_RechercheJoueur.Name = "btn_RechercheJoueur";
            this.btn_RechercheJoueur.Size = new System.Drawing.Size(108, 23);
            this.btn_RechercheJoueur.TabIndex = 7;
            this.btn_RechercheJoueur.Text = "Ajouter joueur";
            this.btn_RechercheJoueur.UseVisualStyleBackColor = true;
            this.btn_RechercheJoueur.Click += new System.EventHandler(this.Btn_RechercheJoueur_Click);
            // 
            // btn_JouerCarte
            // 
            this.btn_JouerCarte.Enabled = false;
            this.btn_JouerCarte.Location = new System.Drawing.Point(41, 408);
            this.btn_JouerCarte.Name = "btn_JouerCarte";
            this.btn_JouerCarte.Size = new System.Drawing.Size(108, 23);
            this.btn_JouerCarte.TabIndex = 8;
            this.btn_JouerCarte.Text = "Jouer";
            this.btn_JouerCarte.UseVisualStyleBackColor = true;
            this.btn_JouerCarte.Click += new System.EventHandler(this.Btn_JouerCarte_Click);
            // 
            // lbl_NomCarte
            // 
            this.lbl_NomCarte.AutoSize = true;
            this.lbl_NomCarte.Location = new System.Drawing.Point(15, 28);
            this.lbl_NomCarte.Name = "lbl_NomCarte";
            this.lbl_NomCarte.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomCarte.TabIndex = 9;
            this.lbl_NomCarte.Text = "Nom: ";
            // 
            // lbl_CategorieCarte
            // 
            this.lbl_CategorieCarte.AutoSize = true;
            this.lbl_CategorieCarte.Location = new System.Drawing.Point(16, 54);
            this.lbl_CategorieCarte.Name = "lbl_CategorieCarte";
            this.lbl_CategorieCarte.Size = new System.Drawing.Size(55, 13);
            this.lbl_CategorieCarte.TabIndex = 10;
            this.lbl_CategorieCarte.Text = "Categorie:";
            // 
            // lbl_TypeCarte
            // 
            this.lbl_TypeCarte.AutoSize = true;
            this.lbl_TypeCarte.Location = new System.Drawing.Point(16, 85);
            this.lbl_TypeCarte.Name = "lbl_TypeCarte";
            this.lbl_TypeCarte.Size = new System.Drawing.Size(34, 13);
            this.lbl_TypeCarte.TabIndex = 10;
            this.lbl_TypeCarte.Text = "Type:";
            // 
            // lbl_AttaqueCarte
            // 
            this.lbl_AttaqueCarte.AutoSize = true;
            this.lbl_AttaqueCarte.Location = new System.Drawing.Point(15, 115);
            this.lbl_AttaqueCarte.Name = "lbl_AttaqueCarte";
            this.lbl_AttaqueCarte.Size = new System.Drawing.Size(86, 13);
            this.lbl_AttaqueCarte.TabIndex = 10;
            this.lbl_AttaqueCarte.Text = "Points d\'attaque:";
            // 
            // lbl_DefenseCarte
            // 
            this.lbl_DefenseCarte.AutoSize = true;
            this.lbl_DefenseCarte.Location = new System.Drawing.Point(15, 142);
            this.lbl_DefenseCarte.Name = "lbl_DefenseCarte";
            this.lbl_DefenseCarte.Size = new System.Drawing.Size(98, 13);
            this.lbl_DefenseCarte.TabIndex = 10;
            this.lbl_DefenseCarte.Text = "Points de défense: ";
            // 
            // GrpBoxCarte
            // 
            this.GrpBoxCarte.Controls.Add(this.lbl_NomCarte);
            this.GrpBoxCarte.Controls.Add(this.lbl_DefenseCarte);
            this.GrpBoxCarte.Controls.Add(this.lbl_CategorieCarte);
            this.GrpBoxCarte.Controls.Add(this.lbl_AttaqueCarte);
            this.GrpBoxCarte.Controls.Add(this.lbl_TypeCarte);
            this.GrpBoxCarte.Location = new System.Drawing.Point(1276, 292);
            this.GrpBoxCarte.Name = "GrpBoxCarte";
            this.GrpBoxCarte.Size = new System.Drawing.Size(221, 277);
            this.GrpBoxCarte.TabIndex = 11;
            this.GrpBoxCarte.TabStop = false;
            this.GrpBoxCarte.Text = "Carte à jouer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(379, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(197, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(715, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1023, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btn_Joueur1
            // 
            this.btn_Joueur1.Location = new System.Drawing.Point(323, 397);
            this.btn_Joueur1.Name = "btn_Joueur1";
            this.btn_Joueur1.Size = new System.Drawing.Size(75, 23);
            this.btn_Joueur1.TabIndex = 14;
            this.btn_Joueur1.Text = "button1";
            this.btn_Joueur1.UseVisualStyleBackColor = true;
            // 
            // btn_Joueur2
            // 
            this.btn_Joueur2.Location = new System.Drawing.Point(323, 434);
            this.btn_Joueur2.Name = "btn_Joueur2";
            this.btn_Joueur2.Size = new System.Drawing.Size(75, 23);
            this.btn_Joueur2.TabIndex = 15;
            this.btn_Joueur2.Text = "button2";
            this.btn_Joueur2.UseVisualStyleBackColor = true;
            // 
            // btn_Joueur3
            // 
            this.btn_Joueur3.Location = new System.Drawing.Point(323, 475);
            this.btn_Joueur3.Name = "btn_Joueur3";
            this.btn_Joueur3.Size = new System.Drawing.Size(75, 23);
            this.btn_Joueur3.TabIndex = 16;
            this.btn_Joueur3.Text = "button3";
            this.btn_Joueur3.UseVisualStyleBackColor = true;
            // 
            // btn_Joueur4
            // 
            this.btn_Joueur4.Location = new System.Drawing.Point(323, 515);
            this.btn_Joueur4.Name = "btn_Joueur4";
            this.btn_Joueur4.Size = new System.Drawing.Size(75, 23);
            this.btn_Joueur4.TabIndex = 17;
            this.btn_Joueur4.Text = "button4";
            this.btn_Joueur4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 764);
            this.Controls.Add(this.btn_Joueur4);
            this.Controls.Add(this.btn_Joueur3);
            this.Controls.Add(this.btn_Joueur2);
            this.Controls.Add(this.btn_Joueur1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpBoxCarte);
            this.Controls.Add(this.btn_JouerCarte);
            this.Controls.Add(this.btn_RechercheJoueur);
            this.Controls.Add(this.txt_RechercheJoueur);
            this.Controls.Add(this.lbl_Joueur4);
            this.Controls.Add(this.lbl_Joueur3);
            this.Controls.Add(this.lbl_Joueur2);
            this.Controls.Add(this.lbl_Joueur1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxCarte.ResumeLayout(false);
            this.GrpBoxCarte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Joueur1;
        private System.Windows.Forms.Label lbl_Joueur2;
        private System.Windows.Forms.Label lbl_Joueur3;
        private System.Windows.Forms.Label lbl_Joueur4;
        private System.Windows.Forms.TextBox txt_RechercheJoueur;
        private System.Windows.Forms.Button btn_RechercheJoueur;
        private System.Windows.Forms.Button btn_JouerCarte;
        private System.Windows.Forms.Label lbl_NomCarte;
        private System.Windows.Forms.Label lbl_CategorieCarte;
        private System.Windows.Forms.Label lbl_TypeCarte;
        private System.Windows.Forms.Label lbl_AttaqueCarte;
        private System.Windows.Forms.Label lbl_DefenseCarte;
        private System.Windows.Forms.GroupBox GrpBoxCarte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Joueur1;
        private System.Windows.Forms.Button btn_Joueur2;
        private System.Windows.Forms.Button btn_Joueur3;
        private System.Windows.Forms.Button btn_Joueur4;
    }
}

