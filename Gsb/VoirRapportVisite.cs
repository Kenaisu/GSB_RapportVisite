using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gsb
{
    public partial class VoirRapportVisite : Form
    {
        private MySqlConnection connection;
        private string login;
        private string natUser;
        private string col_matricule;
        private int numRapport;

        public VoirRapportVisite(string log,string natuser)
        {
            InitializeComponent();
            this.InitConnexion();
            login = log;
            natUser = natuser;

        }
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connection = "SERVER=localhost; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";
            this.connection = new MySqlConnection(connection);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            check_entre2Dates.Show();
            //check_entre2Dates.Checked = false;
            
            e_detailsPraticien.Clear();

            

            c_numRapport.Items.Clear();
            c_numRapport.Text = "";
            l_date.Text = "";
            l_nomPrenomPraticien.Text = "";
            l_bilan.Text = "";
            if (this.data_presente.DataSource != null)
            {
                this.data_presente.DataSource = null;
            }
            else
            {
                this.data_presente.Rows.Clear();
            }
            if (this.data_offert.DataSource != null)
            {
                this.data_offert.DataSource = null;
            }
            else
            {
                this.data_offert.Rows.Clear();
            }




            char[] splitters = new char[] { ' ' };
            string[] laCase = c_visiteur.Text.Split(splitters);
            l_nom.Text = (laCase[0]);
            l_prenom.Text = (laCase[1]);

            connection.Open();
            MySqlCommand SelectCommand2 = new MySqlCommand("select col_matricule from collaborateur where col_nom="+"'"+laCase[0]+"'"+";", connection);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                l_numVisiteur.Text = myReader2.GetString(0);
                
            }
            connection.Close();


            if (c_visiteur.Text == "Tous les visiteurs")
            {
                check_entre2Dates.Hide();
                date_debutDate.Hide();
                date_finDate.Hide();
                l_nom.Text = "";
                l_numVisiteur.Text = "";
                l_prenom.Text = "";
                check_entre2Dates.Show();


                connection.Open();
                MySqlCommand SelectCommand3 = new MySqlCommand("select Concat(collaborateur.col_nom,' ',collaborateur.col_prenom,' ',rap_num,' ',rap_date) from rapport_visite INNER JOIN collaborateur on rapport_visite.col_matricule=collaborateur.col_matricule;", connection);
                MySqlDataReader myReader3;
                myReader3 = SelectCommand3.ExecuteReader();
                while (myReader3.Read())
                {
                    c_numRapport.Items.Add(myReader3[0]);
                }
                connection.Close();
            }


            try
            {
                connection.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    numRapport = c_numRapport.Items.Add(myReader[0]);

                }
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void VoirRapportVisite_Load(object sender, EventArgs e)
        {
            date_finDate.Value = DateTime.Now.AddDays(1);
            b_supprimer.Hide();
            
            check_entre2Dates.Hide();
            date_debutDate.Hide();
            date_finDate.Hide();

            try
            {
                connection.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select concat(col_nom,' ',col_prenom) from collaborateur;", connection);

                MySqlDataReader myReader;
                
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    c_visiteur.Items.Add(myReader[0]);
                }
                connection.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            char[] splitters = new char[] { ' ' };
            string[] laCase = c_numRapport.Text.Split(splitters);


            if (natUser == "admin")
            {
                b_supprimer.Show();
            }
            
            e_detailsPraticien.Clear();

            if (c_visiteur.Text != "Tous les visiteurs")
            {
                connection.Open();
                MySqlCommand SelectCommand4 = new MySqlCommand("select rap_date,rap_bilan,rap_motif from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);
                MySqlDataReader myReader4;
                myReader4 = SelectCommand4.ExecuteReader();
                while (myReader4.Read())
                {
                    l_date.Text = myReader4["rap_date"].ToString();
                    DateTime datefin = DateTime.Parse(l_date.Text);
                    l_date.Text = datefin.ToString("dd-MM-yyyy");
                    l_bilan.Text = myReader4["rap_bilan"].ToString();
                    l_motif.Text = myReader4["rap_motif"].ToString();
                }

                connection.Close();


                connection.Open();
                MySqlCommand SelectCommand7 = new MySqlCommand("select CONCAT(pra_nom,' ',pra_prenom) from praticien INNER JOIN rapport_visite on praticien.PRA_NUM = rapport_visite.PRA_NUM where rapport_visite.rap_num =" + "'" + c_numRapport.Text + "'" + "AND col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);
                MySqlDataReader myReader7;
                myReader7 = SelectCommand7.ExecuteReader();
                while (myReader7.Read())
                {
                    l_nomPrenomPraticien.Text = myReader7.GetString(0);
                }

                connection.Close();

                connection.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter("SELECT MED_ID AS Medicaments,QUANTITE AS Quantite from distribuer INNER JOIN echantillon on distribuer.ECH_ID=echantillon.ECH_ID where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND OFFERT='1' "+";", connection);
                DataSet DS = new DataSet();
                MyDA.Fill(DS);
                data_offert.DataSource = DS.Tables[0];


                connection.Close();

                connection.Open();
                MySqlDataAdapter MyDA2 = new MySqlDataAdapter("SELECT MED_ID AS Medicaments from distribuer INNER JOIN echantillon on distribuer.ECH_ID = echantillon.ECH_ID where col_matricule = " + "'" + l_numVisiteur.Text + "'" + "AND PRESENTE='1' "+";", connection);
                DataSet DS2 = new DataSet();
                MyDA2.Fill(DS2);
                data_presente.DataSource = DS2.Tables[0];


                connection.Close();
            }
            else
            {
                
                connection.Open();
                MySqlCommand SelectCommand3 = new MySqlCommand("select col_matricule from collaborateur where col_nom="+"'"+laCase[0]+"'"+" AND col_prenom="+"'"+laCase[1]+"'"+";", connection);
                MySqlDataReader myReader3;
                myReader3 = SelectCommand3.ExecuteReader();
                while (myReader3.Read())
                {
                    col_matricule = myReader3.GetString(0);
                }

                connection.Close();

                connection.Open();
                MySqlCommand SelectCommand4 = new MySqlCommand("select rap_date,rap_bilan,rap_motif from rapport_visite where col_matricule=" + "'" + col_matricule + "'" + "AND rap_num=" + "'" + laCase[2] + "'" + ";", connection);
                MySqlDataReader myReader4;
                myReader4 = SelectCommand4.ExecuteReader();
                while (myReader4.Read())
                {
                    l_date.Text = myReader4["rap_date"].ToString();
                    DateTime datefin = DateTime.Parse(l_date.Text);
                    l_date.Text = datefin.ToString("dd-MM-yyyy");
                    l_bilan.Text = myReader4["rap_bilan"].ToString();
                    l_motif.Text = myReader4["rap_motif"].ToString();
                }

                connection.Close();


                connection.Open();
                MySqlCommand SelectCommand7 = new MySqlCommand("select CONCAT(pra_nom,' ',pra_prenom) from praticien INNER JOIN rapport_visite on praticien.PRA_NUM = rapport_visite.PRA_NUM where rapport_visite.rap_num =" + "'" + laCase[2] + "'" + "AND col_matricule=" + "'" + col_matricule+ "'" + ";", connection);
                MySqlDataReader myReader7;
                myReader7 = SelectCommand7.ExecuteReader();
                while (myReader7.Read())
                {
                    l_nomPrenomPraticien.Text = myReader7.GetString(0);
                }

                connection.Close();

                connection.Open();
                MySqlDataAdapter MyDA3 = new MySqlDataAdapter("SELECT MED_ID AS Medicaments,QUANTITE AS Quantite from distribuer INNER JOIN echantillon on distribuer.ECH_ID=echantillon.ECH_ID where col_matricule=" + "'" + col_matricule + "'" + "AND OFFERT=1" + ";", connection);
                DataSet DS3 = new DataSet();
                MyDA3.Fill(DS3);
                data_offert.DataSource = DS3.Tables[0];


                connection.Close();

                connection.Open();
                MySqlDataAdapter MyDA4 = new MySqlDataAdapter("SELECT MED_ID AS Medicaments from distribuer INNER JOIN echantillon on distribuer.ECH_ID = echantillon.ECH_ID where col_matricule = " + "'" + col_matricule + "'" + "AND PRESENTE=1" + ";", connection);
                DataSet DS4 = new DataSet();
                MyDA4.Fill(DS4);
                data_presente.DataSource = DS4.Tables[0];


                connection.Close();
            }
            
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (l_nomPrenomPraticien.Text != "")
            {
                string nomprafin;
                nomprafin = l_nomPrenomPraticien.Text;
                DetailsPraticien DP = new DetailsPraticien(nomprafin);
                DP.Show();

            }
            else if (string.IsNullOrWhiteSpace(l_nomPrenomPraticien.Text))
            {
                e_detailsPraticien.SetError(b_details, "Pas de praticien choisi");
            }
            
        }

        private void b_retour_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Selection S3 = new Selection(login, "", "responsable");
            S3.Show();
            this.Hide();
        }

        private void b_supprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (c_numRapport.Text != "")
                {
                    DialogResult result1 = MessageBox.Show("Etes vous sur de vouloir supprimer ce rapport ? ", "Suppresion d'un rapport", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        connection.Open();
                        MySqlCommand SelectCommand2 = new MySqlCommand("delete from rapport_visite where col_matricule=" + "'" + col_matricule + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);

                        MySqlDataReader myReader2;

                        myReader2 = SelectCommand2.ExecuteReader();

                        connection.Close();

                        MessageBox.Show("La suppresion a réussi !");

                        l_bilan.Text = " ";
                        l_motif.Text = " ";
                        c_numRapport.Items.Clear();
                        c_numRapport.Text = "";
                        l_date.Text = "";
                        l_nomPrenomPraticien.Text = "";
                        if (this.data_presente.DataSource != null)
                        {
                            this.data_presente.DataSource = null;
                        }
                        else
                        {
                            this.data_presente.Rows.Clear();
                        }
                        if (this.data_offert.DataSource != null)
                        {
                            this.data_offert.DataSource = null;
                        }
                        else
                        {
                            this.data_offert.Rows.Clear();
                        }
                    }
                }
                else
                {
                   MessageBox.Show("Pas de numéro de rapport choisi");
                }




                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void check_entre2Dates_CheckedChanged(object sender, EventArgs e)
        {
            if (check_entre2Dates.Checked)
            {
                date_debutDate.Show();
                date_finDate.Show();

                c_numRapport.Items.Clear();

                e_detailsPraticien.Clear();


                l_motif.Text = "";
                l_bilan.Text = "";

                l_date.Text = "";
                l_nomPrenomPraticien.Text = "";

                if (this.data_presente.DataSource != null)
                {
                    this.data_presente.DataSource = null;
                }
                else
                {
                    this.data_presente.Rows.Clear();
                }
                if (this.data_offert.DataSource != null)
                {
                    this.data_offert.DataSource = null;
                }
                else
                {
                    this.data_offert.Rows.Clear();
                }

            }
            else if (check_entre2Dates.Checked == false && c_visiteur.Text == "Tous les visiteurs")
            {
                c_numRapport.Items.Clear();
                connection.Open();
                MySqlCommand SelectCommand3 = new MySqlCommand("select Concat(collaborateur.col_nom,' ',collaborateur.col_prenom,' ',rap_num,' ',rap_date) from rapport_visite INNER JOIN collaborateur on rapport_visite.col_matricule=collaborateur.col_matricule;", connection);
                MySqlDataReader myReader3;
                myReader3 = SelectCommand3.ExecuteReader();
                while (myReader3.Read())
                {
                    c_numRapport.Items.Add(myReader3[0]);
                }
                connection.Close();

                date_debutDate.Hide();
                date_finDate.Hide();

                e_detailsPraticien.Clear();



                l_motif.Text = "";
                l_bilan.Text = "";

                l_date.Text = "";
                l_nomPrenomPraticien.Text = "";

                if (this.data_presente.DataSource != null)
                {
                   this.data_presente.DataSource = null;
                }
                else
                {
                   this.data_presente.Rows.Clear();
                }
                if (this.data_offert.DataSource != null)
                {
                    this.data_offert.DataSource = null;
                }
                else
                {
                    this.data_offert.Rows.Clear();
                }


            }
            else
            {
                date_debutDate.Hide();
                date_finDate.Hide();

                e_detailsPraticien.Clear();


                l_motif.Text = "";
                l_bilan.Text = "";

                c_numRapport.Items.Clear();

                l_date.Text = "";
                l_nomPrenomPraticien.Text = "";

                if (this.data_presente.DataSource != null)
                {
                    this.data_presente.DataSource = null;
                }
                else
                {
                    this.data_presente.Rows.Clear();
                }
                if (this.data_offert.DataSource != null)
                {
                    this.data_offert.DataSource = null;
                }
                else
                {
                    this.data_offert.Rows.Clear();
                }


                try
                {
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void date_finDate_ValueChanged(object sender, EventArgs e)
        {
            if (date_finDate.Value < date_debutDate.Value)
            {
                date_finDate.Value = DateTime.Now;
                MessageBox.Show("La deuxième date ne peut pas avant la première date");
            }

            c_numRapport.Items.Clear();
            c_numRapport.Text = "";

            if (c_visiteur.Text != "Tous les visiteurs")
            {
                try
                {

                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        
                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    
                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select Concat(col_nom,' ',col_prenom,' ',rap_num,' ',rap_date) from rapport_visite INNER JOIN collaborateur on rapport_visite.col_matricule=collaborateur.col_matricule where RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + ";", connection);
                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        
                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void date_debutDate_ValueChanged(object sender, EventArgs e)
        {
            

            if (date_debutDate.Value > date_finDate.Value)
            {
                date_debutDate.Value = DateTime.Now ;
                MessageBox.Show("La première date ne peut pas après la deuxiéme date");
            }
            c_numRapport.Items.Clear();
            c_numRapport.Text = "";

            if (c_visiteur.Text != "Tous les visiteurs")
            {
                try
                {

                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    
                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select Concat(col_nom,' ',col_prenom,' ',rap_num,' ',rap_date) from rapport_visite INNER JOIN collaborateur on rapport_visite.col_matricule=collaborateur.col_matricule where RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
