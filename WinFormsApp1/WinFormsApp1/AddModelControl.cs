﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddModelControl : UserControl
    {
        public AddModelControl()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string modelId = txtModelID.Text;
            string companyName = cboCompanyName.SelectedItem?.ToString();
            string modelNumber = txtModelNumber.Text;


        }

        private void cboCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
