using System;
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
            if (Text_chat.Text != "Nachricht" || Text_chat.Text != "")
            {
            chatbox.Items.Add("Du: " + Text_chat.Text + "\n");
            Text_chat.Clear();
            }
        }

        private void Text_chat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
                Text_chat.ForeColor = Color.LightGray;
                Text_chat.Text = "Nachricht";
            }
        }
    }
}
