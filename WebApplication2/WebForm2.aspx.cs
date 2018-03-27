using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(stringFormat( "以Split分割字串"));
            string word = "Today is sunday. I want to go to shopping";
            string[] split = word.Split(' ', ',', '.');
            foreach(string s in split)
            {
                Response.Write(s + "<br/>");
            }
            Response.Write(stringFormat("以Compare比較字串"));
            string word1 = "A";
            string word2 = "B";
            int result = string.Compare(word1, word2);
            switch (result)
            { 
                case -1:
                    Response.Write(word1 + " < " + word2 ) ;
                    break;
                case 0:
                    Response.Write(word1 + " = " + word2 );
                    break;
                case 1:
                    Response.Write(word1 + " > " + word2);
                    break;

                default:
                    break;
            }

            Response.Write(stringFormat("以Concat串聯陣列中字串"));
            string[] strArray = { "aa", "bb", "cc", "dd" };
            Response.Write(string.Concat(strArray));

            Response.Write(stringFormat("以Contain判斷是否有特定字串"));
            string string1 = "bird cat dog cow fish";
            Response.Write(string1.Contains("fish"));

            Response.Write(stringFormat("以Replace代替特定文字"));
            string message = "hello world this is the first";
            string newMessage = "second";
            Response.Write(message.Replace("first", newMessage));

            Response.Write(stringFormat("以PadLet填補字串左側長度"));
            string s1 = "a", s2 = "ab", s3 = "abc", s4 = "abcd";
            Response.Write(s1.PadLeft(10, '_') + "<br/>");
            Response.Write(s2.PadLeft(10, '_') + "<br/>");
            Response.Write(s3.PadLeft(10, '_') + "<br/>");
            Response.Write(s4.PadLeft(10, '_') + "<br/>");

            Response.Write(stringFormat("以Join串接陣列字串"));
            Response.Write(string.Join("-",strArray));

            Response.Write(stringFormat("以GetHashCode取得字串的HashCode"));
            string name = "helloname";
            Response.Write(name.GetHashCode());

            Response.Write(stringFormat("以GetEnumenator反覆讀取字串字元"));
            string Msg = "hello... my name is Hello Hello";
            IEnumerator<char> ienum = Msg.GetEnumerator();
            while (ienum.MoveNext()) {
                Response.Write(ienum.Current + "<br/>");
            }

            Response.Write(stringFormat("以 DivRem計算商數"));
            int x = 8, y = 3;
            int quotient;
            int remainder;
            quotient = Math.DivRem(x, y, out remainder);
            Response.Write(string.Format("{0} 除以 {1} = {2} 餘數 : {3}", x, y, quotient, remainder));

            Response.Write(stringFormat("以 Round 四捨五入"));
            Response.Write("Round(4.5) = " + Math.Round(4.5) + "<br/>");
            Response.Write("Round(4.4) = " + Math.Round(4.4) + "<br/>");
            Response.Write("Round(4.5) = " + Math.Round(4.6) + "<br/>");
            Response.Write("Round(5.5) = " + Math.Round(5.5) + "<br/>");

            Response.Write("Round(4.445) ToEven = " + Math.Round(4.445, 2, MidpointRounding.ToEven) + "<br/>");
            Response.Write("Round(4.445) AwayFromZero = " + Math.Round(4.445, 2, MidpointRounding.AwayFromZero) + "<br/>");

        }

        protected string stringFormat(string text) {
            return string.Format("<br/><Font color = 'Blue' ><<{0}>><br/></Font>", text);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                Response.Write("長度 : " +TextBox1.Text.Length.ToString() + "<br/>");
                Response.Write("位置2~5的子字串 : " + TextBox1.Text.Substring(2, 5) + "<br/>");
                Response.Write("大寫 : " + TextBox1.Text.ToUpper() + "<br/>");
                Response.Write("字串是否有'ee' 在第幾個位置 : " + TextBox1.Text.IndexOf("ee") + "<br/>");
                Response.Write("前後空白去除 : " + TextBox1.Text.Trim() + "<br/>");
            }
        }
    }
}