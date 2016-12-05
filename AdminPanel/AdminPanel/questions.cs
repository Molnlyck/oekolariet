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
    public partial class questions : UserControl
    {
        public questions()
        {
            InitializeComponent();

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='1'";
                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        labelSpQ1.Text = reader["spoergsmaal"].ToString();
                        labelNr.Text = reader["id"].ToString();
                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='2'";

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelSpQ2.Text = reader["spoergsmaal"].ToString();
                        labelNr2.Text = reader["id"].ToString();
                    }
                }
            }
            catch (SqlException)
            {

            }
        }

        private void labelSpQ1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeQ1_Click(object sender, EventArgs e)
        {
             try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                

                command.CommandText = "UPDATE spoergsmaal SET spoergsmaal='"+ChangeQ1.Text+"' WHERE id='1'";

                command.ExecuteNonQuery();

                labelSpQ1.Text = ChangeQ1.Text;
            }
            catch (SqlException)
            {
                labelError.Text = "Der skete en fejl! Prøv igen";
            }
        }

        private void buttonChangeQ2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                

                command.CommandText = "UPDATE spoergsmaal SET spoergsmaal='" + ChangeQ2.Text + "' WHERE id='2'";

                command.ExecuteNonQuery();

                labelSpQ2.Text = ChangeQ2.Text;
            }
            catch (SqlException)
            {
                labelError.Text = "Der skete en fejl! Prøv igen";
            }
        }
    }
}
