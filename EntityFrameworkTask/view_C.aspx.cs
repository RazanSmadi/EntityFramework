using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkTask
{

    public partial class view_C : System.Web.UI.Page
    {
        EntityFrameworkEntities o = new EntityFrameworkEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            var customers = o.Customers.ToList();
            var cities = o.Cities.ToList();

            var all = (from customer in customers
                       join city in cities
                      on customer.city equals city.cityId
                       select new
                       {
                           customer.customerid,
                           customer.customername,
                           customer.age,
                           customer.phone,
                           customer.email,
                           customer.photo,
                           city.cityName
                       }).ToList();
            GridView1.DataSource = all;
            GridView1.DataBind();


            Label1.Text = (from item in customers select item).Count().ToString();
            Label2.Text = (from item in customers select item.age).Average().ToString();
            Label3.Text = (from item in customers select item.age).Max().ToString();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            var customers = o.Customers.ToList();
            var cities = o.Cities.ToList();


            //var search = from item in customers
            //             where item.customername.Contains(s)
            //             select item;

            //var all = (from customer in search
            //           join city in cities
            //          on customer.city equals city.cityId
            //           select new
            //           {
            //               customer.customername,
            //               customer.age,
            //               customer.phone,
            //               customer.email,
            //               customer.photo,
            //               city.cityName

            //           }).ToList();

            //GridView1.DataSource = all;
            //GridView1.DataBind();

            int numericValue;
            bool isNumber = int.TryParse(s, out numericValue);

            if (!isNumber)
            {

                var search = from item in o.Customers
                             where item.customername.Contains(s)
                             select item;



                GridView1.DataSource = search.ToList();
                GridView1.DataBind();
            }
            else
            {
                var search = from item in o.Customers
                             where item.customerid == numericValue
                             select item;



                GridView1.DataSource = search.ToList();
                GridView1.DataBind();

            }

        }
    }
}