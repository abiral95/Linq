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
            //IEnumerable<Teacher> queryResult = Teacher.GetAllTeachers().Where(teacher => teacher.Gender == "Male");
            //GridView1.DataSource = queryResult;
            //GridView1.DataBind();

            List<Teacher> listTeachers = new List<Teacher>();

            Teacher teacher1 = new Teacher
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listTeachers.Add(teacher1);

            Teacher teacher2 = new Teacher
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listTeachers.Add(teacher2);

            Teacher teacher3 = new Teacher
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listTeachers.Add(teacher3);

            Teacher teacher4 = new Teacher
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listTeachers.Add(teacher4);

            Teacher teacher5 = new Teacher
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listTeachers.Add(teacher5);


            Func<List<Teacher>, List<Teacher>> filter = delegate (List<Teacher> t)
            {
                List<Teacher> a = new List<Teacher>();
                foreach (Teacher teach in t)
                {
                    if (teach.Gender == "Male")
                    {
                        a.Add(teach);
                    }

                }
                return a;

            };

            GridView1.DataSource = filter(listTeachers);
            GridView1.DataBind();


            string strHelperName = "Inspiron";
            // string result = StringHelper.ChangeFirstLetterCase(strHelperName);


            //Console.WriteLine(result);


            strHelperName.ChangeFirstLetterCase();
            //After making class static ie static StringHelper and this string as paramenter ..we can call function as if it is in string class.

            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = numbers.Aggregate((a, b) => a + b);
            System.Diagnostics.Debug.WriteLine(result);
            //IEnumerable<int> num =numbers.Where(x => x % 2==0);

            //GridView2.DataSource = num;
            //GridView2.DataBind();


        }
    }
} 