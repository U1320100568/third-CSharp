using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List<Student> students = new List<Student>()
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores = new List<int>{97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores = new List<int>{75, 84, 91, 39}},
            new Student{ First = "Sven", Last="Mortensen", ID= 113, Scores= new List<int>{ 88, 94, 65, 91} }
        };
        List<string> strArray = new List<string>()
        {
            "aaa","bbb","ccc","ddd","eee"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int size = rnd.Next(16, 36);
            Label1.Font.Size = FontUnit.Point(size);

            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            Label1.ForeColor = System.Drawing.Color.FromArgb(r, g, b);

            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Label1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            var studentsToXml = new XElement("Root",
                from student in students
                let x = String.Format("{0},{1},{2},{3}", student.Scores[0], student.Scores[1], student.Scores[2], student.Scores[3])
                select new XElement("student",
                    new XElement("First", student.First),
                    new XElement("Last", student.Last),
                    new XElement("Scores", x)
                    )
                );
            Response.Write(studentsToXml);
            var query =
                from student in students
                let sumScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select sumScore;
            double avgScore = query.Average();
            Response.Write("<br/><br/>Classroom avg score: " + avgScore);
            Response.Write("<br/>某些查詢方法只能用方法語法，查詢語法沒有");
            Response.Write("<br/>另外使用 let 識別項也可以儲存運算式結果");

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            double[] radii = { 1, 2, 3 };

            IEnumerable<string> query =
                from rad in radii
                select String.Format("Area = {0}", rad * rad * 3.14);
            foreach (string i in query)
            { Response.Write(i+"<br/>"); }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            var query =
                from student in students
                select new { name = student.First + " " + student.Last, id = student.ID };
            foreach (var item in query)
            {
                Response.Write(item+"<br/>");
            }

            

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            IEnumerable<int> numquery = numbers.Where(num => num % 2 == 0).OrderBy(num => num);
            foreach(int i in  numquery)
            {
                Response.Write(i+" ");
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            var query2 =
                from str in strArray
                group str by str[0] into strGroup
                orderby strGroup.Key
                select strGroup;
            foreach (var strGroup in query2)
            {
               Response.Write("[ "+strGroup.Key + " ]<br/>");
              
                foreach (var item in strGroup)
                {
                    Response.Write(item + "<br/>");
                }
               
            }
        Response.Write("group .. by.. into.. <br/>查詢語法會轉換成運算子擴充方法");
        }
    }
}