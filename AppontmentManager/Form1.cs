using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppontmentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //control events to raise
            lblClose.Click += LblClose_Click;
            txtDetails.Click += TxtDetails_Click;
            txtDetails.LostFocus += TxtDetails_LostFocus;
        }

        private void TxtDetails_LostFocus(object sender, EventArgs e)
        {
            if(txtDetails.Text == "")
            {
                txtDetails.Text = "Write your appointment details here";
            }
        }

        private void TxtDetails_Click(object sender, EventArgs e)
        {
            if(txtDetails.Text == "Write your appointment details here")
            {
                txtDetails.Clear();
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
