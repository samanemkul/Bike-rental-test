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
    public partial class addPayment : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public addPayment()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            //string data = Date.ToString();
            int getBikeNo = Int32.Parse(BikeNo.Text);
            string getPayType = PayType.Text;
            string getPayBy = PayBy.Text;
            string getRemarks = Remarks.Text;
            DateTime getDate = Date.Value;
            DateTime PaymentDate = new DateTime(getDate.Year, getDate.Month, getDate.Day);
            string query= "Insert into add_payment values('" + getBikeNo + "','" + getPayType + "','" + getPayBy + "','" + PaymentDate + "','" + getRemarks + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //cmd.Dispose();
            con.Close();
            MessageBox.Show("data inserted");
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
