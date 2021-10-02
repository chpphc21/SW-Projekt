﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Projekt
{
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }
        private void chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Text_chat.Text != "Nachricht")
            {
                chatbox.Items.Add("Du: " + Text_chat.Text + "\n");

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
            list_user.Items.Add("User 1");
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
            }
            catch
            {
                MessageBox.Show("Bitte einen Benutzer Auswählen!", "Achtung", 0, MessageBoxIcon.Error);
            }

        }
    }
}
