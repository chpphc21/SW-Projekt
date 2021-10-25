using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using SimpleTCP;
using System.Text.RegularExpressions;

namespace SW_Projekt
{
    public partial class chat : Form
    {
        //Parameter für die Datenbank
        // Projekt@% Projekt DB:Benutzer


        string IP, IPneu;
        string IP_user2 = "";
        string IP_3;
        public string deineIP = "172.16.46.";
        //public string deineIP = "192.168.56.";

        string query1;
        public string user;
        string SQLServer = "server = koordinationsleiter.ddns.net; user id =Projekt;password=Projekt; database=Benutzer; sslmode=None;port=3306; persistsecurityinfo=True";

        MySqlConnection conn2 = new MySqlConnection();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable tbl;  //datatable für Abfragenergebnisse
                        //form1 anm = new form1();

        SimpleTcpClient client;
        SimpleTcpServer server;

        public chat()
        {
            InitializeComponent();
            conn2 = new MySqlConnection();
            conn2.ConnectionString = SQLServer;
        }
        private void chat_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(getIP());
            server.Start(ip, Convert.ToInt32(8888));
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {

        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            chatbox.Invoke((MethodInvoker)delegate ()
            {
                //e.ReplyLine(string.Format(e.MessageString));
                e.MessageString.Replace("[]", "");
                //if (e.MessageString.Contains("172.16.46."))
                //{
                //    IP_3 = System.Net.IPAddress.Parse(e.MessageString).ToString();
                //    newone();
                //}
                //if (!e.MessageString.Contains("172.16.46."))
                //{
                string mes = e.MessageString.Substring(0, e.MessageString.Length - 1);
                chatbox.Items.Add(lab_auswahl.Text.Replace("\n", "") + ": " + mes);
                //}
            });
        }
        private void chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            query1 = "UPDATE Benutzer.Benutzer Set Status='offline', LoginDatum='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Benutzername ='" + user + "';";
            conn2.Open();
            cmd = new MySqlCommand(query1, conn2);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn2.Close();

            if (server.IsStarted)
                server.Stop();

            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Text_chat.Text != "Nachricht")
            {
                client.Connect(IP_user2, 8888);
                chatbox.Items.Add("Du: " + Text_chat.Text);
                client.WriteLineAndGetReply(Text_chat.Text, TimeSpan.FromSeconds(3));
                Text_chat.Clear();
                Text_chat.Focus();
            }
        }

        private void Text_chat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                but_senden.Focus();
                but_senden.PerformClick();
            }
        }

        private void Text_chat_Enter(object sender, EventArgs e)
        {
            Text_chat.Clear();
            Text_chat.ForeColor = Color.Black;
        }

        private void Text_chat_Leave(object sender, EventArgs e)
        {
            if (Text_chat.Text == "")
            {
                Text_chat.ForeColor = Color.DarkGray;
                Text_chat.Text = "Nachricht";
            }
        }

        private void but_ver_Click(object sender, EventArgs e)
        {
            chatbox.Items.Clear();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                list_user.Items.Clear();
                but_auswahl.Enabled = true;
                //Benutzer abrufen bei denen das Feld Status auf online steht
                query1 = "select Benutzername from Benutzer.Benutzer where Status='online';";
                conn2.Open();
                cmd = new MySqlCommand(query1, conn2);
                da = new MySqlDataAdapter(cmd);
                tbl = new DataTable();
                da.Fill(tbl);
                conn2.Close();
                string record = "";
                #region füllen der benutzer die Online sind
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    DataRow row = tbl.Rows[i];
                    for (int j = 0; j < tbl.Columns.Count; j++)
                    {
                        if (tbl.Columns[j].ColumnName == "Benutzername")
                        {
                            record += row[j] + "\n";
                            continue;
                        }
                    }
                    list_user.Items.Add(record);
                    record = "";
                }

                #endregion
            }
            catch
            {
                MessageBox.Show("Nicht mit dem Netzwerk verbunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_auswahl_Click(object sender, EventArgs e)
        {
            try
            {
                lab_auswahl.Text = list_user.Items[list_user.SelectedIndex].ToString();
                Text_chat.Enabled = true;
                chatbox.Enabled = true;
                but_senden.Enabled = true;
                but_ver.Enabled = true;
                dateien.Enabled = true;
                lab_status.Text = "Chat mit";
                query1 = "select IPAdresse from Benutzer.Benutzer where Benutzername='" + lab_auswahl.Text.Replace("\n", "") + "';";
                conn2.Open();
                cmd = new MySqlCommand(query1, conn2);
                da = new MySqlDataAdapter(cmd);
                tbl = new DataTable();
                da.Fill(tbl);
                conn2.Close();
                #region IP Adresse suchen
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    DataRow row = tbl.Rows[i];
                    for (int j = 0; j < tbl.Columns.Count; j++)
                    {
                        if (tbl.Columns[j].ColumnName == "IPAdresse")
                        {

                            IP_user2 += row[i];
                            continue;
                        }
                    }
                }
                #endregion

                //client.Connect(IP_user2, 8888);
                //client.WriteLineAndGetReply(getIP(), TimeSpan.FromSeconds(3));
            }
            catch
            {
                MessageBox.Show("Bitte einen Benutzer Auswählen! ", "Achtung", 0, MessageBoxIcon.Error);
            }

        }
        private string getIP()
        {
            string pattern = @"\b[10.0.0.]\w+";
            String strHostName = string.Empty;
            Regex rg = new Regex(pattern);
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress ip in addr)
            {
                if (rg.IsMatch(ip.ToString()))
                {
                    IPneu += ip.ToString() + "%";
                }
            }
            if (IPneu == "")
            {
                throw new Exception();
            }
            if (IPneu.Contains(deineIP))
            {
                int index1 = IPneu.IndexOf(deineIP);
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
            else if (!IPneu.Contains(deineIP))
                MessageBox.Show("Nicht mit dem Netzwerk verbunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return IP;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            file1.InitialDirectory= "ftp://SW-Projekt:@chpolke.ddns.net";
            file1.ShowDialog();
        }

        public string newone()
        {
            lab_auswahl.Text = list_user.Items[list_user.SelectedIndex].ToString();
            Text_chat.Enabled = true;
            chatbox.Enabled = true;
            but_senden.Enabled = true;
            but_ver.Enabled = true;
            lab_status.Text = "Chat mit";

            query1 = "select IPAdresse from Benutzer.Benutzer where IPAdresse='" + IP_3 + "';";
            conn2.Open();
            cmd = new MySqlCommand(query1, conn2);
            da = new MySqlDataAdapter(cmd);
            tbl = new DataTable();
            da.Fill(tbl);
            conn2.Close();
            #region IP Adresse suchen
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow row = tbl.Rows[i];
                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    if (tbl.Columns[j].ColumnName == "Benutzername")
                    {

                        lab_auswahl.Text += row[i];
                        continue;
                    }
                }
            }
            return "0";
            #endregion
        }

    }
}
