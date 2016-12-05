using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MSTP_System
{
    public partial class MSTPsystem : Form
    {
        public void splash()
        {
            Application.Run(new splash());
        }
        public MSTPsystem()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(15625);

            InitializeComponent(); //Starter programmet

            try
            {
                SqlConnection conn = new SqlConnection("Data source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true"); //Her laver vi vores forbindelse til databasen, med de værdier som der skal bruges så som servernavn og database navn.
                conn.Open(); // Vi åbner forbindelsen til SQL database

                SqlCommand command = new SqlCommand("", conn); //Her opretter vi en top kommando
                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='1'"; //Vi laver vores kommando tekst til at skulle vælge alle from spørgsmålstabellen hvor id'et = 1

                SqlDataReader reader = null; //Vi definere vores sql-reader til at være tom/0
                reader = command.ExecuteReader(); //Vi udfører kommandoen fra vores kommandotekst
                if(reader.HasRows) //Her siger vi at hvis vores reader har rækker, altså at der er rækker i tabellen
                {
                    while (reader.Read()) //Imens at reader læser i tabellen
                    {
                        buttonQ1.Text = reader["spoergsmaal"].ToString(); //Så ændre den teksten på knap 1 til at være spørgsmålet i tabellen med det tilhørende id = 1
                        string idhold = reader["id"].ToString(); // Og så gemmer vi id'et til senere brug

                        gemId(idhold); //Her sender vi id'et ned i en ny metode, så vi kan gøre brug af den senere
                    }
                }
                reader.Close(); //Vi lukker vores reader, så den ikke længere læser i tabellen

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id='2'"; //Her laver vi en ny kommando hvor id'et er ændret til 2

                reader = command.ExecuteReader(); //Udfører kommandoen
                if(reader.HasRows) //Laver den samme som tidligere, så hvis vores reader har rækker
                {
                    while(reader.Read()) //Så skal den imens at den læser 
                    {
                        buttonQ2.Text = reader["spoergsmaal"].ToString(); //Sætter teksten på knap 2 til at være det næste spørgsmål
                        string idhold2 = reader["id"].ToString(); //og gemmer det id der tilhøre det spørgsmål

                        gemId(idhold2); //Sender det til vores metode til senere brug
                    }
                }
            }
            catch (SqlException) //Hvis der opstår en fejl så den ikke kan forbinde eller hente data fra databasen
            {
                MessageBox.Show("FEJL"); //Her åbner den en "besked" box med teksten "FEJL"
            }

            t.Abort();
        }
        
        public static void gemId(string idhold) //Her gemmes vores id'er
        {
            int id = int.Parse(idhold); //Ændre id'et fra en string til en int
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1; //Giver knap 1 id'et 1 for at vi kan bruge den i den næste form
            questions q = new questions(id); //Definere den nye form så vi kan åbne den
            q.Show(); //Her vises den nye form.
            this.Hide();
        }

        private void buttonQ2_Click(object sender, EventArgs e)
        {
            int id = 2; //Giver knap 2 id'et 2 for at vi kan bruge den i den næste form
            questions q = new questions(id); //Definere den nye form så vi kan åbne den
            q.Show(); //Her vises den nye form.
            this.Hide();
            
            
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
