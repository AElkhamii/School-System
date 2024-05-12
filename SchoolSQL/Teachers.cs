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
    public partial class Teachers : UserControl
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void TReturnBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
