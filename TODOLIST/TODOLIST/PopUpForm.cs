﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
            Uzenet_label.Text = "Egyszerre nem szerkeszthető két teendő!";
        }
        
        public void SetLabel(string message)
        {
            Uzenet_label.Text=message;
        }

        private void ertesitesButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
