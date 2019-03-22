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
        private string motDePasse;
        public VoirRapportVisite(string log, string mdp)
        {
            InitializeComponent();
            this.InitConnexion();

            login = log;
            motDePasse = mdp;

            MessageBox.Show(login);

        }
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connection = "SERVER=localhost; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";
            this.connection = new MySqlConnection(connection);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_numRapport.Items.Clear();
            c_numRapport.Text = "";
            l_date.Text = "";
            l_nomPrenomPraticien.Text = "";
            if (this.dataGridView1.DataSource != null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {
                this.dataGridView1.Rows.Clear();
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

            connection.Open();
            MySqlCommand SelectCommand3 = new MySqlCommand("select rap_num from rapport_visite where col_matricule="+"'"+l_numVisiteur.Text+"'"+";", connection);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            while (myReader3.Read())
            {
                c_numRapport.Items.Add(myReader3[0]);
            }
           
            connection.Close();
            







        }

        private void VoirRapportVisite_Load(object sender, EventArgs e)
        {
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
            

            connection.Open();
            MySqlCommand SelectCommand4 = new MySqlCommand("select rap_date from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);
            MySqlDataReader myReader4;
            myReader4 = SelectCommand4.ExecuteReader();
            while (myReader4.Read())
            {
                l_date.Text = myReader4.GetString(0);       
            }
            
            connection.Close();

            connection.Open();
            MySqlCommand SelectCommand5 = new MySqlCommand("select rap_bilan from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);
            MySqlDataReader myReader5;
            myReader5 = SelectCommand5.ExecuteReader();
            while (myReader5.Read())
            {
                l_bilan.Text = myReader5.GetString(0);
            }

            connection.Close();

            connection.Open();
            MySqlCommand SelectCommand6 = new MySqlCommand("select rap_motif from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);
            MySqlDataReader myReader6;
            myReader6 = SelectCommand6.ExecuteReader();
            while (myReader6.Read())
            {
                l_motif.Text = myReader6.GetString(0);
            }

            connection.Close();

            connection.Open();
            MySqlCommand SelectCommand7 = new MySqlCommand("select CONCAT(pra_nom,' ',pra_prenom) from praticien INNER JOIN rapport_visite on praticien.PRA_NUM = rapport_visite.PRA_NUM where rapport_visite.rap_num ="+"'"+c_numRapport.Text+"'"+"AND col_matricule="+"'"+l_numVisiteur.Text+"'"+";", connection);
            MySqlDataReader myReader7;
            myReader7 = SelectCommand7.ExecuteReader();
            while (myReader7.Read())
            {
                l_nomPrenomPraticien.Text = myReader7.GetString(0);
            }

            connection.Close();

            connection.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter("SELECT MED_DEPOTLEGAL AS Medicaments,OFF_QTE AS Quantite from offrir INNER JOIN rapport_visite on offrir.VIS_MATRICULE=rapport_visite.COL_MATRICULE where col_matricule="+"'"+l_numVisiteur.Text+"'"+"; ", connection);
            DataSet DS = new DataSet();
            MyDA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

           
            connection.Close();
            


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
            else
            {
                MessageBox.Show("Aucun praticien");
            }
            
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection(login, motDePasse);
            selection.Show();
            this.Close();
        }
    }
}
