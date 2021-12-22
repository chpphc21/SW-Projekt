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

namespace SW_Projekt
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            string con = "server = koordinationsleiter.ddns.net; user id =Projekt;password=Projekt; database=Benutzer; sslmode=None;port=3306; persistsecurityinfo=True";

            MySqlConnection connect = new MySqlConnection(con);
            connect.Open();
            try
            {
                string sqlQuery = "select Benutzername from Benutzer.Benutzer where Status='online';";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, connect);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Datagrid.DataSource = ds;
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
