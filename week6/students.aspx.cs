using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week6
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the students and display in the gridview
            getStudents();
        }
        protected void getStudents()
        {
            // connect to db
            var conn = new ContosoEntities();

            var Students = from d in conn.Students
                              select d;

            // display query result in gridview

            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();

        }

        protected void grdStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // determine the row that user clicked
            Int32 gridIndex = e.RowIndex;
            // find the selected student id
            Int32 StudentID = Convert.ToInt32(grdStudents.DataKeys[gridIndex].Value);
            // connect to db
            var conn = new ContosoEntities();
            // delete the selected row
            Student s = new Student();
            s.StudentID = StudentID;
            conn.Students.Attach(s);
            conn.Students.Remove(s);

            conn.SaveChanges();
            // refresh
            getStudents();
        }
    }
}