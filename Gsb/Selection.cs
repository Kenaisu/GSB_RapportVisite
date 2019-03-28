using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gsb
{
    public partial class Selection : Form
    {
        private string login;
        private string motDepasse;
        private string natuser;


        public Selection(string log, string mdp, string natUser)
        {
            InitializeComponent();
            login = log;
            motDepasse = mdp;
            l_showusername.Text = login;
            natuser = natUser;

            //créerUnRapportToolStripMenuItem.Hide();
        }

        private void créerUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.Hide();
            RapportVisite nouveauRapport = new RapportVisite(login, motDepasse, natuser);
            nouveauRapport.ShowDialog();
            this.Close();
        }

        private void l_showusername_Click(object sender, EventArgs e)
        {

        }

        private void voirRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (natuser == "visiteur")
            {
                this.Hide();
                VoirRapportVisiteVisiteur voirRapportV = new VoirRapportVisiteVisiteur(login);
                voirRapportV.ShowDialog();
                this.Close();
            }
            else if (natuser == "responsable" || natuser == "admin")
            {
                this.Hide();
                VoirRapportVisite voirRapport = new VoirRapportVisite(login, natuser);
                voirRapport.ShowDialog();
                this.Close();
            }
        }
        
        private void b_quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir quitter ?", "Rapport de visite GSB", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }            
        }
    }
}
