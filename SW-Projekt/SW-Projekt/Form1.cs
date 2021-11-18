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
using System.IO;

namespace SW_Projekt
{
    public partial class form1 : Form
    {
        public string IPneu;
        public string IP;
        public string user;

        string query1;
        string SQLServer = "server = koordinationsleiter.ddns.net; user id = Projekt; password=Projekt; database=Benutzer; sslmode=None; port=3306; persistsecurityinfo=True";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable tbl;  //datatable für Abfragenergebnisse


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
                query1 = "select Benutzername from Benutzer.Benutzer where Benutzername='" + text_anm.Text + "';";
                conn.Open();
                cmd = new MySqlCommand(query1, conn);
                da = new MySqlDataAdapter(cmd);
                tbl = new DataTable();
                da.Fill(tbl);
                conn.Close();
                try
                {
                    DataRow row = tbl.Rows[tbl.Rows.Count - 1];
                    for (int i = 0; i < tbl.Columns.Count; i++)
                    {
                        break;
                    }
                    query1 = "UPDATE Benutzer.Benutzer Set Status='online',IPAdresse='" + Chat.getIP() + "' where Benutzername ='" + text_anm.Text + "';";
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
                    Chat.thisuser = text_anm.Text;
                    Chat.Show();
                    Chat.Text += text_anm.Text;
                    Chat.user = text_anm.Text;
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Benutzer nicht gefunden, bitte registrieren!", "Kein Benutzer gefunden!", 0, MessageBoxIcon.Exclamation);
                    text_reg.Text = text_anm.Text;
                    text_anm.Text = "";
                }   //status der ausgewählten person auf online setzen
            }
        }

        private void but_reg_Click(object sender, EventArgs e)
        {
            if (text_reg.Text == "")
            {
                MessageBox.Show("Bitte einen Benutzernamen eingeben!", "Keine Leerzeichen!", 0, MessageBoxIcon.Exclamation);
            }
            else
            {
                query1 = "select Benutzername from Benutzer.Benutzer where Benutzername='" + text_reg.Text + "';";
                conn.Open();
                cmd = new MySqlCommand(query1, conn);
                da = new MySqlDataAdapter(cmd);
                tbl = new DataTable();
                da.Fill(tbl);
                conn.Close();

                try
                {
                    DataRow row = tbl.Rows[tbl.Rows.Count - 1];
                    for (int i = 0; i < tbl.Columns.Count; i++)
                    {
                        break;
                    }
                    MessageBox.Show("Benutzer bereits vorhanden, bitte Anmelden!", "Benutzer bereits gefunden!", 0, MessageBoxIcon.Exclamation);
                    text_anm.Text = text_reg.Text;
                    text_reg.Text = "";
                }
                catch
                {
                    query1 = "Insert into Benutzer.Benutzer (Benutzername,IPAdresse,Status) values ('" + text_reg.Text + "','" + Chat.getIP() + "','online');";
                    conn.Open();
                    cmd = new MySqlCommand(query1, conn);
                    cmd.ExecuteNonQuery();
                    Chat.thisuser = text_reg.Text;
                    Chat.Show();
                    Chat.Text += text_reg.Text;
                    Chat.user = text_reg.Text;
                    this.Hide();
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
                error.Hide();
                error2.Hide();
                reload.Hide();
                conn.Open();
                farbe.BackColor = Color.FromArgb(0, 240, 0);
                label2.ForeColor = Color.FromArgb(0, 240, 0);
                label2.Text = "Verbunden";

            }
            catch
            {
                text_anm.Hide();
                text_reg.Hide();
                but_anm.Hide();
                but_reg.Hide();
                lab_anm.Hide();
                lab_reg.Hide();
                label1.Hide();
                farbe.BackColor = Color.Red;
                label2.ForeColor = Color.Red;
                label2.Text = "Fehlgeschlagen";
                label2.Left = 160;
                error.Show();
                error2.Show();
                reload.Show();
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }
        private void reload_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }


}
