using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Kommentar og kode af Patrick Bergmann

namespace MSTP_System
{
    public partial class questions : Form
    {
        public questions(int id) //Vi starter med at hente id'et fra den tidligere form
        {
            
            InitializeComponent(); //Starter formen/programmet
            panelAddProcent.Hide(); //Gemmer panelet 'panelAddprocent' væk så den ikke kan ses på skærmen
            buttonBack.Hide(); //Gemmer panelet 'buttonBack' væk så den ikke kan ses på skærmen
            try //Vi prøver
            {
                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true"); //Skaber en forbindelse til db
                conn.Open(); //Åbner forbindelsen til databasen

                SqlCommand command = new SqlCommand("", conn); //Laver en tom kommando
                SqlDataReader reader = null; //Definere vores reader fra tidligere, da vi er i en ny form så skal vi definere den igen for at vi kan bruge den.

                command.CommandText = "SELECT * FROM spoergsmaal WHERE id=" + id; //Opretter en ny kommando så vi kan hente data fra tabellen.
                reader = command.ExecuteReader(); //Udfører kommandoen
                if (reader.HasRows) //Hvis tabellen har rækker
                {
                    while (reader.Read()) //Og så længe at vores reader læser 
                    {
                        Question.Text = reader["spoergsmaal"].ToString(); //Sættes spørgsmålet ind på skærmen alt efter det valgte spørgsmål på startssiden
                        labelFakta.Text = "Fakta bag spørgsmålet: " + reader["spoergsmaal"].ToString(); //Her udskriver vi spørgsmålet igen for at vi kan fortælle brugeren at det er fakta til det spørgsmål
                    }
                }
                reader.Close(); //Lukker reader

                command.CommandText = "SELECT * FROM fakta WHERE spoergsmaal=" + id; //Laver ny kommando
                reader = command.ExecuteReader(); //udfører kommando
                if (reader.HasRows) //Hvis den har rækker
                {
                    while (reader.Read()) //Så længe den læser 
                    {
                        faktaTextBox.Text = reader["fakta"].ToString(); //Udskriver den fakta til spørgsmålet
                    }
                }
            }
            catch (SqlException) //Fanger fejl hvis der kommer nogen
            {

            }
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        
        }
        private async void btnYes_Click(object sender, EventArgs e)
        {
            
                
            try
            {
                

                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                command.CommandText = "SELECT * FROM spoergsmaal WHERE spoergsmaal='"+Question.Text+"'";
                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelId.Text = reader["id"].ToString();
                    }
                }

                reader.Close();
                labelId.Text = labelId.Text;

                command.CommandText = "INSERT INTO svar(svar,spoergsmaal) VALUES ('ja','"+labelId.Text+"')";
                command.ExecuteNonQuery();

                btnYes.Hide();
                btnNo.Hide();

                labelSvarEfterBrugerSvar.Text = "Tak for dit svar. Du svarede: Ja";
                panelAddProcent.Show();

                command.CommandText = "SELECT COUNT(*) FROM svar WHERE spoergsmaal='"+labelId.Text+"'";
                double fullcount = Convert.ToDouble(command.ExecuteScalar());
                command.CommandText = "SELECT COUNT(*) FROM svar WHERE svar='ja' AND spoergsmaal='"+labelId.Text+"'";
                double countyes = Convert.ToDouble(command.ExecuteScalar());

                double procent = (countyes/fullcount) * 100;

                labelProcent.Text = procent.ToString("N2")+"% af besøgende har svaret det samme som dig.";

                buttonBack.Visible = false;
                await Task.Delay(5000);
                buttonBack.Visible = true;

                string formid = labelId.Text;
                int id = int.Parse(formid);
                questions reload_form = new questions(id);
                await Task.Delay(30000);
                this.Dispose();
                reload_form.Show();

            }
            catch (SqlException) 
            {
                labelError.Text = "Der skete en fejl i dit svar, prøv igen senere eller kontakt personalet";
            }
        }
        private async void btnNo_Click_1(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection("Data Source=PATRICK-PC; Initial Catalog=okoriet; integrated security=true");
                conn.Open();

                SqlCommand command = new SqlCommand("", conn);
                command.CommandText = "SELECT * FROM spoergsmaal WHERE spoergsmaal='" + Question.Text + "'";
                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelId.Text = reader["id"].ToString();
                    }
                }

                reader.Close();
                labelId.Text = labelId.Text;

                command.CommandText = "INSERT INTO svar(svar,spoergsmaal) VALUES ('nej','" + labelId.Text + "')";
                command.ExecuteNonQuery();

                btnYes.Hide();
                btnNo.Hide();

                labelSvarEfterBrugerSvar.Text = "Tak for dit svar. Du svarede: Nej";
                panelAddProcent.Show();

                command.CommandText = "SELECT COUNT(*) FROM svar WHERE spoergsmaal='" + labelId.Text + "'";
                double fullcount = Convert.ToDouble(command.ExecuteScalar());
                command.CommandText = "SELECT COUNT(*) FROM svar WHERE svar='nej' AND spoergsmaal='" + labelId.Text+"'";
                double countno = Convert.ToDouble(command.ExecuteScalar());

                double procent = (countno/fullcount) * 100;

                labelProcent.Text = procent.ToString("N2") + "% af besøgende har svaret det samme som dig.";


                buttonBack.Visible = false;
                await Task.Delay(5000);
                buttonBack.Visible = true;

                string formid = labelId.Text;
                int id = int.Parse(formid);
                questions reload_form = new questions(id);
                await Task.Delay(30000);
                this.Dispose();
                reload_form.Show();

            }
            catch (SqlException)
            {
                labelError.Text = "Der skete en fejl i dit svar, prøv igen senere eller kontakt personalet";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string formid = labelId.Text;
            int id = int.Parse(formid);
            questions reload_form = new questions(id);
            this.Dispose();
            reload_form.Show();
            
            
        }

        private void labelFakta_Click(object sender, EventArgs e)
        {

        }

        private void panelAddProcent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
