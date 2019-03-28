namespace Gsb
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.t_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_mdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_valide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.error_login = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_mdp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mdp)).BeginInit();
            this.SuspendLayout();
            // 
            // t_login
            // 
            this.t_login.Location = new System.Drawing.Point(257, 107);
            this.t_login.Margin = new System.Windows.Forms.Padding(4);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(180, 22);
            this.t_login.TabIndex = 0;
            this.t_login.Text = "Andre";
            this.t_login.TextChanged += new System.EventHandler(this.t_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant";
            // 
            // t_mdp
            // 
            this.t_mdp.Location = new System.Drawing.Point(257, 191);
            this.t_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.t_mdp.Name = "t_mdp";
            this.t_mdp.Size = new System.Drawing.Size(180, 22);
            this.t_mdp.TabIndex = 2;
            this.t_mdp.Text = "1991-aug-26";
            this.t_mdp.TextChanged += new System.EventHandler(this.t_mdp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // b_valide
            // 
            this.b_valide.Location = new System.Drawing.Point(276, 301);
            this.b_valide.Margin = new System.Windows.Forms.Padding(4);
            this.b_valide.Name = "b_valide";
            this.b_valide.Size = new System.Drawing.Size(100, 28);
            this.b_valide.TabIndex = 4;
            this.b_valide.Text = "Valider";
            this.b_valide.UseVisualStyleBackColor = true;
            this.b_valide.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identifiez-vous";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "1991-aug-26";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Andre";
            // 
            // error_login
            // 
            this.error_login.ContainerControl = this;
            // 
            // error_mdp
            // 
            this.error_mdp.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(653, 389);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_valide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_mdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_mdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_valide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider error_login;
        private System.Windows.Forms.ErrorProvider error_mdp;
    }
}

