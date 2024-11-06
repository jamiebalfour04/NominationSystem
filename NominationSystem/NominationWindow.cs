using NominationSystem.Properties;
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
    public partial class NominationWindow : Form
    {
        public NominationWindow()
        {
            InitializeComponent();
        }

        private void NominationWindow_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.nominatorString;
            label2.Text = Properties.Resources.nomineeString;
            label3.Text = Properties.Resources.commentString;



        }

        public static void submitInformation()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
