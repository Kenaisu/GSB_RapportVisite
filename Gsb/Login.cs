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
    public partial class Login : Form
    {        
        private MySqlConnection connection;
        private string col_matlogin3;
        private string col_matlogin4;

        public Login()
        {
            InitializeComponent();
            this.InitConnexion();
        }
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connection = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";
            this.connection = new MySqlConnection(connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (t_login.Text != "")
            {
                error_login.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_login.Text))
            {
                error_login.SetError(t_login, "Le champ login n'est pas complet");
            }
            if (string.IsNullOrWhiteSpace(t_mdp.Text))
            {
                error_mdp.SetError(t_mdp, "Le champ mot de passe n'est pas complet");
            }
            else if (string.IsNullOrWhiteSpace(t_login.Text) && string.IsNullOrWhiteSpace(t_mdp.Text))
            {
                error_mdp.SetError(t_mdp, "Le champ mot de passe n'est pas complet");
                error_login.SetError(t_login, "Le champ login n'est pas complet");
            }

            try
            {
                string natUser;

                connection.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from collaborateur where COL_NOM='" + this.t_login.Text + "' and DATE_FORMAT(COL_DATEEMBAUCHE, '%Y-%b-%d')='" + t_mdp.Text + "' ;", connection);

                MySqlDataReader myReader;                
                myReader = SelectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    connection.Close();

                    string col_matlogin = "";
                    connection.Open();
                    MySqlDataReader myReader2;
                    MySqlCommand SelectCommand2 = new MySqlCommand("Select col_matricule from collaborateur where COL_NOM='" + this.t_login.Text + "' and DATE_FORMAT(COL_DATEEMBAUCHE, '%Y-%b-%d')='" + t_mdp.Text + "' ;", connection);
                    myReader2 = SelectCommand2.ExecuteReader();
                    while (myReader2.Read())
                    {
                        col_matlogin = myReader2.GetString(0);
                    }

                    connection.Close();

                    string col_matlogin2 = "";
                    connection.Open();
                    MySqlDataReader myReader3;
                    MySqlCommand SelectCommand3 = new MySqlCommand("Select * from responsable where col_matricule=" + '"' + col_matlogin + '"' + ";", connection);
                    myReader3 = SelectCommand3.ExecuteReader();
                    while (myReader3.Read())
                    {
                        col_matlogin2 = myReader3.GetString(0);
                    }

                    connection.Close();

                    connection.Open();
                    MySqlDataReader myReader4;
                    MySqlCommand SelectCommand4 = new MySqlCommand("Select COL_NOM,COL_DATEEMBAUCHE from collaborateur where col_matricule='zzz';", connection);
                    myReader4 = SelectCommand4.ExecuteReader();
                    while (myReader4.Read())
                    {
                        col_matlogin3 = myReader4["COL_NOM"].ToString();
                        col_matlogin4 = myReader4["COL_DATEEMBAUCHE"].ToString();
                    }

                    connection.Close();


                    if (t_login.Text == col_matlogin3 && t_mdp.Text == col_matlogin4)
                    {
                        natUser = "admin";
                        string log, mdp;
                        log = t_login.Text;
                        mdp = t_mdp.Text;
                        Selection S4 = new Selection(log, mdp, natUser);
                        S4.Show();
                        this.Hide();
                        connection.Close();
                    }

                    else if (col_matlogin2 != "")
                    {
                        natUser = "responsable";

                        string log, mdp;
                        log = t_login.Text;
                        mdp = t_mdp.Text;
                        Selection S2 = new Selection(log, mdp, natUser);
                        S2.Show();
                        this.Hide();
                        connection.Close();


                    }
                    else
                    {
                        string log, mdp;
                        log = t_login.Text;
                        mdp = t_mdp.Text;
                        natUser = "visiteur";
                        connection.Close();
                        Selection S3 = new Selection(log, mdp, natUser);
                        S3.Show();
                        this.Hide();

                    }



                }
                else
                {
                    if (t_login.Text != "" && t_mdp.Text != "")
                    {
                        MessageBox.Show("Login et/ou mot de passe incorrecte");
                    }

                    t_login.Text = "";
                    t_mdp.Text = "";
                    connection.Close();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void t_mdp_TextChanged(object sender, EventArgs e)
        {
            error_mdp.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void t_login_TextChanged(object sender, EventArgs e)
        {
            error_login.Clear();
        }
    }
}
