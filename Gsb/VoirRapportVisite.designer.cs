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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoirRapportVisite));
            this.b_details = new System.Windows.Forms.Button();
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
            this.data_presente = new System.Windows.Forms.DataGridView();
            this.e_detailsPraticien = new System.Windows.Forms.ErrorProvider(this.components);
            this.c_visiteur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.b_supprimer = new System.Windows.Forms.Button();
            this.check_entre2Dates = new System.Windows.Forms.CheckBox();
            this.date_debutDate = new System.Windows.Forms.DateTimePicker();
            this.date_finDate = new System.Windows.Forms.DateTimePicker();
            this.data_offert = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_presente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_detailsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_offert)).BeginInit();
            this.SuspendLayout();
            // 
            // b_details
            // 
            this.b_details.Location = new System.Drawing.Point(689, 266);
            this.b_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_details.Name = "b_details";
            this.b_details.Size = new System.Drawing.Size(164, 28);
            this.b_details.TabIndex = 0;
            this.b_details.Text = "Détails du praticien";
            this.b_details.UseVisualStyleBackColor = true;
            this.b_details.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_numRapport
            // 
            this.c_numRapport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_numRapport.FormattingEnabled = true;
            this.c_numRapport.Location = new System.Drawing.Point(203, 231);
            this.c_numRapport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_numRapport.Name = "c_numRapport";
            this.c_numRapport.Size = new System.Drawing.Size(272, 24);
            this.c_numRapport.TabIndex = 2;
            this.c_numRapport.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // visiteur
            // 
            this.visiteur.AutoSize = true;
            this.visiteur.Location = new System.Drawing.Point(63, 89);
            this.visiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visiteur.Name = "visiteur";
            this.visiteur.Size = new System.Drawing.Size(55, 17);
            this.visiteur.TabIndex = 3;
            this.visiteur.Text = "Visiteur";
            // 
            // numerorapport
            // 
            this.numerorapport.AutoSize = true;
            this.numerorapport.Location = new System.Drawing.Point(52, 231);
            this.numerorapport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numerorapport.Name = "numerorapport";
            this.numerorapport.Size = new System.Drawing.Size(128, 17);
            this.numerorapport.TabIndex = 4;
            this.numerorapport.Text = "Numéro de rapport";
            // 
            // praticienVisite
            // 
            this.praticienVisite.AutoSize = true;
            this.praticienVisite.Location = new System.Drawing.Point(99, 310);
            this.praticienVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.praticienVisite.Name = "praticienVisite";
            this.praticienVisite.Size = new System.Drawing.Size(101, 17);
            this.praticienVisite.TabIndex = 5;
            this.praticienVisite.Text = "Praticien Visité";
            // 
            // l_nomPrenomPraticien
            // 
            this.l_nomPrenomPraticien.AutoSize = true;
            this.l_nomPrenomPraticien.Location = new System.Drawing.Point(245, 310);
            this.l_nomPrenomPraticien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_nomPrenomPraticien.Name = "l_nomPrenomPraticien";
            this.l_nomPrenomPraticien.Size = new System.Drawing.Size(0, 17);
            this.l_nomPrenomPraticien.TabIndex = 6;
            // 
            // motif
            // 
            this.motif.AutoSize = true;
            this.motif.Location = new System.Drawing.Point(99, 423);
            this.motif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motif.Name = "motif";
            this.motif.Size = new System.Drawing.Size(46, 17);
            this.motif.TabIndex = 7;
            this.motif.Text = "Motif :";
            // 
            // l_motif
            // 
            this.l_motif.AutoSize = true;
            this.l_motif.Location = new System.Drawing.Point(245, 423);
            this.l_motif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_motif.Name = "l_motif";
            this.l_motif.Size = new System.Drawing.Size(0, 17);
            this.l_motif.TabIndex = 8;
            // 
            // l_numVisiteur
            // 
            this.l_numVisiteur.AutoSize = true;
            this.l_numVisiteur.Location = new System.Drawing.Point(635, 82);
            this.l_numVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_numVisiteur.Name = "l_numVisiteur";
            this.l_numVisiteur.Size = new System.Drawing.Size(0, 17);
            this.l_numVisiteur.TabIndex = 9;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(741, 82);
            this.l_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(0, 17);
            this.l_nom.TabIndex = 10;
            this.l_nom.Click += new System.EventHandler(this.label8_Click);
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Location = new System.Drawing.Point(847, 82);
            this.l_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(0, 17);
            this.l_prenom.TabIndex = 11;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(689, 196);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(46, 17);
            this.date.TabIndex = 12;
            this.date.Text = "Date :";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Location = new System.Drawing.Point(796, 196);
            this.l_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(0, 17);
            this.l_date.TabIndex = 13;
            // 
            // bilan
            // 
            this.bilan.AutoSize = true;
            this.bilan.Location = new System.Drawing.Point(685, 391);
            this.bilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilan.Name = "bilan";
            this.bilan.Size = new System.Drawing.Size(47, 17);
            this.bilan.TabIndex = 14;
            this.bilan.Text = "Bilan :";
            // 
            // l_bilan
            // 
            this.l_bilan.Location = new System.Drawing.Point(741, 391);
            this.l_bilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_bilan.Name = "l_bilan";
            this.l_bilan.Size = new System.Drawing.Size(275, 96);
            this.l_bilan.TabIndex = 15;
            // 
            // data_presente
            // 
            this.data_presente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_presente.Location = new System.Drawing.Point(24, 491);
            this.data_presente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_presente.Name = "data_presente";
            this.data_presente.Size = new System.Drawing.Size(267, 149);
            this.data_presente.TabIndex = 16;
            this.data_presente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // e_detailsPraticien
            // 
            this.e_detailsPraticien.ContainerControl = this;
            // 
            // c_visiteur
            // 
            this.c_visiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_visiteur.FormattingEnabled = true;
            this.c_visiteur.Items.AddRange(new object[] {
            "Tous les visiteurs"});
            this.c_visiteur.Location = new System.Drawing.Point(213, 79);
            this.c_visiteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_visiteur.Name = "c_visiteur";
            this.c_visiteur.Size = new System.Drawing.Size(199, 24);
            this.c_visiteur.TabIndex = 1;
            this.c_visiteur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // b_supprimer
            // 
            this.b_supprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_supprimer.Location = new System.Drawing.Point(744, 590);
            this.b_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_supprimer.Name = "b_supprimer";
            this.b_supprimer.Size = new System.Drawing.Size(164, 28);
            this.b_supprimer.TabIndex = 33;
            this.b_supprimer.Text = "Supprimer";
            this.b_supprimer.UseVisualStyleBackColor = true;
            this.b_supprimer.Click += new System.EventHandler(this.b_supprimer_Click_1);
            // 
            // check_entre2Dates
            // 
            this.check_entre2Dates.AutoSize = true;
            this.check_entre2Dates.Location = new System.Drawing.Point(316, 124);
            this.check_entre2Dates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_entre2Dates.Name = "check_entre2Dates";
            this.check_entre2Dates.Size = new System.Drawing.Size(196, 21);
            this.check_entre2Dates.TabIndex = 34;
            this.check_entre2Dates.Text = "Entre deux dates données";
            this.check_entre2Dates.UseVisualStyleBackColor = true;
            this.check_entre2Dates.CheckedChanged += new System.EventHandler(this.check_entre2Dates_CheckedChanged);
            // 
            // date_debutDate
            // 
            this.date_debutDate.Location = new System.Drawing.Point(24, 172);
            this.date_debutDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_debutDate.Name = "date_debutDate";
            this.date_debutDate.Size = new System.Drawing.Size(265, 22);
            this.date_debutDate.TabIndex = 35;
            this.date_debutDate.ValueChanged += new System.EventHandler(this.date_debutDate_ValueChanged);
            // 
            // date_finDate
            // 
            this.date_finDate.Location = new System.Drawing.Point(368, 172);
            this.date_finDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_finDate.Name = "date_finDate";
            this.date_finDate.Size = new System.Drawing.Size(265, 22);
            this.date_finDate.TabIndex = 36;
            this.date_finDate.ValueChanged += new System.EventHandler(this.date_finDate_ValueChanged);
            // 
            // data_offert
            // 
            this.data_offert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_offert.Location = new System.Drawing.Point(344, 491);
            this.data_offert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_offert.Name = "data_offert";
            this.data_offert.Size = new System.Drawing.Size(389, 149);
            this.data_offert.TabIndex = 37;
            this.data_offert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Médicaments offert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Médicaments presentées";
            // 
            // VoirRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_offert);
            this.Controls.Add(this.date_finDate);
            this.Controls.Add(this.date_debutDate);
            this.Controls.Add(this.check_entre2Dates);
            this.Controls.Add(this.b_supprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_presente);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VoirRapportVisite";
            this.Text = "Rapport de visite";
            this.Load += new System.EventHandler(this.VoirRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_presente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_detailsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_offert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_details;
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
        private System.Windows.Forms.DataGridView data_presente;
        private System.Windows.Forms.ErrorProvider e_detailsPraticien;
        private System.Windows.Forms.ComboBox c_visiteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_supprimer;
        private System.Windows.Forms.DateTimePicker date_finDate;
        private System.Windows.Forms.DateTimePicker date_debutDate;
        private System.Windows.Forms.CheckBox check_entre2Dates;
        private System.Windows.Forms.DataGridView data_offert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}