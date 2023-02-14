using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class adminClientManagement : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public adminClientManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add client
            this.Hide();
            addClient addc = new addClient();
            addc.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categorypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminClientManagement_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            dataGridView1.Rows.Clear();
            string query = "select * from clients_details";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int sn = 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string fname = table.Rows[i]["FirstName"].ToString();
                string mname = table.Rows[i]["MiddleName"].ToString();
                string lname = table.Rows[i]["LastName"].ToString();
                string number = table.Rows[i]["ContactNumber"].ToString();
                string email = table.Rows[i]["EmailAddress"].ToString();
                string gender = table.Rows[i]["Gender"].ToString();
                string Birthdate = table.Rows[i]["Birthdate"].ToString();
                string age = table.Rows[i]["Age"].ToString();
                string username = table.Rows[i]["Username"].ToString();
                string password = table.Rows[i]["Password"].ToString();
                string accountstatus = table.Rows[i]["AccountStatus"].ToString();
                dataGridView1.Rows.Add(sn++, fname, mname, lname,number,email,gender,Birthdate,age,username,password,accountstatus);
            }
        }
    }
}
