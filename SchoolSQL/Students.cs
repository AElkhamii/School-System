﻿using System;
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
    public partial class Students : UserControl
    {
        public Students()
        {
            InitializeComponent();
        }

        private void STReturnBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
