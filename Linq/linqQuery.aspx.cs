using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Linq
{
    public partial class linqQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Teacher> queryResult = Teacher.GetAllTeachers().Where(student => student.Gender == "Male");

            GridView1.DataSource = queryResult;
            GridView1.DataBind();



            string strHelperName = "Inspiron";
            // string result = StringHelper.ChangeFirstLetterCase(strHelperName);


            //Console.WriteLine(result);


            strHelperName.ChangeFirstLetterCase();
            //After making class static ie static StringHelper and this string as paramenter ..we can call function as if it is in string class.

        }
    }
} 