using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogIn myForm = new frmLogIn();
            myForm.ShowDialog();
            this.Close();

        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBooks myForm = new frmBorrowBooks();
            myForm.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturn myForm = new frmReturn();
            myForm.ShowDialog();
        }

        private void fineCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFineCheck myForm = new frmFineCheck();
            myForm.ShowDialog();
        }
    }
}
