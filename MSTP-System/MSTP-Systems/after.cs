using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSTP_System
{
    public partial class after : UserControl
    {
        public after()
        {
            InitializeComponent();
        }

        private void ReloadForm ()
        {
            int id = 0;
            questions q = new questions(id);
            q.Refresh();
            Refresh();
            q.Hide();
            q.Show();

            
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }
    }
}
