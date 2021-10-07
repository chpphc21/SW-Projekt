using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace SW_Projekt
{
    public partial class form1 : Form
    {
        string IPneu;


        string query1;
        string SQLServer = "server = koordinationsleiter.ddns.net; user id =Projekt;password=Projekt; database=Benutzer; sslmode=None;port=3306; persistsecurityinfo=True";

        MySqlConnection conn =new MySqlConnection();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable tbl;  //datatable für Abfragenergebnisse


        public form1()
        {
            InitializeComponent();
            conn.ConnectionString = SQLServer;
        }
        chat Chat = new chat();

        private void but_anm_Click(object sender, EventArgs e)
        {
            if (text_anm.Text == "")
            {
                MessageBox.Show("Bitte einen Benutzernamen eingeben!", "Keine Leerzeichen!", 0, MessageBoxIcon.Exclamation);
            }
            else
            {
                //status der ausgewählten person auf online setzen
                query1 = "UPDATE Benutzer.Benutzer Set Status='online'  where Benutzername ='"+text_anm.Text+"',set IPAdresse='"+getIP()+";";
                conn.Open();
                //cmd = new MySqlCommand(query1, conn);
                conn.Close();

                Chat.Show();
                Chat.Text += text_anm.Text;
                this.Hide();
            }
        }

        private void but_reg_Click(object sender, EventArgs e)
        {
            if (text_reg.Text == "")
            {
                MessageBox.Show("Bitte einen Benutzernamen eingeben!", "Keine Leerzeichen!",0,MessageBoxIcon.Exclamation);
            }
            else
            {

                getIP();


                Chat.Show();
                Chat.Text += text_reg.Text;
                this.Hide();
            }
        }

        private void text_anm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                but_anm.PerformClick();
            }
        }

        private void text_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                but_reg.PerformClick();
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                farbe.BackColor = Color.FromArgb(0,240,0);
                farbe.ForeColor = Color.FromArgb(0, 240, 0);

            }
            catch
            {
                farbe.BackColor = Color.Red;
                label2.ForeColor = Color.Red;

                if (MessageBox.Show("Verbindung zur Datenbank fehlgeschlagen", "Datenbank Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            finally
            {
                conn.Close();
            }

        }
        public string getIP()
        {
            string pattern = @"\b[10.0.0.]\w+";
            Regex rg = new Regex(pattern);
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress ip in addr)
            {
                if (rg.IsMatch(ip.ToString()))
                {
                    IPneu = ip.ToString();
                }
            }
            if (IPneu == "")
            {
                throw new Exception();
            }
            return IPneu;
        }
    }


}
