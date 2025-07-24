using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppManager.PL
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();

        }

        

        private void employesManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        
    }
}
