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
    public partial class addClient : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public addClient()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "First Name")
            {
                FirstName.Text = " ";
                FirstName.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(FirstName.Text == " ")
            {
                FirstName.Text = "First Name";
                FirstName.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(MiddleName.Text == "Middle Name")
            {
                MiddleName.Text = " ";
                MiddleName.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(MiddleName.Text == " ")
            {
                MiddleName.Text = "Middle Name";
                MiddleName.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if(LastName.Text == "Last Name")
            {
                LastName.Text = " ";
                LastName.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(LastName.Text == " ")
            {
                LastName.Text = "Last Name";
                LastName.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(CompleteAddress.Text == "Enter Complete Address")
            {
                CompleteAddress.Text = " ";
                CompleteAddress.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if(CompleteAddress.Text == " ")
            {
                CompleteAddress.Text = "Enter Complete Address";
                CompleteAddress.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if(ContactNumber.Text == "Enter Contact Number")
            {
                ContactNumber.Text = " ";
                ContactNumber.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if(ContactNumber.Text == " ")
            {
                ContactNumber.Text = "Enter Contact Number";
                ContactNumber.ForeColor = Color.Silver;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if(EmailAddress.Text == "Enter Email Address")
            {
                EmailAddress.Text = " ";
                EmailAddress.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if(EmailAddress.Text == " ")
            {
                EmailAddress.Text = "Enter Email Address";
                EmailAddress.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if(Gender.Text == "Gender")
            {
                Gender.Text = " ";
                Gender.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if(Gender.Text == " ")
            {
                Gender.Text = "Gender";
                Gender.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if(CivilStatus.Text == "Enter Civil Status")
            {
                CivilStatus.Text = " ";
                CivilStatus.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if(CivilStatus.Text == " ")
            {
                CivilStatus.Text = "Enter Civil Status";
                CivilStatus.ForeColor = Color.Silver;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if(Age.Text == "Enter Age")
            {
                Age.Text = " ";
                Age.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if(Age.Text == " ")
            {
                Age.Text = "Enter Age";
                Age.ForeColor = Color.Silver;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Enter Username")
            {
                Username.Text = " ";
                Username.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if(Username.Text == " ")
            {
                Username.Text = "Enter Username";
                Username.ForeColor = Color.Silver;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Enter Password")
            {
                Password.Text = " ";
                Password.ForeColor = Color.Black;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if(AccountStatus.Text == "Enter Account Status")
            {
                AccountStatus.Text = " ";
                AccountStatus.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if(Password.Text == " ")
            {
                Password.Text = "Enter Password";
                Password.ForeColor = Color.Silver;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if(AccountStatus.Text == " ")
            {
                AccountStatus.Text = "Enter Account Status";
                AccountStatus.ForeColor = Color.Silver;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

   /*     private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(FirstName)" +
                "values(@FirstName)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(MiddleName)" +
                "values(@MiddleName)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@MiddleName", MiddleName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(LastName)" +
                "values(@LastName)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@LastName", LastName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(CompleteAddress)" +
                "values(@CompleteAddress)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@CompleteAddress", CompleteAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ContactNumber_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(ContactNumber)" +
                "values(@CompleteAddress)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(EmailAddress)" +
                "values(@EmailAddress)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(Gender)" +
                "values(@Gender)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Gender", Gender.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(CivilStatus)" +
                "values(@CivilStatus)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@CivilStatus", CivilStatus.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details()" +
            //    "(Age)" +
            //    "values(@Age)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Age", Age.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(Username)" +
                "values(@Username)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Username", Username.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details" +
                "(Password)" +
                "values(@Password)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void AccountStatus_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into clients_details(" +
                "(AccountStatus)" +
                "values(@AccountStatus)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@AccountStatus", AccountStatus.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
   */
        private void iconButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string data1 = Date.ToString();
            String query = "Insert into clients_details(FirstName,MiddleName,LastName,CompleteAddress,ContactNumber,EmailAddress,Gender,CivilStatus,Birthdate,Age,Username,Password,AccountStatus) values('" + FirstName.Text + "','" + MiddleName.Text + "','" + LastName.Text + "','" + CompleteAddress.Text + "','" + ContactNumber.Text + "','" + EmailAddress.Text + "','" + Gender.Text + "','" + CivilStatus.Text + "','" + data1 + "','" + Age.Text + "','" + Username.Text + "','" + Password.Text + "','" + AccountStatus.Text + "')";
             SqlCommand cmd=new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("data inserted");






                    

        }
    }
}
