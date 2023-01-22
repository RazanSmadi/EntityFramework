using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EntityFrameworkTask
{
    public partial class task : System.Web.UI.Page
    {
        EntityFrameworkEntities s = new EntityFrameworkEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var c = from City in s.Cities select City;
                DropDownList1.DataSource = c.ToList();
                DropDownList1.DataTextField = "cityName";
                DropDownList1.DataValueField = "cityID";
                DropDownList1.DataBind();

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer add = new Customer();
            add.customername = name.Text;
            add.age = Convert.ToInt32(age.Text);
            add.city = Convert.ToInt32(DropDownList1.SelectedValue);
            add.phone = Convert.ToInt32(phone.Text);
            add.email = email.Text;
            add.photo = FileUpload1.FileName;

            s.Customers.Add(add);
            s.SaveChanges();


        }
    }
}