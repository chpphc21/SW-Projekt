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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        chat Chat = new chat();

        private void but_anm_Click(object sender, EventArgs e)
        {
            Chat.Show();
            Chat.Text += text_anm.Text;
            this.Hide();
        }

        private void but_reg_Click(object sender, EventArgs e)
        {
            Chat.Show();
            Chat.Text += text_reg.Text;
            this.Hide();
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
    }
}
