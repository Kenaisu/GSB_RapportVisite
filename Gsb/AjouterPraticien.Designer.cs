namespace Gsb
{
    partial class AjouterPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterPraticien));
            this.t_nomPra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_prenomPra = new System.Windows.Forms.TextBox();
            this.t_adressePra = new System.Windows.Forms.TextBox();
            this.t_cpPra = new System.Windows.Forms.TextBox();
            this.t_villePra = new System.Windows.Forms.TextBox();
            this.c_typePra = new System.Windows.Forms.ComboBox();
            this.t_notoriétéPra = new System.Windows.Forms.TextBox();
            this.b_createPra = new System.Windows.Forms.Button();
            this.b_resetPra = new System.Windows.Forms.Button();
            this.b_cancelPra = new System.Windows.Forms.Button();
            this.errorCreate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // t_nomPra
            // 
            this.t_nomPra.Location = new System.Drawing.Point(121, 37);
            this.t_nomPra.Name = "t_nomPra";
            this.t_nomPra.Size = new System.Drawing.Size(148, 22);
            this.t_nomPra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Notoriété";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // t_prenomPra
            // 
            this.t_prenomPra.Location = new System.Drawing.Point(404, 37);
            this.t_prenomPra.Name = "t_prenomPra";
            this.t_prenomPra.Size = new System.Drawing.Size(132, 22);
            this.t_prenomPra.TabIndex = 8;
            // 
            // t_adressePra
            // 
            this.t_adressePra.Location = new System.Drawing.Point(121, 122);
            this.t_adressePra.Name = "t_adressePra";
            this.t_adressePra.Size = new System.Drawing.Size(415, 22);
            this.t_adressePra.TabIndex = 9;
            // 
            // t_cpPra
            // 
            this.t_cpPra.Location = new System.Drawing.Point(121, 205);
            this.t_cpPra.Name = "t_cpPra";
            this.t_cpPra.Size = new System.Drawing.Size(96, 22);
            this.t_cpPra.TabIndex = 10;
            // 
            // t_villePra
            // 
            this.t_villePra.Location = new System.Drawing.Point(404, 205);
            this.t_villePra.Name = "t_villePra";
            this.t_villePra.Size = new System.Drawing.Size(132, 22);
            this.t_villePra.TabIndex = 11;
            // 
            // c_typePra
            // 
            this.c_typePra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_typePra.FormattingEnabled = true;
            this.c_typePra.Items.AddRange(new object[] {
            "Médecin Hospitalier",
            "Médecine de Ville",
            "Pharmacien Hospitalier",
            "Pharmacien Officine",
            "Personnel de santé"});
            this.c_typePra.Location = new System.Drawing.Point(121, 283);
            this.c_typePra.Name = "c_typePra";
            this.c_typePra.Size = new System.Drawing.Size(180, 24);
            this.c_typePra.TabIndex = 12;
            this.c_typePra.SelectedIndexChanged += new System.EventHandler(this.c_typePra_SelectedIndexChanged);
            // 
            // t_notoriétéPra
            // 
            this.t_notoriétéPra.Location = new System.Drawing.Point(121, 351);
            this.t_notoriétéPra.Name = "t_notoriétéPra";
            this.t_notoriétéPra.Size = new System.Drawing.Size(96, 22);
            this.t_notoriétéPra.TabIndex = 13;
            this.t_notoriétéPra.TextChanged += new System.EventHandler(this.t_notoriétéPra_TextChanged);
            // 
            // b_createPra
            // 
            this.b_createPra.Location = new System.Drawing.Point(249, 443);
            this.b_createPra.Name = "b_createPra";
            this.b_createPra.Size = new System.Drawing.Size(75, 23);
            this.b_createPra.TabIndex = 14;
            this.b_createPra.Text = "Ajouter";
            this.b_createPra.UseVisualStyleBackColor = true;
            this.b_createPra.Click += new System.EventHandler(this.b_createPra_Click);
            // 
            // b_resetPra
            // 
            this.b_resetPra.Location = new System.Drawing.Point(393, 443);
            this.b_resetPra.Name = "b_resetPra";
            this.b_resetPra.Size = new System.Drawing.Size(75, 23);
            this.b_resetPra.TabIndex = 15;
            this.b_resetPra.Text = "Reset";
            this.b_resetPra.UseVisualStyleBackColor = true;
            this.b_resetPra.Click += new System.EventHandler(this.b_resetPra_Click);
            // 
            // b_cancelPra
            // 
            this.b_cancelPra.Location = new System.Drawing.Point(520, 429);
            this.b_cancelPra.Name = "b_cancelPra";
            this.b_cancelPra.Size = new System.Drawing.Size(143, 51);
            this.b_cancelPra.TabIndex = 16;
            this.b_cancelPra.Text = "Retour a la création du rapport";
            this.b_cancelPra.UseVisualStyleBackColor = true;
            this.b_cancelPra.Click += new System.EventHandler(this.b_cancelPra_Click);
            // 
            // errorCreate
            // 
            this.errorCreate.ContainerControl = this;
            // 
            // AjouterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.b_cancelPra);
            this.Controls.Add(this.b_resetPra);
            this.Controls.Add(this.b_createPra);
            this.Controls.Add(this.t_notoriétéPra);
            this.Controls.Add(this.c_typePra);
            this.Controls.Add(this.t_villePra);
            this.Controls.Add(this.t_cpPra);
            this.Controls.Add(this.t_adressePra);
            this.Controls.Add(this.t_prenomPra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_nomPra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterPraticien";
            this.Text = "Ajout d\'un Praticien";
            ((System.ComponentModel.ISupportInitialize)(this.errorCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_nomPra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_prenomPra;
        private System.Windows.Forms.TextBox t_adressePra;
        private System.Windows.Forms.TextBox t_cpPra;
        private System.Windows.Forms.TextBox t_villePra;
        private System.Windows.Forms.ComboBox c_typePra;
        private System.Windows.Forms.TextBox t_notoriétéPra;
        private System.Windows.Forms.Button b_createPra;
        private System.Windows.Forms.Button b_resetPra;
        private System.Windows.Forms.Button b_cancelPra;
        private System.Windows.Forms.ErrorProvider errorCreate;
    }
}