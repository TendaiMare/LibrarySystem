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
    public partial class frmBorrowBooks : Form
    {
        public frmBorrowBooks()
        {
            InitializeComponent();

            cboStudent.DataSource = Library.Students;
            cboStudent.DisplayMember = "Name";
            cboStudent.ValueMember = "ID";

            cboBook.DataSource = Library.Books;
            cboBook.DisplayMember = "Name";
            cboBook.ValueMember = "ID";

        }

        private void frmBorrowBooks_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }

        private void BtnBorrowBook_Click(object sender, EventArgs e)
        {
            if(Convert.IsDBNull(cboStudent.SelectedValue))
            {
                MessageBox.Show("Please select the student");
            }
             if(Convert.IsDBNull(cboBook.SelectedValue))
            {
                MessageBox.Show("Please select the book");
            }

            var myStudent = Library.Students.Find(s => s.ID == Convert.ToInt32(cboStudent.SelectedValue));
            var myBook = Library.Books.Find(d => d.ID == Convert.ToInt32(cboBook.SelectedValue));
           
            if(myStudent!= null)
            {               
                if (myBook!=null)
                {
                    StudentBooks myStudentBook = new StudentBooks(myBook, DateTime.Now.AddDays(7));
                    myStudent.StudentBooks.Add(myStudentBook);
                }              
            }



        }

    }
}
