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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Joueur1 = new System.Windows.Forms.Label();
            this.lbl_Joueur2 = new System.Windows.Forms.Label();
            this.lbl_Joueur3 = new System.Windows.Forms.Label();
            this.lbl_Joueur4 = new System.Windows.Forms.Label();
            this.txt_RechercheJoueur = new System.Windows.Forms.TextBox();
            this.btn_RechercheJoueur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1035, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 181);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(635, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 130);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1043, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 181);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1350, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 130);
            this.panel4.TabIndex = 1;
            // 
            // lbl_Joueur1
            // 
            this.lbl_Joueur1.AutoSize = true;
            this.lbl_Joueur1.Location = new System.Drawing.Point(1035, 439);
            this.lbl_Joueur1.Name = "lbl_Joueur1";
            this.lbl_Joueur1.Size = new System.Drawing.Size(45, 13);
            this.lbl_Joueur1.TabIndex = 2;
            this.lbl_Joueur1.Text = "Joueur1";
            // 
            // lbl_Joueur2
            // 
            this.lbl_Joueur2.AutoSize = true;
            this.lbl_Joueur2.Location = new System.Drawing.Point(781, 241);
            this.lbl_Joueur2.Name = "lbl_Joueur2";
            this.lbl_Joueur2.Size = new System.Drawing.Size(45, 13);
            this.lbl_Joueur2.TabIndex = 3;
            this.lbl_Joueur2.Text = "Joueur2";
            // 
            // lbl_Joueur3
            // 
            this.lbl_Joueur3.AutoSize = true;
            this.lbl_Joueur3.Location = new System.Drawing.Point(1040, 208);
            this.lbl_Joueur3.Name = "lbl_Joueur3";
            this.lbl_Joueur3.Size = new System.Drawing.Size(45, 13);
            this.lbl_Joueur3.TabIndex = 4;
            this.lbl_Joueur3.Text = "Joueur3";
            // 
            // lbl_Joueur4
            // 
            this.lbl_Joueur4.AutoSize = true;
            this.lbl_Joueur4.Location = new System.Drawing.Point(1347, 241);
            this.lbl_Joueur4.Name = "lbl_Joueur4";
            this.lbl_Joueur4.Size = new System.Drawing.Size(51, 13);
            this.lbl_Joueur4.TabIndex = 5;
            this.lbl_Joueur4.Text = "Joueuer4";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 764);
            this.Controls.Add(this.btn_RechercheJoueur);
            this.Controls.Add(this.txt_RechercheJoueur);
            this.Controls.Add(this.lbl_Joueur4);
            this.Controls.Add(this.lbl_Joueur3);
            this.Controls.Add(this.lbl_Joueur2);
            this.Controls.Add(this.lbl_Joueur1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Joueur1;
        private System.Windows.Forms.Label lbl_Joueur2;
        private System.Windows.Forms.Label lbl_Joueur3;
        private System.Windows.Forms.Label lbl_Joueur4;
        private System.Windows.Forms.TextBox txt_RechercheJoueur;
        private System.Windows.Forms.Button btn_RechercheJoueur;
    }
}

