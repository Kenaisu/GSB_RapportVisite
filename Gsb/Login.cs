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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = t_login.Text;
            string mdp = t_mdp.Text;

            try
            {

                mdp = mdp.Replace("jan", "01");
                mdp = mdp.Replace("feb", "02");
                mdp = mdp.Replace("mar", "03");
                mdp = mdp.Replace("apr", "04");
                mdp = mdp.Replace("may", "05");
                mdp = mdp.Replace("jun", "06");
                mdp = mdp.Replace("jul", "07");
                mdp = mdp.Replace("aug", "08");
                mdp = mdp.Replace("sep", "09");
                mdp = mdp.Replace("oct", "10");
                mdp = mdp.Replace("nov", "11");
                mdp = mdp.Replace("dec", "12");

                MySqlCommand SelectCommand = new MySqlCommand(" select * from collaborateur where COL_NOM='" + login + "' and COL_DATEEMBAUCHE='" + mdp + "' ;", connection);

                MySqlDataReader myReader;
                connection.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Selection S2 = new Selection(login, mdp);
                    S2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorect");
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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
