using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace AdminPanel
{
    public partial class dashboard : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public dashboard()
        {
            InitializeComponent();

            // SQL Start
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                SqlDataReader reader = null;

                command.CommandText = "SELECT COUNT(*) FROM svar WHERE spoergsmaal='2'";
                double count = Convert.ToDouble(command.ExecuteScalar());

                labelCountS1.Text = count.ToString();

                command.CommandText = "SELECT COUNT(*) FROM svar WHERE spoergsmaal='1'";
                double count2 = Convert.ToDouble(command.ExecuteScalar());

                labelCountS2.Text = count2.ToString();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='1'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelSpor1.Text = reader["spoergsmaal"].ToString();
                    }
                }
                reader.Close();

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='2'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelSpor2.Text = reader["spoergsmaal"].ToString();
                    }
                }
            }
            catch (SqlException)
            {
                labelFejlErrorFraSql.Text = "Fejl i Sql, kan ikke hente data :(";
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
