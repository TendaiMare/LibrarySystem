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
    public partial class frmFineCheck : Form
    {
        public frmFineCheck()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("StudentName",typeof(String)));
            dt.Columns.Add(new DataColumn("StudentSurname", typeof(String)));
            dt.Columns.Add(new DataColumn("BookName", typeof(String)));

            foreach (Student _student in Library.Students)
            {
                if (_student.studentBooks.Count>0)
                {
                    foreach (StudentBooks _sb in _student.studentBooks)
                    {                        
                        dt.Rows.Add(_student.Name,_student.Surname,_sb.book.Name);
                    }
                }                
            }

            dataGridView1.DataSource = dt;           
           
        }
    }
}
