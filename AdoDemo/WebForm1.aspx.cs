using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//part-61 Partial Classes
namespace AdoDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//part-61 Partial Classes
            Customer C1 = new Customer();
            C1.FirstName = "Pragim";
            C1.LastName = "Technologies";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Pragim";
            C2.LastName = "Technologies";
            string FullName2 = C2.GetFullName();
            Response.Write("Full Name = " + FullName2 + "<br/>");

            //part-64 Where are indexers used
            // if we want to store something into session state variable then i can make use of the session object
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());
            // in Session it will take 2 type of objects i.e [int index] and [string name]
            //above is the one clasical ex where indexers are used

            ////another example of indexers used in Ado
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //using (SqlConnection con = new Sq1Connection(CS))
            //{
            //    SqlCommand cmd = new Sq1Command("Select * from tblEmployee", con);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        Response.Write("Id = " + rdr[0].ToString() + "");
            //        Response.Write("Name = " + rdr["Name"].ToString());
            //        Response.Write("<br/>)");
            //    }
            //}

            ////part-65 creating indexers
            //Company company = new Company();

            //Response.Write("Name of Employee With Id = 2:" + company[2]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee With Id = 5:" + company[5]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee With Id = 8:" + company[8]);
            //Response.Write("<br/>");

            //Response.Write("Changing names of employees with Id = 2, 5 & 8");
            //Response.Write("<br/>");
            //Response.Write("<br/>");

            //company[2] = "2nd Employee Name Changed";
            //company[5] = "5th Employee Name Changed";
            //company[8] = "8th Employee Name Changed";

            //Response.Write("Name of Employee With Id = 2:" + company[2]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee With Id = 5:" + company[5]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee With Id = 8:" + company[8]);
            //Response.Write("<br/>");

            //part-66 overloading indexers

            Company company = new Company();
            Response.Write("Before Update");
            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees = " + company["Female"]);
            
            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";
            Response.Write("After Update");
            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees = " + company["Female"]);

        }
    }
}