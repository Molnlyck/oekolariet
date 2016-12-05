using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AdminPanel
{
    public partial class Form1 : Form
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
        public Form1()
        {
            //SPLASH

            //END SPLASH

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            dashboard dash = new dashboard();
            panel3.Controls.Add(dash);
            AddBtn.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            dashboard dash = new dashboard();
            panel3.Controls.Add(dash);
            AddBtn.Hide();
            labelTitle.Text = "Overblik";
        }

        private void pictureBox3_Click(object sender, EventArgs e) //AddBtn
        {
            
        }

        private void buttonSporgsmalAdmin_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            questions q = new questions();
            panel3.Controls.Add(q);
            AddBtn.Show();
            labelTitle.Text = "Spørgsmål";
        }

        private void buttonFakta_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            fakta fakta = new fakta();
            panel3.Controls.Add(fakta);
            AddBtn.Hide();
            labelTitle.Text = "Fakta";
        }
    }
}
