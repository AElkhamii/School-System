using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSQL
{
    public partial class Subjects : UserControl
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void TReturnBTN_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();
        }
    }
}
