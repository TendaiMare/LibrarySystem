using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
namespace LibrarySystem
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
            Library.PopulateEmployees();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            var v = Library.Employees.Where(a => a.Username == TxtUsername.Text && a.Password == TxtPassword.Text).ToList();

            Console.WriteLine(v.Count().ToString());
            if(v.Count>0)
            {
                MessageBox.Show("Successfull Log In");
            }
            else
            {
                MessageBox.Show("Wrong Username and or Password");
            }

           


        }
    }
}
