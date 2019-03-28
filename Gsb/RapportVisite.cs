using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gsb
{
    public partial class RapportVisite : Form
    {
        string chaineConnexion = "datasource=127.0.0.1;port=3306;Database=applicationppe;username=root;password=;SslMode=none";
        private string login;
        private string motDePasse;

        string nomPraticien;

        string codeVisiteur;
        int rapNum;
        DateTime rapDate = DateTime.Today;
        string rapBilan;
        string rapMotif;
        string rapConn;
        string rapConf;
        DateTime rapDateVisite;
        DateTime rapDateFuturVisite;
        int rapConc;
        int praNum;

        string str1 = null;
        string str2 = null;

        public RapportVisite(string log, string mdp)
        {
            InitializeComponent();

            login = log;
            motDePasse = mdp;

            //t_numRapport.Text = Nom;
            //textBox2.Text = Prenom;

            //t_numRapport.Enabled = false;
            t_codeVisiteur.Enabled = false;
            date_futurVisite.Hide();
            l_newMotif.Hide();
            t_newMotif.Hide();


            ///////////////////////////////////////////
            ///Remplissage combobox
            ///////////////////////////////////////////
            string selectPraticien = "select concat(PRA_NOM, ' ',PRA_PRENOM) as Pra_nom from praticien";
            CURS css = new CURS(chaineConnexion);
            css.ReqSelect(selectPraticien);

            while (!css.Fin())
            {
                c_praticien.Items.Add(css.champ("Pra_nom"));
                css.suivant();
            }
            css.fermer();


            string selectMotifVisite = "select DISTINCT RAP_MOTIF from rapport_visite";
            CURS connexionMotif = new CURS(chaineConnexion);
            connexionMotif.ReqSelect(selectMotifVisite);

            while (!connexionMotif.Fin())
            {
                c_motif.Items.Add(connexionMotif.champ("RAP_MOTIF"));
                connexionMotif.suivant();
            }
            connexionMotif.fermer();

            ///////////////////////////////////////////
            ///Remplissage data Grid (tableau medicament et echantillons)
            ///////////////////////////////////////////
            //string selectMedicament = "select MED_DEPOTLEGAL, MED_NOMCOMMERCIAL from medicament";
            string selectMedicament = "select concat(MED_DEPOTLEGAL, ' ', MED_NOMCOMMERCIAL) as nomMedicament from medicament";
            CURS connexionMedic = new CURS(chaineConnexion);
            connexionMedic.ReqSelect(selectMedicament);

            while (!connexionMedic.Fin())
            {
                //depot_legalMedi.Items.Add(connexionMedic.champ("MED_DEPOTLEGAL"));

                //depot_legalEchan.Items.Add(connexionMedic.champ("MED_DEPOTLEGAL"));

                medicamentMedi.Items.Add(connexionMedic.champ("nomMedicament"));

                medicamentEchan.Items.Add(connexionMedic.champ("nomMedicament"));

                connexionMedic.suivant();
            }
            connexionMedic.fermer();
            ///////////////////////////////////////////

            //string codeVisiteur= "";

            //login = "Andre";
            //motDePasse = "1991-08-26";

            string selectCodeVisiteur = "select COL_MATRICULE from collaborateur where COL_NOM =" + "'" + login + "'" + " AND COL_DATEEMBAUCHE =" + "'" + motDePasse + "'" + ";";



            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect(selectCodeVisiteur);

            codeVisiteur = cs.champ("COL_MATRICULE").ToString();

            t_codeVisiteur.Text = codeVisiteur;

            cs.fermer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c_praticien.Text = "";
            date_visite.Text = "";
            //t_motif.Text = "";
            t_bilan.Text = "";
            c_connaissance.Text = "";
            c_confiance.Text = "";
            c_concu.Text = "";
            check_futurVisite.Checked = false;
            date_futurVisite.Text = "";
            t_newMotif.Text = "";
            //depot_legalMedi.Items.Clear();
            /*
            if (this.tab_medic.DataSource != null)
            {
                this.tab_medic.DataSource = null;
            }
            else
            {
                //this.tab_medic.Rows.Clear();
            }*/
            //tab_medic.Rows.Clear();

            if (tab_medic.DataSource != null)
            {
                MessageBox.Show("yes or no no no");
            }

            //this.tab_medic.Rows.Clear();

            //depot_legalEchan.Clear();
            //depot_legalEchan.Items.Remove.
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void t_numRapport_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_praticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //string nom = "";
            nomPraticien = c_praticien.SelectedItem.ToString();




            //CURS cs = new CURS(chaineConnexion);

            //cs.DefFonctStockee("P1");

            //cs.ajouteparametreCol("Pra_nom", codePraticien);
            //cs.directionparametreCol("codeLivre", ParameterDirection.Input);

            /*cs.ajouteparametreCol("fullName", nom);
            cs.directionparametreCol("fullName", ParameterDirection.Output);*/

            //cs.Appelfonctstockee();
            //test_label.Text = Convert.ToString(cs.getCol()[1].Value);


            //

            //ajouter gestion de nouveau praticien
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        /*
        private void creation_rapport()
        {
            ///////////////////////////////////////////
            ///Initialisation numero de rapport
            ///////////////////////////////////////////
            try
            {
                string selectlastNumRap = "select max(RAP_NUM) as lastNumRap from rapport_visite where COL_MATRICULE = " + "'" + codeVisiteur + "'";
                CURS connexionNumRap = new CURS(chaineConnexion);
                connexionNumRap.ReqSelect(selectlastNumRap);
                
                rapNum = Convert.ToInt32(connexionNumRap.champ("lastNumRap"));
                rapNum = rapNum + 1;
                connexionNumRap.fermer();
                MessageBox.Show("recup num rap dans bdd");
            }
            catch
            {
                rapNum = 1;
                MessageBox.Show("recup num a 1");
            }


            ///////////////////////////////////////////
            ///Modification date du jour du rapport pour correspondre a MariaDB ou MySQL
            ///////////////////////////////////////////
            string rapDate2 = rapDate.ToString("yyyy-MM-dd");

            ///////////////////////////////////////////
            ///Récupération bilan
            ///////////////////////////////////////////
            rapBilan = t_bilan.Text;

            ///////////////////////////////////////////
            ///Récupération motif
            ///////////////////////////////////////////
            if (c_motif.Text == "Autre motif")
            {
                rapMotif = t_newMotif.Text;
            }
            else
            {
                rapMotif = c_motif.Text;
            }

            ///////////////////////////////////////////
            ///Récupération connaissance
            ///////////////////////////////////////////
            if (c_connaissance.Text != "Je ne sais pas")
            {
                rapConn = c_connaissance.Text;
            }
            else
            {
                rapConn = null;
            }

            ///////////////////////////////////////////
            ///Récupération confiance
            ///////////////////////////////////////////
            if (c_confiance.Text != "Je ne sais pas")
            {
                rapConf = c_confiance.Text;
            }
            else
            {
                rapConf = null;
            }

            ///////////////////////////////////////////
            ///Récupération date visite
            ///////////////////////////////////////////
            rapDateVisite = date_visite.Value;
            string rapDateVisite2 = rapDateVisite.ToString("yyyy-MM-dd");

            //////////////////////////////////////////
            ///Récupération date prochaine visite
            ///////////////////////////////////////////
            rapDateFuturVisite = default(DateTime);
            string rapDateFuturVisite2 = rapDateFuturVisite.ToString("yyyy-MM-dd");

            if (check_futurVisite.Checked)
            {
                rapDateFuturVisite = date_futurVisite.Value;
                rapDateFuturVisite2 = rapDateFuturVisite.ToString("yyyy-MM-dd");
            }

            ///////////////////////////////////////////
            ///Récupération concurence
            ///////////////////////////////////////////
            if (c_concu.Text == "oui")
            {
                rapConc = 1;
            }
            else
            {
                rapConc = 0;
            }

            ///////////////////////////////////////////
            ///Récupération numéro praticien
            ///////////////////////////////////////////
            if (c_praticien.Text == "Nouveau Praticien")
            {

            }
            else
            {
                string selectPraticien = "select PRA_NUM from praticien where concat(PRA_NOM, ' ',PRA_PRENOM)=" + "'" + nomPraticien + "'" + ";";
                CURS connexionPraticien = new CURS(chaineConnexion);
                connexionPraticien.ReqSelect(selectPraticien);

                //string COL_MATRICULE = connexionPraticien.champ("COL_MATRICULE").ToString();
                //praNum = Convert.ToInt32(COL_MATRICULE);
                //string COL_MATRICULE = connexionPraticien.champ("COL_MATRICULE").ToString();
                praNum = Convert.ToInt32(connexionPraticien.champ("PRA_NUM"));
                connexionPraticien.fermer();
            }



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////
            ///Insertion du rapport de visite dans la BDD
            /////////////////////////////////////////// 
            string insertRapport = "INSERT INTO rapport_visite(COL_MATRICULE, RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, RAP_CONNAISSANCE_PRACTICIEN, RAP_CONFIANCE_LABO, RAP_DATE_VISITE, RAP_DATE_PROCHAINE_VISITE, RAP_PRESENCE_CONCURENCE, PRA_NUM)" +
            " VALUES(" + "'" + codeVisiteur + "'" + "," + rapNum + "," + "'" + rapDate2 + "'" + "," + "'" + rapBilan + "'" + "," + "'" + rapMotif + "'" + "," + rapConn + "," + rapConf + "," + "'" + rapDateVisite2 + "'" + "," + "'" + rapDateFuturVisite2 + "'" + "," + rapConc + "," + praNum + ")";



            CURS connexionInsertRap = new CURS(chaineConnexion);
            connexionInsertRap.ReqAdmin(insertRapport);

            connexionInsertRap.fermer();




            /*
             insertion des echantllons donné et des médicaments présenté

            */
            /*
            MessageBox.Show("Code visiteur : " + codeVisiteur + " Rapport numero :" + rapNum + " Date rapport : "+ rapDate2 + " Rapport bilan : " + rapBilan + " Rapport motif : " + rapMotif + 
            " Connaissance: " + rapConn + " Confiance : " + rapConf + " Date visite : " + rapDateVisite + " Date prochaine visite : " + rapDateFuturVisite + " Présence concurence : " + rapConc + " Numéro praticien : " + praNum);
            */
            /*
            MessageBox.Show("gestion medicaments présentés");

            MessageBox.Show("gestion echantillons offerts");

            //fermeture du formulaire.
/*
        }
        */
        private void b_createRapport_Click(object sender, EventArgs e)
        {
            //
            //if (c_motif.Text == "Autre motif" && string.IsNullOrWhiteSpace(t_newMotif.Text)) = error
            //
            if ((/*!string.IsNullOrWhiteSpace(c_motif.Text)*/ c_motif.Text != "Autre motif") || (c_motif.Text == "Autre motif" && !string.IsNullOrWhiteSpace(t_newMotif.Text)))
            {
                //ajouter verification des medicaments
                if (tab_medic.Rows[0].Cells[0].Value != null || tab_echan.Rows[0].Cells[0].Value != null && tab_echan.Rows[0].Cells[1].Value != null)
                {
                    if (!string.IsNullOrWhiteSpace(t_codeVisiteur.Text) && !string.IsNullOrWhiteSpace(c_praticien.Text) && !string.IsNullOrWhiteSpace(c_motif.Text) && !string.IsNullOrWhiteSpace(t_bilan.Text) && !string.IsNullOrWhiteSpace(c_connaissance.Text) && !string.IsNullOrWhiteSpace(c_confiance.Text) && !string.IsNullOrWhiteSpace(c_concu.Text))
                    {
                        /*if(c_motif == Autre motif)
                        {*/

                        ;
                        /*
                        if (c_praticien.Text == "Nouveau Praticien")
                        {
                            AjouterPraticien newPraticien = new AjouterPraticien();
                            //newPraticien.Show();
                            //this.Hide();

                            newPraticien.saisie(ref str1, ref str2);

                            MessageBox.Show(str1 + " " + str2);

                            string selectlastNumRap = "select PRA_NUM from praticien where PRA_NOM = " + "'" + codeVisiteur + "'" + "AND PRA_PRENOM = " + "'" + codeVisiteur + "'" + ";";
                            CURS connexionNumPra = new CURS(chaineConnexion);
                            connexionNumPra.ReqSelect(selectlastNumRap);

                            //string lastNumRap = connexionNumRap.champ("lastNumRap").ToString();
                            praNum = Convert.ToInt32(connexionNumPra.champ("PRA_NUM"));
                        
                            connexionNumPra.fermer();
                        }
                        else
                        {*/
                        /* deja initialisé
                        codeVisiteur = t_codeVisiteur.Text;
                        */

                        ///////////////////////////////////////////
                        ///Initialisation numero de rapport
                        ///////////////////////////////////////////
                        try
                        {
                            string selectlastNumRap = "select max(RAP_NUM) as lastNumRap from rapport_visite where COL_MATRICULE = " + "'" + codeVisiteur + "'";
                            CURS connexionNumRap = new CURS(chaineConnexion);
                            connexionNumRap.ReqSelect(selectlastNumRap);

                            //string lastNumRap = connexionNumRap.champ("lastNumRap").ToString();
                            rapNum = Convert.ToInt32(connexionNumRap.champ("lastNumRap"));
                            rapNum = rapNum + 1;
                            connexionNumRap.fermer();
                            //MessageBox.Show("recup num rap dans bdd");
                        }
                        catch
                        {
                            rapNum = 1;
                            //MessageBox.Show("recup num a 1");
                        }


                        ///////////////////////////////////////////
                        ///Modification date du jour du rapport pour correspondre a MariaDB ou MySQL
                        ///////////////////////////////////////////
                        string rapDate2 = rapDate.ToString("yyyy-MM-dd");

                        ///////////////////////////////////////////
                        ///Récupération bilan
                        ///////////////////////////////////////////
                        rapBilan = t_bilan.Text;

                        ///////////////////////////////////////////
                        ///Récupération motif
                        ///////////////////////////////////////////
                        if (c_motif.Text == "Autre motif")
                        {
                            rapMotif = t_newMotif.Text;
                        }
                        else
                        {
                            rapMotif = c_motif.Text;
                        }

                        ///////////////////////////////////////////
                        ///Récupération connaissance
                        ///////////////////////////////////////////
                        if (c_connaissance.Text != "Je ne sais pas")
                        {
                            rapConn = c_connaissance.Text;
                        }
                        else
                        {
                            rapConn = "null";
                        }

                        ///////////////////////////////////////////
                        ///Récupération confiance
                        ///////////////////////////////////////////
                        if (c_confiance.Text != "Je ne sais pas")
                        {
                            rapConf = c_confiance.Text;
                        }
                        else
                        {
                            rapConf = "null";
                        }

                        ///////////////////////////////////////////
                        ///Récupération date visite
                        ///////////////////////////////////////////
                        rapDateVisite = date_visite.Value;
                        string rapDateVisite2 = rapDateVisite.ToString("yyyy-MM-dd");

                        //////////////////////////////////////////
                        ///Récupération date prochaine visite
                        ///////////////////////////////////////////
                        rapDateFuturVisite = default(DateTime);
                        string rapDateFuturVisite2 = rapDateFuturVisite.ToString("yyyy-MM-dd");

                        if (check_futurVisite.Checked)
                        {
                            rapDateFuturVisite = date_futurVisite.Value;
                            rapDateFuturVisite2 = rapDateFuturVisite.ToString("yyyy-MM-dd");
                        }

                        ///////////////////////////////////////////
                        ///Récupération concurence
                        ///////////////////////////////////////////
                        if (c_concu.Text == "oui")
                        {
                            rapConc = 1;
                        }
                        else
                        {
                            rapConc = 0;
                        }

                        ///////////////////////////////////////////
                        ///Récupération numéro praticien
                        ///////////////////////////////////////////
                        if (c_praticien.Text == "Nouveau Praticien")
                        {
                            AjouterPraticien newPraticien = new AjouterPraticien();
                            //newPraticien.Show();
                            //this.Hide();

                            newPraticien.saisie(ref str1, ref str2);

                            MessageBox.Show(str1 + " " + str2);

                            string selectlastNumRap = "select PRA_NUM from praticien where PRA_NOM = " + "'" + str1 + "'" + "AND PRA_PRENOM = " + "'" + str2 + "'" + ";";
                            CURS connexionNumPra = new CURS(chaineConnexion);
                            connexionNumPra.ReqSelect(selectlastNumRap);

                            //string lastNumRap = connexionNumRap.champ("lastNumRap").ToString();
                            praNum = Convert.ToInt32(connexionNumPra.champ("PRA_NUM"));
                            connexionNumPra.fermer();
                            MessageBox.Show("num du praticien" + praNum);
                        }
                        else
                        {
                            string selectPraticien = "select PRA_NUM from praticien where concat(PRA_NOM, ' ',PRA_PRENOM)=" + "'" + nomPraticien + "'" + ";";
                            CURS connexionPraticien = new CURS(chaineConnexion);
                            connexionPraticien.ReqSelect(selectPraticien);

                            //string COL_MATRICULE = connexionPraticien.champ("COL_MATRICULE").ToString();
                            //praNum = Convert.ToInt32(COL_MATRICULE);
                            //string COL_MATRICULE = connexionPraticien.champ("COL_MATRICULE").ToString();
                            praNum = Convert.ToInt32(connexionPraticien.champ("PRA_NUM"));
                            connexionPraticien.fermer();
                        }



                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                        //////////////////////////////////////////////////////////////////////////////////////
                        ///Insertion du rapport de visite dans la BDD
                        ////////////////////////////////////////////////////////////////////////////////////// 
                        string insertRapport = "INSERT INTO rapport_visite(COL_MATRICULE, RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, RAP_CONNAISSANCE_PRACTICIEN, RAP_CONFIANCE_LABO, RAP_DATE_VISITE, RAP_DATE_PROCHAINE_VISITE, RAP_PRESENCE_CONCURENCE, PRA_NUM)" +
                        " VALUES(" + "'" + codeVisiteur + "'" + "," + rapNum + "," + "'" + rapDate2 + "'" + "," + "'" + rapBilan + "'" + "," + "'" + rapMotif + "'" + "," + rapConn + "," + rapConf + "," + "'" + rapDateVisite2 + "'" + "," + "'" + rapDateFuturVisite2 + "'" + "," + rapConc + "," + praNum + ")";



                        CURS connexionInsertRap = new CURS(chaineConnexion);
                        connexionInsertRap.ReqAdmin(insertRapport);

                        connexionInsertRap.fermer();




                        /*
                         insertion des echantllons donné et des médicaments présenté

                        */
                        /*
                        MessageBox.Show("Code visiteur : " + codeVisiteur + " Rapport numero :" + rapNum + " Date rapport : "+ rapDate2 + " Rapport bilan : " + rapBilan + " Rapport motif : " + rapMotif + 
                        " Connaissance: " + rapConn + " Confiance : " + rapConf + " Date visite : " + rapDateVisite + " Date prochaine visite : " + rapDateFuturVisite + " Présence concurence : " + rapConc + " Numéro praticien : " + praNum);
                        */

                        //MessageBox.Show("gestion medicaments présentés");

                        //MessageBox.Show("gestion echantillons offerts");
                        //////////////////////////////////////////////////////////////////////////////////////
                        ///Insertion des medicaments et echantillons dans la BDD (table distribuer)
                        //////////////////////////////////////////////////////////////////////////////////////
                        for (int i = 0; i < tab_medic.Rows.Count - 1; i++)
                        {
                            var value = tab_medic.Rows[i].Cells[0].Value;
                            string input = value.ToString();
                            int index = input.IndexOf(" ");
                            if (index > 0)
                                input = input.Substring(0, index);
                            //input = ref du produit
                            //MessageBox.Show(input);

                            CURS connexionInsertMedic = new CURS(chaineConnexion);
                            connexionInsertMedic.DefFonctStockee("medicaments_d_un_rapport");

                            connexionInsertMedic.ajouteparametreCol("refMedic", input);
                            connexionInsertMedic.directionparametreCol("refMedic", ParameterDirection.Input);

                            connexionInsertMedic.ajouteparametreCol("codeCollab", codeVisiteur);
                            connexionInsertMedic.directionparametreCol("codeCollab", ParameterDirection.Input);

                            connexionInsertMedic.ajouteparametreCol("rapNum", rapNum);
                            connexionInsertMedic.directionparametreCol("rapNum", ParameterDirection.Input);

                            connexionInsertMedic.Appelfonctstockee();
                            connexionInsertMedic.fermer();
                        }

                        for (int i = 0; i < tab_echan.Rows.Count - 1; i++)
                        {
                            var value = tab_echan.Rows[i].Cells[0].Value;
                            string input = value.ToString();
                            int index = input.IndexOf(" ");
                            if (index > 0)
                                input = input.Substring(0, index);

                            var quant = tab_echan.Rows[i].Cells[1].Value;
                            int quantite = Convert.ToInt32(quant);//.ToString();

                            //input = ref du produit
                            //MessageBox.Show(input);

                            CURS connexionInsertEchan = new CURS(chaineConnexion);
                            connexionInsertEchan.DefFonctStockee("echantillons_d_un_rapport");

                            connexionInsertEchan.ajouteparametreCol("refMedic", input);
                            connexionInsertEchan.directionparametreCol("refMedic", ParameterDirection.Input);

                            connexionInsertEchan.ajouteparametreCol("codeCollab", codeVisiteur);
                            connexionInsertEchan.directionparametreCol("codeCollab", ParameterDirection.Input);

                            connexionInsertEchan.ajouteparametreCol("rapNum", rapNum);
                            connexionInsertEchan.directionparametreCol("rapNum", ParameterDirection.Input);

                            connexionInsertEchan.ajouteparametreCol("nbOffert", quantite);
                            connexionInsertEchan.directionparametreCol("nbOffert", ParameterDirection.Input);

                            connexionInsertEchan.Appelfonctstockee();
                            connexionInsertEchan.fermer();
                        }
                        //////////////////////////////////////////////////////////////////////////////////////
                        ///Fermeture du formulaire et ouverture de menu de selection
                        //////////////////////////////////////////////////////////////////////////////////////
                        MessageBox.Show("Rapport de visite créé.");

                        Selection selection = new Selection(login, motDePasse);
                        selection.Show();
                        this.Close();
                        //fermeture du formulaire.
                        //}
                        //}
                    }
                    else
                    {
                        //MessageBox.Show("Veuillez renseignez toutes les informations.");
                        errorCreate.SetError(b_createRapport, "Veuillez renseignez toutes les informations.");
                    }
                }
                else
                {
                    errorCreate.SetError(b_createRapport, "Veuillez renseignez au moins un médicament ou échantillon.");
                }
            }
            else
            {
                errorCreate.SetError(b_createRapport, "Veuillez renseignez un nouveau motif.");
            }

        }

        private void t_codeVisiteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_futurVisite.Checked)
            {
                date_futurVisite.Show();
            }
            else
            {
                date_futurVisite.Hide();
            }
        }

        private void b_checkPraticien_Click(object sender, EventArgs e)
        {
            if(c_praticien.Text == "Nouveau Praticien")
            {                
                errorDetailPra.SetError(b_checkPraticien, "Vous ne pouvez pas obtenir de détails sur ce praticien car il n'est pas encore ajouté.");
            }
            else if(c_praticien.Text != "")
            {   
                
                string nomprafin;
                nomprafin = c_praticien.Text;
                DetailsPraticien DP = new DetailsPraticien(nomprafin);
                DP.Show();
            }
            else
            {                
                errorDetailPra.SetError(b_checkPraticien, "Aucun praticien séléctionné.");
            }
        }

        //private void b_close_Click(object sender, EventArgs e, string login, string motDePasse)
        private void b_close_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection(login, motDePasse);
            selection.Show();
            this.Close();
        }

        private void RapportVisite_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            Selection selection = new Selection(login, motDePasse);
            selection.Show();
            this.Close();
            */
        }

        private void c_motif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(c_motif.Text == "Autre motif")
            {
                l_newMotif.Show();
                t_newMotif.Show();
            }
            else
            {
                l_newMotif.Hide();
                t_newMotif.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_test_Click(object sender, EventArgs e)
        {
            /* ça marche
            string input = "HDEU4H test detruc";
            int index = input.IndexOf(" ");
            if (index > 0)
                input = input.Substring(0, index);
            */

            /*
            //MessageBox.Show(lbl_row);
            var value = tab_medic.Rows[0].Cells[0].Value;
            MessageBox.Show(tab_medic.Rows.Count.ToString());

            string input = value.ToString();
            int index = input.IndexOf(" ");
            if (index > 0)
                input = input.Substring(0, index);

            */
            //MessageBox.Show(value.ToString());
            //MessageBox.Show(input);

            for (int i = 0; i < tab_medic.Rows.Count - 1; i++)
            {
                var value = tab_medic.Rows[i].Cells[0].Value;
                string input = value.ToString();
                int index = input.IndexOf(" ");
                if (index > 0)
                    input = input.Substring(0, index);
                //input = ref du produit
                MessageBox.Show(input);                               

                CURS connexionInsertMedic = new CURS(chaineConnexion);
                connexionInsertMedic.DefFonctStockee("medicaments_d_un_rapport");

                connexionInsertMedic.ajouteparametreCol("refMedic", input);
                connexionInsertMedic.directionparametreCol("refMedic", ParameterDirection.Input);

                connexionInsertMedic.ajouteparametreCol("codeCollab", "a17");
                connexionInsertMedic.directionparametreCol("codeCollab", ParameterDirection.Input);

                connexionInsertMedic.ajouteparametreCol("rapNum", 5);
                connexionInsertMedic.directionparametreCol("rapNum", ParameterDirection.Input);

                connexionInsertMedic.Appelfonctstockee();
                connexionInsertMedic.fermer();
            }

            for (int i = 0; i < tab_echan.Rows.Count - 1; i++)
            {
                var value = tab_echan.Rows[i].Cells[0].Value;
                string input = value.ToString();
                int index = input.IndexOf(" ");
                if (index > 0)
                    input = input.Substring(0, index);

                var quant = tab_echan.Rows[i].Cells[1].Value;
                int quantite = Convert.ToInt32(quant);//.ToString();

                //input = ref du produit
                MessageBox.Show(input);

                CURS connexionInsertEchan = new CURS(chaineConnexion);
                connexionInsertEchan.DefFonctStockee("echantillons_d_un_rapport");

                connexionInsertEchan.ajouteparametreCol("refMedic", input);
                connexionInsertEchan.directionparametreCol("refMedic", ParameterDirection.Input);

                connexionInsertEchan.ajouteparametreCol("codeCollab", "a17");
                connexionInsertEchan.directionparametreCol("codeCollab", ParameterDirection.Input);

                connexionInsertEchan.ajouteparametreCol("rapNum", 5);
                connexionInsertEchan.directionparametreCol("rapNum", ParameterDirection.Input);

                connexionInsertEchan.ajouteparametreCol("nbOffert", quantite);
                connexionInsertEchan.directionparametreCol("nbOffert", ParameterDirection.Input);

                connexionInsertEchan.Appelfonctstockee();
                connexionInsertEchan.fermer();
            }

            //MessageBox.Show("gestion echantillons offerts");

            //string lbl_row.Text = tab_medic.RowCount.ToString();



        }

        private void c_connaissance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
