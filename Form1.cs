using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountDown
{
    public partial class Form1 : Form
    {
        int minutes;     

        public Form1()
        {
            InitializeComponent();
        }

        private void start_bt_Click(object sender, EventArgs e) //Start button was pressed
        {
            timer1.Interval = 3600;     //Milliseconds in 1 minute
            timer1.Enabled = true;      //Start the timer
            stop_bt.Enabled = true;
            start_bt.Enabled = false;
        }

        private void stop_bt_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Dispose();
            start_bt.Enabled = true;
            stop_bt.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            start_bt.Enabled = true;
        }
    }
}