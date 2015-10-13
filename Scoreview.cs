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
    public partial class Scoreview : Form,View
    {
        Model model;
        Controller controller;
        public Scoreview()
        {
            InitializeComponent();
        }

        private void Scoreview_Load(object sender, EventArgs e)
        {
           
        }
        public void Notify(Model m)
        {
            label2.Text = ((TwoZeroFourEightModel)m)._score.ToString();
        }
    }
}
