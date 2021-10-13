﻿using System;
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
        public string IPneu;
        public string IP;
        public string user;

        string query1;
        string SQLServer = "server = koordinationsleiter.ddns.net; user id = Projekt; password=Projekt; database=Benutzer; sslmode=None;port=3306; persistsecurityinfo=True";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable tbl;  //datatable für Abfragenergebnisse
        chat f1 = new chat();


        public form1()
        {
            InitializeComponent();
            conn = new MySqlConnection();
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
                query1 = "UPDATE Benutzer.Benutzer Set Status='online',IPAdresse='" + getIP()+"' where Benutzername ='"+text_anm.Text+"';";
                conn.Open();
                cmd = new MySqlCommand(query1, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();

                Chat.Show();
                Chat.Text += text_anm.Text;
                f1.user = text_anm.Text;
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
                
                query1 = "Insert into Benutzer.Benutzer (Benutzername,IPAdresse,Status) values ('"+text_reg.Text+"','"+getIP()+"','online');";
                conn.Open();
                cmd = new MySqlCommand(query1, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    Chat.Show();
                    Chat.Text += text_reg.Text;
                    f1.user = text_reg.Text;
                    this.Hide();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Benutzername schon vorhanden"+ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

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
                label2.ForeColor = Color.FromArgb(0, 240, 0);
                label2.Text = "Verbunden";

            }
            catch
            {
                farbe.BackColor = Color.Red;
                label2.ForeColor = Color.Red;
                label2.Text = "Fehlgeschlagen";
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
                    IPneu += ip.ToString()+"%";
                }          
            }
            if (IPneu == "")
            {
                throw new Exception();
            }
            if (IPneu.Contains("172.16.46."))
            {
                int index1 = IPneu.IndexOf("172.16.46.");
                int index2 = 10;
                for (int i = index1; i < index1 + 18; i++)
                {
                    if (IPneu[i] == '%')
                    {
                        index2 = i;
                        break;
                    }
                }
                //IP = "10.0.0.";
                for (int i = index1; i < index2; i++)
                {
                    IP += IPneu[i];
                }
            }
            else if (!IPneu.Contains("172.16.46."))
                MessageBox.Show("Nicht mit dem Netzwerk verbunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return IP;
        }
    }


}
