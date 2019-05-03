using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqTOSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HREntities hREntities = new HREntities();
            var emp = from employee in hREntities.Employees
                      where employee.cCity == "Norton"
                      select employee;
            GridView1.DataSource = emp.ToList();
            GridView1.DataBind();
        }
    }
}