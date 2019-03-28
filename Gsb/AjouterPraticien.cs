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
    public partial class AjouterPraticien : Form
    {
        string chaineConnexion = "datasource=127.0.0.1;port=3306;Database=applicationppe;username=root;password=;SslMode=none";

        string nomPra = "";
        string prenomPra = "";
        string adressePra = "";
        string cpPra = "";
        string villePra = "";
        string typePra = "";
        double notorietePra = 0;

        public AjouterPraticien()
        {
            InitializeComponent();
            /*
            string selectTypePra = "select typ_libelle from type_praticien";
            CURS css = new CURS(chaineConnexion);
            css.ReqSelect(selectTypePra);

            while (!css.Fin())
            {
                c_typePra.Items.Add(css.champ("typ_libelle"));
                css.suivant();
            }
            css.fermer();
            */
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void b_cancelPra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_resetPra_Click(object sender, EventArgs e)
        {
            t_nomPra.Text = null;
            t_prenomPra.Text = null;
            t_adressePra.Text = null;
            t_cpPra.Text = null;
            t_villePra.Text = null;
            c_typePra.Text = null;
            t_notoriétéPra.Text = null;               
        }

        private void b_createPra_Click(object sender, EventArgs e)
        {            
            if (double.TryParse(t_notoriétéPra.Text, out notorietePra))
            {
                // c’est ok txtBox.Text est un int et on peut utiliser test ici
                MessageBox.Show("notoriete est a" + notorietePra);
            }
            try
            {


                if (t_nomPra.Text != string.Empty && t_prenomPra.Text != string.Empty && t_adressePra.Text != string.Empty && t_cpPra.Text != string.Empty && t_villePra.Text != string.Empty && c_typePra.Text != string.Empty && t_notoriétéPra.Text != string.Empty)
                {
                    nomPra = t_nomPra.Text;
                    prenomPra = t_prenomPra.Text;
                    adressePra = t_adressePra.Text;
                    cpPra = t_cpPra.Text;
                    villePra = t_villePra.Text;
                    //typePra = c_typePra.Text;

                    notorietePra = Convert.ToDouble(t_notoriétéPra.Text.Trim());


                    string insertPra = "INSERT INTO praticien(PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE) VALUES(" + "'" + nomPra + "'" + ", " + "'" + prenomPra + "'" + ", " + "'" + adressePra + "'" + "," + "'" + cpPra + "'" + "," + "'" + villePra + "'" + "," + notorietePra + "," + "'" + typePra + "'" + ")";

                    CURS css = new CURS(chaineConnexion);
                    css.ReqAdmin(insertPra);

                    css.fermer();


                    MessageBox.Show("Le praticien a bien été ajouté.");
                    this.Close();
                }
                else
                {
                    errorCreate.SetError(b_createPra, "Veuillez renseignez toutes les informations.");
                    //MessageBox.Show("Veuillez renseignez toutes les informations.");
                }
            }
            catch
            {
                errorCreate.SetError(b_createPra, "La notoriété ne doit être composé que de chiffres.");
                //MessageBox.Show("La notoriété ne doit être composé que de chiffres.");
            }


        }

        public void saisie(ref string s1, ref string s2)
        {
            this.ShowDialog();
            s1 = nomPra;
            s2 = prenomPra;
        }

            private void c_typePra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_typePra.Text == "Médecin Hospitalier")
            {
                typePra = "MH";
            }
            else if(c_typePra.Text == "Médecine de Ville")
            {
                typePra = "MV";
            }
            else if(c_typePra.Text == "Pharmacien Hospitalier")
            {
                typePra = "PH";
            }
            else if (c_typePra.Text == "Pharmacien Officine")
            {
                typePra = "PO";
            }
            else if (c_typePra.Text == "Personnel de santé")
            {
                typePra = "PS";
            }
            else
            {
                typePra = null;
            }

            //t_test.Text = typePra;
        }

        private void t_notoriétéPra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
