namespace Gsb
{
    partial class RapportVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapportVisite));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_checkPraticien = new System.Windows.Forms.Button();
            this.b_createRapport = new System.Windows.Forms.Button();
            this.b_resetRapport = new System.Windows.Forms.Button();
            this.t_codeVisiteur = new System.Windows.Forms.TextBox();
            this.date_visite = new System.Windows.Forms.DateTimePicker();
            this.t_bilan = new System.Windows.Forms.RichTextBox();
            this.c_praticien = new System.Windows.Forms.ComboBox();
            this.c_motif = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c_connaissance = new System.Windows.Forms.ComboBox();
            this.c_confiance = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.c_concu = new System.Windows.Forms.ComboBox();
            this.check_futurVisite = new System.Windows.Forms.CheckBox();
            this.date_futurVisite = new System.Windows.Forms.DateTimePicker();
            this.b_close = new System.Windows.Forms.Button();
            this.errorDetailPra = new System.Windows.Forms.ErrorProvider(this.components);
            this.t_newMotif = new System.Windows.Forms.TextBox();
            this.l_newMotif = new System.Windows.Forms.Label();
            this.tab_medic = new System.Windows.Forms.DataGridView();
            this.medicamentMedi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tab_echan = new System.Windows.Forms.DataGridView();
            this.medicamentEchan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuantiteEchan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorCreate = new System.Windows.Forms.ErrorProvider(this.components);
            this.b_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorDetailPra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_medic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_echan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votre Code Visiteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Praticien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de la visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bilan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // b_checkPraticien
            // 
            this.b_checkPraticien.Location = new System.Drawing.Point(419, 127);
            this.b_checkPraticien.Name = "b_checkPraticien";
            this.b_checkPraticien.Size = new System.Drawing.Size(145, 24);
            this.b_checkPraticien.TabIndex = 6;
            this.b_checkPraticien.Text = "Détails du praticien";
            this.b_checkPraticien.UseVisualStyleBackColor = true;
            this.b_checkPraticien.Click += new System.EventHandler(this.b_checkPraticien_Click);
            // 
            // b_createRapport
            // 
            this.b_createRapport.Location = new System.Drawing.Point(625, 716);
            this.b_createRapport.Name = "b_createRapport";
            this.b_createRapport.Size = new System.Drawing.Size(75, 23);
            this.b_createRapport.TabIndex = 7;
            this.b_createRapport.Text = "Créer";
            this.b_createRapport.UseVisualStyleBackColor = true;
            this.b_createRapport.Click += new System.EventHandler(this.b_createRapport_Click);
            // 
            // b_resetRapport
            // 
            this.b_resetRapport.Location = new System.Drawing.Point(746, 716);
            this.b_resetRapport.Name = "b_resetRapport";
            this.b_resetRapport.Size = new System.Drawing.Size(75, 23);
            this.b_resetRapport.TabIndex = 8;
            this.b_resetRapport.Text = "Reset";
            this.b_resetRapport.UseVisualStyleBackColor = true;
            this.b_resetRapport.Click += new System.EventHandler(this.button3_Click);
            // 
            // t_codeVisiteur
            // 
            this.t_codeVisiteur.Location = new System.Drawing.Point(176, 44);
            this.t_codeVisiteur.Name = "t_codeVisiteur";
            this.t_codeVisiteur.Size = new System.Drawing.Size(121, 22);
            this.t_codeVisiteur.TabIndex = 10;
            this.t_codeVisiteur.TextChanged += new System.EventHandler(this.t_codeVisiteur_TextChanged);
            // 
            // date_visite
            // 
            this.date_visite.Location = new System.Drawing.Point(176, 209);
            this.date_visite.Name = "date_visite";
            this.date_visite.Size = new System.Drawing.Size(223, 22);
            this.date_visite.TabIndex = 15;
            // 
            // t_bilan
            // 
            this.t_bilan.Location = new System.Drawing.Point(176, 360);
            this.t_bilan.Name = "t_bilan";
            this.t_bilan.Size = new System.Drawing.Size(240, 139);
            this.t_bilan.TabIndex = 16;
            this.t_bilan.Text = "";
            // 
            // c_praticien
            // 
            this.c_praticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_praticien.FormattingEnabled = true;
            this.c_praticien.Items.AddRange(new object[] {
            "Nouveau Praticien"});
            this.c_praticien.Location = new System.Drawing.Point(176, 128);
            this.c_praticien.Name = "c_praticien";
            this.c_praticien.Size = new System.Drawing.Size(223, 24);
            this.c_praticien.TabIndex = 17;
            this.c_praticien.SelectedIndexChanged += new System.EventHandler(this.c_praticien_SelectedIndexChanged);
            // 
            // c_motif
            // 
            this.c_motif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_motif.FormattingEnabled = true;
            this.c_motif.Items.AddRange(new object[] {
            "Autre motif"});
            this.c_motif.Location = new System.Drawing.Point(176, 288);
            this.c_motif.Name = "c_motif";
            this.c_motif.Size = new System.Drawing.Size(223, 24);
            this.c_motif.TabIndex = 19;
            this.c_motif.SelectedIndexChanged += new System.EventHandler(this.c_motif_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Connaissance praticien";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Confiance labo";
            // 
            // c_connaissance
            // 
            this.c_connaissance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_connaissance.FormattingEnabled = true;
            this.c_connaissance.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Je ne sais pas"});
            this.c_connaissance.Location = new System.Drawing.Point(822, 46);
            this.c_connaissance.Name = "c_connaissance";
            this.c_connaissance.Size = new System.Drawing.Size(95, 24);
            this.c_connaissance.TabIndex = 24;
            // 
            // c_confiance
            // 
            this.c_confiance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_confiance.FormattingEnabled = true;
            this.c_confiance.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Je ne sais pas"});
            this.c_confiance.Location = new System.Drawing.Point(822, 122);
            this.c_confiance.Name = "c_confiance";
            this.c_confiance.Size = new System.Drawing.Size(95, 24);
            this.c_confiance.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Présence de concurence";
            // 
            // c_concu
            // 
            this.c_concu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_concu.FormattingEnabled = true;
            this.c_concu.Items.AddRange(new object[] {
            "oui",
            "non"});
            this.c_concu.Location = new System.Drawing.Point(822, 193);
            this.c_concu.Name = "c_concu";
            this.c_concu.Size = new System.Drawing.Size(95, 24);
            this.c_concu.TabIndex = 27;
            // 
            // check_futurVisite
            // 
            this.check_futurVisite.AutoSize = true;
            this.check_futurVisite.Location = new System.Drawing.Point(635, 260);
            this.check_futurVisite.Name = "check_futurVisite";
            this.check_futurVisite.Size = new System.Drawing.Size(128, 21);
            this.check_futurVisite.TabIndex = 29;
            this.check_futurVisite.Text = "Reprise de Rdv";
            this.check_futurVisite.UseVisualStyleBackColor = true;
            this.check_futurVisite.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // date_futurVisite
            // 
            this.date_futurVisite.Location = new System.Drawing.Point(635, 289);
            this.date_futurVisite.Name = "date_futurVisite";
            this.date_futurVisite.Size = new System.Drawing.Size(205, 22);
            this.date_futurVisite.TabIndex = 30;
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(867, 716);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 31;
            this.b_close.Text = "Fermer";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // errorDetailPra
            // 
            this.errorDetailPra.ContainerControl = this;
            // 
            // t_newMotif
            // 
            this.t_newMotif.Location = new System.Drawing.Point(419, 289);
            this.t_newMotif.Name = "t_newMotif";
            this.t_newMotif.Size = new System.Drawing.Size(121, 22);
            this.t_newMotif.TabIndex = 32;
            // 
            // l_newMotif
            // 
            this.l_newMotif.AutoSize = true;
            this.l_newMotif.Location = new System.Drawing.Point(416, 264);
            this.l_newMotif.Name = "l_newMotif";
            this.l_newMotif.Size = new System.Drawing.Size(99, 17);
            this.l_newMotif.TabIndex = 33;
            this.l_newMotif.Text = "Nouveau motif";
            // 
            // tab_medic
            // 
            this.tab_medic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_medic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamentMedi});
            this.tab_medic.Location = new System.Drawing.Point(625, 360);
            this.tab_medic.Name = "tab_medic";
            this.tab_medic.RowTemplate.Height = 24;
            this.tab_medic.Size = new System.Drawing.Size(318, 215);
            this.tab_medic.TabIndex = 34;
            this.tab_medic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medicamentMedi
            // 
            this.medicamentMedi.HeaderText = "Medicament";
            this.medicamentMedi.Name = "medicamentMedi";
            this.medicamentMedi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentMedi.Width = 195;
            // 
            // tab_echan
            // 
            this.tab_echan.AllowUserToOrderColumns = true;
            this.tab_echan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_echan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamentEchan,
            this.QuantiteEchan});
            this.tab_echan.Location = new System.Drawing.Point(176, 540);
            this.tab_echan.Name = "tab_echan";
            this.tab_echan.RowTemplate.Height = 24;
            this.tab_echan.Size = new System.Drawing.Size(388, 199);
            this.tab_echan.TabIndex = 35;
            // 
            // medicamentEchan
            // 
            this.medicamentEchan.HeaderText = "Medicament";
            this.medicamentEchan.Name = "medicamentEchan";
            this.medicamentEchan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentEchan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.medicamentEchan.Width = 195;
            // 
            // QuantiteEchan
            // 
            this.QuantiteEchan.HeaderText = "Quantité";
            this.QuantiteEchan.MaxInputLength = 4;
            this.QuantiteEchan.Name = "QuantiteEchan";
            this.QuantiteEchan.Width = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Médicaments présentés";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Echantillions offerts";
            // 
            // errorCreate
            // 
            this.errorCreate.ContainerControl = this;
            // 
            // b_test
            // 
            this.b_test.Location = new System.Drawing.Point(714, 625);
            this.b_test.Name = "b_test";
            this.b_test.Size = new System.Drawing.Size(143, 34);
            this.b_test.TabIndex = 38;
            this.b_test.Text = "Test medocs";
            this.b_test.UseVisualStyleBackColor = true;
            this.b_test.Click += new System.EventHandler(this.b_test_Click);
            // 
            // RapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 762);
            this.Controls.Add(this.b_test);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_echan);
            this.Controls.Add(this.tab_medic);
            this.Controls.Add(this.l_newMotif);
            this.Controls.Add(this.t_newMotif);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.date_futurVisite);
            this.Controls.Add(this.check_futurVisite);
            this.Controls.Add(this.c_concu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.c_confiance);
            this.Controls.Add(this.c_connaissance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c_motif);
            this.Controls.Add(this.c_praticien);
            this.Controls.Add(this.t_bilan);
            this.Controls.Add(this.date_visite);
            this.Controls.Add(this.t_codeVisiteur);
            this.Controls.Add(this.b_resetRapport);
            this.Controls.Add(this.b_createRapport);
            this.Controls.Add(this.b_checkPraticien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RapportVisite";
            this.Text = "Création d\'un Rapport de Visite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RapportVisite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorDetailPra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_medic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_echan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_checkPraticien;
        private System.Windows.Forms.Button b_createRapport;
        private System.Windows.Forms.Button b_resetRapport;
        private System.Windows.Forms.TextBox t_codeVisiteur;
        private System.Windows.Forms.DateTimePicker date_visite;
        private System.Windows.Forms.RichTextBox t_bilan;
        private System.Windows.Forms.ComboBox c_praticien;
        private System.Windows.Forms.ComboBox c_motif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox c_connaissance;
        private System.Windows.Forms.ComboBox c_confiance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox c_concu;
        private System.Windows.Forms.CheckBox check_futurVisite;
        private System.Windows.Forms.DateTimePicker date_futurVisite;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.ErrorProvider errorDetailPra;
        private System.Windows.Forms.Label l_newMotif;
        private System.Windows.Forms.TextBox t_newMotif;
        private System.Windows.Forms.DataGridView tab_medic;
        private System.Windows.Forms.DataGridView tab_echan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorCreate;
        private System.Windows.Forms.DataGridViewComboBoxColumn medicamentMedi;
        private System.Windows.Forms.DataGridViewComboBoxColumn medicamentEchan;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantiteEchan;
        private System.Windows.Forms.Button b_test;
    }
}