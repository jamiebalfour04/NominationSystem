using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NominationSystem
{
    public partial class StartupSelector : Form
    {
        public StartupSelector()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NominationWindow().Show();
        }
    }
}
