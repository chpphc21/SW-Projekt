﻿using System;
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

namespace SW_Projekt
{
    public partial class chat : Form
    {
        //Parameter für die Datenbank
        // Projekt@% Projekt DB:Benutzer

        string IP_user2 = "";
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
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {

        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            chatbox.Invoke((MethodInvoker)delegate ()
            {
                chatbox.Text += lab_auswahl.Text.Replace("\n", "") + ": " + e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
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

            }
            catch
            {
                MessageBox.Show("Bitte einen Benutzer Auswählen! ", "Achtung", 0, MessageBoxIcon.Error);
            }

        }
    }
}
