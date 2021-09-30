﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SW_Projekt
{
    public partial class form1 : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CS-Projekte\Virtual-Walkway\Bitmap_Test1_Schmid\Bitmap_Test1_Schmid\Database\Patienten.mdf;Integrated Security=True;Connect Timeout=30";
        string pfad = @"C:\CS-Projekte\Virtual-Walkway\Bitmap_Test1_Schmid\Bitmap_Test1_Schmid\Database\";
        string query1;

        //Parameter für die Datenbank
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tbl;  //datatable für Abfragenergebnisse aus der Patientensuche
        public form1()
        {
            InitializeComponent();
            //conns();
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
                //conn.Open();
            }
            catch
            {
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
                //conn.Close();
            }

        }
    }
}
