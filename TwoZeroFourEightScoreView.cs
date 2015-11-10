using System;
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
    public partial class TwoZeroFourEightScoreView : Form, View
    {
       
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();    
        }
        //Finish !!!
        public void Notify(Model m)
        {
            lblScore.Text = Convert.ToString(((TwoZeroFourEightModel)m).UpdateScore());
        }
    }
}
