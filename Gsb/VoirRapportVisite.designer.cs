namespace Gsb
{
    partial class VoirRapportVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoirRapportVisite));
            this.b_details = new System.Windows.Forms.Button();
            this.c_visiteur = new System.Windows.Forms.ComboBox();
            this.c_numRapport = new System.Windows.Forms.ComboBox();
            this.visiteur = new System.Windows.Forms.Label();
            this.numerorapport = new System.Windows.Forms.Label();
            this.praticienVisite = new System.Windows.Forms.Label();
            this.l_nomPrenomPraticien = new System.Windows.Forms.Label();
            this.motif = new System.Windows.Forms.Label();
            this.l_motif = new System.Windows.Forms.Label();
            this.l_numVisiteur = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_prenom = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.bilan = new System.Windows.Forms.Label();
            this.l_bilan = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_close = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_details
            // 
            this.b_details.Location = new System.Drawing.Point(627, 256);
            this.b_details.Margin = new System.Windows.Forms.Padding(4);
            this.b_details.Name = "b_details";
            this.b_details.Size = new System.Drawing.Size(164, 28);
            this.b_details.TabIndex = 0;
            this.b_details.Text = "Détails du praticien";
            this.b_details.UseVisualStyleBackColor = true;
            this.b_details.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_visiteur
            // 
            this.c_visiteur.FormattingEnabled = true;
            this.c_visiteur.Items.AddRange(new object[] {
            "Tous"});
            this.c_visiteur.Location = new System.Drawing.Point(205, 76);
            this.c_visiteur.Margin = new System.Windows.Forms.Padding(4);
            this.c_visiteur.Name = "c_visiteur";
            this.c_visiteur.Size = new System.Drawing.Size(199, 24);
            this.c_visiteur.TabIndex = 1;
            this.c_visiteur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // c_numRapport
            // 
            this.c_numRapport.FormattingEnabled = true;
            this.c_numRapport.Location = new System.Drawing.Point(201, 211);
            this.c_numRapport.Margin = new System.Windows.Forms.Padding(4);
            this.c_numRapport.Name = "c_numRapport";
            this.c_numRapport.Size = new System.Drawing.Size(199, 24);
            this.c_numRapport.TabIndex = 2;
            this.c_numRapport.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // visiteur
            // 
            this.visiteur.AutoSize = true;
            this.visiteur.Location = new System.Drawing.Point(55, 86);
            this.visiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visiteur.Name = "visiteur";
            this.visiteur.Size = new System.Drawing.Size(55, 17);
            this.visiteur.TabIndex = 3;
            this.visiteur.Text = "Visiteur";
            // 
            // numerorapport
            // 
            this.numerorapport.AutoSize = true;
            this.numerorapport.Location = new System.Drawing.Point(51, 221);
            this.numerorapport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numerorapport.Name = "numerorapport";
            this.numerorapport.Size = new System.Drawing.Size(128, 17);
            this.numerorapport.TabIndex = 4;
            this.numerorapport.Text = "Numéro de rapport";
            // 
            // praticienVisite
            // 
            this.praticienVisite.AutoSize = true;
            this.praticienVisite.Location = new System.Drawing.Point(51, 268);
            this.praticienVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.praticienVisite.Name = "praticienVisite";
            this.praticienVisite.Size = new System.Drawing.Size(101, 17);
            this.praticienVisite.TabIndex = 5;
            this.praticienVisite.Text = "Praticien Visité";
            // 
            // l_nomPrenomPraticien
            // 
            this.l_nomPrenomPraticien.AutoSize = true;
            this.l_nomPrenomPraticien.Location = new System.Drawing.Point(197, 268);
            this.l_nomPrenomPraticien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_nomPrenomPraticien.Name = "l_nomPrenomPraticien";
            this.l_nomPrenomPraticien.Size = new System.Drawing.Size(0, 17);
            this.l_nomPrenomPraticien.TabIndex = 6;
            // 
            // motif
            // 
            this.motif.AutoSize = true;
            this.motif.Location = new System.Drawing.Point(51, 381);
            this.motif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motif.Name = "motif";
            this.motif.Size = new System.Drawing.Size(46, 17);
            this.motif.TabIndex = 7;
            this.motif.Text = "Motif :";
            // 
            // l_motif
            // 
            this.l_motif.AutoSize = true;
            this.l_motif.Location = new System.Drawing.Point(197, 381);
            this.l_motif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_motif.Name = "l_motif";
            this.l_motif.Size = new System.Drawing.Size(0, 17);
            this.l_motif.TabIndex = 8;
            // 
            // l_numVisiteur
            // 
            this.l_numVisiteur.AutoSize = true;
            this.l_numVisiteur.Location = new System.Drawing.Point(627, 80);
            this.l_numVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_numVisiteur.Name = "l_numVisiteur";
            this.l_numVisiteur.Size = new System.Drawing.Size(0, 17);
            this.l_numVisiteur.TabIndex = 9;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(733, 80);
            this.l_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(0, 17);
            this.l_nom.TabIndex = 10;
            this.l_nom.Click += new System.EventHandler(this.label8_Click);
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Location = new System.Drawing.Point(839, 80);
            this.l_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(0, 17);
            this.l_prenom.TabIndex = 11;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(623, 194);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(46, 17);
            this.date.TabIndex = 12;
            this.date.Text = "Date :";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Location = new System.Drawing.Point(729, 194);
            this.l_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(0, 17);
            this.l_date.TabIndex = 13;
            // 
            // bilan
            // 
            this.bilan.AutoSize = true;
            this.bilan.Location = new System.Drawing.Point(623, 381);
            this.bilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilan.Name = "bilan";
            this.bilan.Size = new System.Drawing.Size(47, 17);
            this.bilan.TabIndex = 14;
            this.bilan.Text = "Bilan :";
            // 
            // l_bilan
            // 
            this.l_bilan.Location = new System.Drawing.Point(679, 381);
            this.l_bilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_bilan.Name = "l_bilan";
            this.l_bilan.Size = new System.Drawing.Size(275, 96);
            this.l_bilan.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 481);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 149);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(980, 622);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 32;
            this.b_close.Text = "Fermer";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 21);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Entre deux dates données";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 171);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // VoirRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 657);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_bilan);
            this.Controls.Add(this.bilan);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.date);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.l_numVisiteur);
            this.Controls.Add(this.l_motif);
            this.Controls.Add(this.motif);
            this.Controls.Add(this.l_nomPrenomPraticien);
            this.Controls.Add(this.praticienVisite);
            this.Controls.Add(this.numerorapport);
            this.Controls.Add(this.visiteur);
            this.Controls.Add(this.c_numRapport);
            this.Controls.Add(this.c_visiteur);
            this.Controls.Add(this.b_details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoirRapportVisite";
            this.Text = "Voir un Rapport de Visite";
            this.Load += new System.EventHandler(this.VoirRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_details;
        private System.Windows.Forms.ComboBox c_visiteur;
        private System.Windows.Forms.ComboBox c_numRapport;
        private System.Windows.Forms.Label visiteur;
        private System.Windows.Forms.Label numerorapport;
        private System.Windows.Forms.Label praticienVisite;
        private System.Windows.Forms.Label l_nomPrenomPraticien;
        private System.Windows.Forms.Label motif;
        private System.Windows.Forms.Label l_motif;
        private System.Windows.Forms.Label l_numVisiteur;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Label bilan;
        private System.Windows.Forms.Label l_bilan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}