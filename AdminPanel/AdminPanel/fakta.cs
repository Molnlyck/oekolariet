using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminPanel
{
    public partial class fakta : UserControl
    {
        public fakta()
        {
            InitializeComponent();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                SqlDataReader reader = null;

                command.CommandText = "SELECT * FROM fakta WHERE id='3'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        faktaBox1.Text = reader["fakta"].ToString();

                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='1'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelSpoergsmaal1.Text = reader["spoergsmaal"].ToString();
                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM fakta WHERE id='1'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        faktaBox2.Text = reader["fakta"].ToString();

                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='2'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelspoergsmaal2.Text = reader["spoergsmaal"].ToString();
                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM fakta WHERE id='2'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        faktaBox3.Text = reader["fakta"].ToString();

                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='3'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelspoergsmaal3.Text = reader["spoergsmaal"].ToString();
                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM fakta WHERE id='4'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        faktaBox4.Text = reader["fakta"].ToString();

                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='4'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelspoergsmaal4.Text = reader["spoergsmaal"].ToString();
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                labelError.Text = "Der skete en fejl! Prøv igen";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelSpoergsmaal_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText = "UPDATE fakta SET fakta ='" + faktaBox1.Text + "' WHERE spoergsmaal='1'";
                command.ExecuteNonQuery();

                faktaBox1.Text = faktaBox1.Text;

                conn.Close();
            }
            catch (SqlException)
            {
                labelError.Text = "FEJL";
            }
        }

        private void buttonChange2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText = "UPDATE fakta SET fakta ='" + faktaBox2.Text + "' WHERE spoergsmaal='2'";
                command.ExecuteNonQuery();

                faktaBox2.Text = faktaBox2.Text;

                conn.Close();
            }
            catch (SqlException)
            {
                labelError.Text = "FEJL";
            }
        }

        private void buttonChange3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText = "UPDATE fakta SET fakta ='" + faktaBox3.Text + "' WHERE spoergsmaal='3'";
                command.ExecuteNonQuery();

                faktaBox3.Text = faktaBox3.Text;

                conn.Close();
            }
            catch (SqlException)
            {
                labelError.Text = "FEJL";
            }
        }

        private void buttonChange4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText = "UPDATE fakta SET fakta ='" + faktaBox4.Text + "' WHERE spoergsmaal='4'";
                command.ExecuteNonQuery();

                faktaBox4.Text = faktaBox4.Text;

                conn.Close();
            }
            catch (SqlException)
            {
                labelError.Text = "FEJL";
            }
        }
    }
}
