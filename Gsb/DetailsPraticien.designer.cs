namespace Gsb
{
    partial class DetailsPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsPraticien));
            this.t_nom = new System.Windows.Forms.TextBox();
            this.t_prenom = new System.Windows.Forms.TextBox();
            this.t_adresse = new System.Windows.Forms.TextBox();
            this.t_codePostal = new System.Windows.Forms.TextBox();
            this.t_ville = new System.Windows.Forms.TextBox();
            this.t_coefNotoriete = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.codepostal = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.coefnotoriete = new System.Windows.Forms.Label();
            this.typepraticien = new System.Windows.Forms.Label();
            this.c_typePraticien = new System.Windows.Forms.ComboBox();
            this.b_validModif = new System.Windows.Forms.Button();
            this.b_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_nom
            // 
            this.t_nom.Location = new System.Drawing.Point(235, 49);
            this.t_nom.Margin = new System.Windows.Forms.Padding(4);
            this.t_nom.Name = "t_nom";
            this.t_nom.Size = new System.Drawing.Size(199, 22);
            this.t_nom.TabIndex = 0;
            this.t_nom.TextChanged += new System.EventHandler(this.t_nom_TextChanged);
            // 
            // t_prenom
            // 
            this.t_prenom.Location = new System.Drawing.Point(235, 115);
            this.t_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.t_prenom.Name = "t_prenom";
            this.t_prenom.Size = new System.Drawing.Size(199, 22);
            this.t_prenom.TabIndex = 1;
            this.t_prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t_adresse
            // 
            this.t_adresse.Location = new System.Drawing.Point(235, 187);
            this.t_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.t_adresse.Name = "t_adresse";
            this.t_adresse.Size = new System.Drawing.Size(199, 22);
            this.t_adresse.TabIndex = 2;
            // 
            // t_codePostal
            // 
            this.t_codePostal.Location = new System.Drawing.Point(235, 270);
            this.t_codePostal.Margin = new System.Windows.Forms.Padding(4);
            this.t_codePostal.Name = "t_codePostal";
            this.t_codePostal.Size = new System.Drawing.Size(199, 22);
            this.t_codePostal.TabIndex = 3;
            // 
            // t_ville
            // 
            this.t_ville.Location = new System.Drawing.Point(235, 344);
            this.t_ville.Margin = new System.Windows.Forms.Padding(4);
            this.t_ville.Name = "t_ville";
            this.t_ville.Size = new System.Drawing.Size(199, 22);
            this.t_ville.TabIndex = 4;
            // 
            // t_coefNotoriete
            // 
            this.t_coefNotoriete.Location = new System.Drawing.Point(235, 422);
            this.t_coefNotoriete.Margin = new System.Windows.Forms.Padding(4);
            this.t_coefNotoriete.Name = "t_coefNotoriete";
            this.t_coefNotoriete.Size = new System.Drawing.Size(199, 22);
            this.t_coefNotoriete.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(67, 52);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(45, 17);
            this.nom.TabIndex = 7;
            this.nom.Text = "Nom :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(67, 118);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(65, 17);
            this.prenom.TabIndex = 8;
            this.prenom.Text = "Prenom :";
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(67, 190);
            this.adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(68, 17);
            this.adresse.TabIndex = 9;
            this.adresse.Text = "Adresse :";
            // 
            // codepostal
            // 
            this.codepostal.AutoSize = true;
            this.codepostal.Location = new System.Drawing.Point(67, 273);
            this.codepostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codepostal.Name = "codepostal";
            this.codepostal.Size = new System.Drawing.Size(91, 17);
            this.codepostal.TabIndex = 10;
            this.codepostal.Text = "Code postal :";
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.Location = new System.Drawing.Point(67, 347);
            this.ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(42, 17);
            this.ville.TabIndex = 11;
            this.ville.Text = "Ville :";
            // 
            // coefnotoriete
            // 
            this.coefnotoriete.AutoSize = true;
            this.coefnotoriete.Location = new System.Drawing.Point(67, 425);
            this.coefnotoriete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coefnotoriete.Name = "coefnotoriete";
            this.coefnotoriete.Size = new System.Drawing.Size(162, 17);
            this.coefnotoriete.TabIndex = 12;
            this.coefnotoriete.Text = "Coefficient de notoriete :";
            // 
            // typepraticien
            // 
            this.typepraticien.AutoSize = true;
            this.typepraticien.Location = new System.Drawing.Point(67, 501);
            this.typepraticien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typepraticien.Name = "typepraticien";
            this.typepraticien.Size = new System.Drawing.Size(126, 17);
            this.typepraticien.TabIndex = 13;
            this.typepraticien.Text = "Type du praticien :";
            // 
            // c_typePraticien
            // 
            this.c_typePraticien.FormattingEnabled = true;
            this.c_typePraticien.Location = new System.Drawing.Point(235, 497);
            this.c_typePraticien.Margin = new System.Windows.Forms.Padding(4);
            this.c_typePraticien.Name = "c_typePraticien";
            this.c_typePraticien.Size = new System.Drawing.Size(199, 24);
            this.c_typePraticien.TabIndex = 14;
            // 
            // b_validModif
            // 
            this.b_validModif.Location = new System.Drawing.Point(324, 574);
            this.b_validModif.Margin = new System.Windows.Forms.Padding(4);
            this.b_validModif.Name = "b_validModif";
            this.b_validModif.Size = new System.Drawing.Size(219, 28);
            this.b_validModif.TabIndex = 15;
            this.b_validModif.Text = "Valider les modifications";
            this.b_validModif.UseVisualStyleBackColor = true;
            this.b_validModif.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_retour
            // 
            this.b_retour.Location = new System.Drawing.Point(93, 574);
            this.b_retour.Margin = new System.Windows.Forms.Padding(4);
            this.b_retour.Name = "b_retour";
            this.b_retour.Size = new System.Drawing.Size(100, 28);
            this.b_retour.TabIndex = 16;
            this.b_retour.Text = "Retour";
            this.b_retour.UseVisualStyleBackColor = true;
            this.b_retour.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetailsPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 636);
            this.Controls.Add(this.b_retour);
            this.Controls.Add(this.b_validModif);
            this.Controls.Add(this.c_typePraticien);
            this.Controls.Add(this.typepraticien);
            this.Controls.Add(this.coefnotoriete);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.codepostal);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.t_coefNotoriete);
            this.Controls.Add(this.t_ville);
            this.Controls.Add(this.t_codePostal);
            this.Controls.Add(this.t_adresse);
            this.Controls.Add(this.t_prenom);
            this.Controls.Add(this.t_nom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailsPraticien";
            this.Text = "Details sur un Praticien";
            this.Load += new System.EventHandler(this.DetailsPraticien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.TextBox t_prenom;
        private System.Windows.Forms.TextBox t_adresse;
        private System.Windows.Forms.TextBox t_codePostal;
        private System.Windows.Forms.TextBox t_ville;
        private System.Windows.Forms.TextBox t_coefNotoriete;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label codepostal;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label coefnotoriete;
        private System.Windows.Forms.Label typepraticien;
        private System.Windows.Forms.ComboBox c_typePraticien;
        private System.Windows.Forms.Button b_validModif;
        private System.Windows.Forms.Button b_retour;
    }
}