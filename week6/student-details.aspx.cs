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
            if (IsPostBack == false)
            {
                // check for adding or deleting
                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    // get id
                    Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
                    // connect
                    var conn = new ContosoEntities();
                    // look up the selected student
                    var objStu = (from s in conn.Students where s.StudentID == StudentID select s).FirstOrDefault();
                    // populate the form
                    LastName.Text = objStu.LastName;
                    FirstMidName.Text = objStu.FirstMidName;
                    EnrollmentDate.Text = objStu.EnrollmentDate.ToString("yyyy-MM-dd'T'hh:mm:ss");
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // check for adding or editing
            Int32 StudentID = 0;

            if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            }

            // connect
            var conn = new ContosoEntities();

            // Create a new Student object
            Student s = new Student();

            // fill the properties of the new student object
            s.LastName = LastName.Text;
            s.FirstMidName = FirstMidName.Text;
            s.EnrollmentDate = Convert.ToDateTime(EnrollmentDate.Text);

            // save the new object to the database
            if (StudentID == 0)
            {
                conn.Students.Add(s);
            }
            else
            {
                s.StudentID = StudentID;
                conn.Students.Attach(s);
                conn.Entry(s).State = System.Data.Entity.EntityState.Modified;
            }            

            conn.SaveChanges();

            //redirect to the students page
            Response.Redirect("students.aspx");
        }
    }
}