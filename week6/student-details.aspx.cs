using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week6
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            // Create a new Student object
            Student s = new Student();

            // fill the properties of the new student object
            s.LastName = LastName.Text;
            s.FirstMidName = FirstMidName.Text;
            s.EnrollmentDate = Convert.ToDateTime(EnrollmentDate.Text);

            // save the new object to the database
            conn.Students.Add(s);
            conn.SaveChanges();

            //redirect to the students page
            Response.Redirect("students.aspx");
        }
    }
}