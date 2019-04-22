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
{    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();

            cboStudent.DataSource = Library.Students;
            cboStudent.DisplayMember = "Name";
            cboStudent.ValueMember = "ID";
            cboStudent.SelectedIndexChanged += cboStudent_SelectedIndexChanged;
        }
        
        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var myStudentBooks = Library.Students.
                    Find(s => s.ID == Convert.ToInt32(cboStudent.SelectedValue)).
                    StudentBooks.ToList();

                 var myStudentBooksList = (from q in myStudentBooks select new BorrowedStudentBook() {Name=q.book.Name,ID= q.book.ID});
                                               
               cboBooks.DisplayMember = "Name";
               cboBooks.ValueMember = "ID";
                cboBooks.DataSource = myStudentBooksList.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = Library.Students.Find(d => d.ID == Convert.ToInt32(cboStudent.SelectedValue));
           
            if(student!=null)
            {
                int bookid = Convert.ToInt32(cboBooks.SelectedValue);

                var u = student.StudentBooks.Find(r => r.book.ID == bookid);
                dtpDueDate.Value = u.DueDate;

                if(dtpDueDate.Value<DateTime.Now)
                {                  
                    TxtOverdueDays.Text = (DateTime.Now - dtpDueDate.Value).Days.ToString();

                }

            }


        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {

            var student = Library.Students.Find(d => d.ID == Convert.ToInt32(cboStudent.SelectedValue));
            int bookid=0;
            if (student != null)
            {
                  bookid = Convert.ToInt32(cboBooks.SelectedValue);

                  var t = student.StudentBooks.Find(h => h.book.ID == bookid);

                  var f = student.StudentBooks.Remove(t);
            }       
              
        }
    }
}
