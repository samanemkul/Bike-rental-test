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
    public partial class addRental : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public addRental()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string data1 = Date1.ToString();
            string data2 = Date2.ToString();
            string query = "Insert into add_rental(BikeNo,BikeName,ClientName,RentalStartDate,RentalEndDate,TotalAmount,PaymentStatus,RentalStatus,remarks) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + data1 + "','"+data2+ "','"+textBox4.Text+"','"+ textBox5.Text+ "','"+ textBox6.Text + "','"+ richTextBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("data inserted");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
