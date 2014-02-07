using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iZet.DC.VIP.Controllers;
using iZet.DC.VIP.Models;

namespace iZet.DC.VIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statsBindingSource.DataSource = Stats.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StatsController().GetStats();
//            Stats.Instance.SharedMax++;
        }
    }
}
