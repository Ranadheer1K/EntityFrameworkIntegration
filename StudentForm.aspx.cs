using EntityFrameworkIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkIntegration
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {


            StudentContext sContext = new StudentContext();
            
                var student = new Student()
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Course = txtCrs.Text,
                    Fee = double.Parse(txtFee.Text),
                    Address = "Hyderabad"
                };
                sContext.students.Add(student);
                sContext.SaveChanges();
            Response.Write("Inserted");
            
                
        }
    }
}