﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_StartUp : Form
    {
        public Form_StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                Close();
            }
        }

        private void Form_StartUp_Load(object sender, EventArgs e)
        {

        }

       
    }
}