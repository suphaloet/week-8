﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void Score(int s)
        {
            lblScore.Text = Convert.ToString(s);
        }
        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
