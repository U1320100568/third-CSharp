using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(TextBox1.Text)))
            {
                int num;
                bool result = int.TryParse(TextBox1.Text, out num);
                if (result)
                {
                    Response.Write(num.ToString() + " 轉換成功");
                }
                else { Response.Write("<script>alert('請輸入數字');</script>"); }
            }
            else { Response.Write("<script>alert('輸入是空白');</script>"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //隱含轉換
            int height = 180;
            int weight = 50;

            long h = height;
            long w = weight;

            float h1 = height;
            float w1 = weight;
            Response.Write(string.Format("身高:{0}, 體重:{1} (int->long)<br/>", h, w));
            Response.Write(string.Format("身高:{0}, 體重:{1} (int->float)<br/>", h1, w1));

            //明確轉換
            string dateString = "October 12 , 2012";
            float x = 10000.8f;
            double y = 9999.3d;
            Response.Write("將string 轉換成 DateTime<br/>");
            DateTime today = Convert.ToDateTime(dateString);
            Response.Write("日期: " + today.ToLongDateString() + "<br/>");

            Response.Write("未明確轉換<br/>");
            Response.Write("x - y = " + (x - y) + "<br/>");
            Response.Write("x * y = " + (x * y) + "<br/>");

            Response.Write("明確轉換<br/>");
            Response.Write("x - y = " + ((decimal)x - (decimal)y) + "<br/>");
            Response.Write("x * y = " + ((decimal)x * (decimal)y) + "<br/>");

            if (!IsPostBack)  //IsPostBack 是重新加載或返回時=true, 加上 ! 代表第一次加載頁面
            {

                int dropDownListNum = 160;
                DropDownList1.Items.Add("=請選擇身高=");
                while (dropDownListNum<=185)
                {
                    DropDownList1.Items.Add(dropDownListNum.ToString());
                    dropDownListNum++;
                }
            }
        }
        struct Car_Struct
        {
            private int speed;
            private int power;

            public Car_Struct(int speed, int power)
            {
                this.speed = speed;
                this.power = power;
            }

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

            public int Power
            {
                get { return power; }
                set { power = value; }
            }
            public string Run()
            {
                return "my car speed=" + speed.ToString()+",power = "+power.ToString()+"<br/>";
            }
        }
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            Car_Struct myCar_st;
            myCar_st = new Car_Struct(10, 30);
            Car_Struct Car_test;
            Car_test = myCar_st;
            Response.Write("<hr>"+myCar_st.Run());
            Response.Write("複製一個struct: " + Car_test.Run());
            Car_test.Speed = 20;
            Car_test.Power = 20;
            Response.Write("原本的struct: " + myCar_st.Run());
            Response.Write("複製的struct: " + Car_test.Run());
        }

        class Car {
            private int speed;
            private int power;

            public Car(int speed, int power) {
                this.speed = speed;
                this.power = power;
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public int Power
            {
                get { return power; }
                set { power = value; }
            }
            public string Run() {
                return "my car speed = " + speed + " , power= "+power+"<br/>";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Car myCar_st;
            myCar_st = new Car(10, 30);
            Response.Write("<hr/>"+myCar_st.Run());
            Car car_test;
            car_test = myCar_st;
            Response.Write("複製一個class: " + car_test.Run());

            car_test.Speed = 20;
            car_test.Power = 20;
            Response.Write("原本的class: " + myCar_st.Run());
            Response.Write("複製的class: " + car_test.Run());
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text != "=請選擇身高=")
            {
                Response.Write("你的身高是" + DropDownList1.Text);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string[] student = new String[] { "a","b","c","d"};
            Response.Write("<hr>學生名單"+ "<ul>");
            foreach (string s in student)
            {
                Response.Write("<li>" + s + "</li>");
            }
            Response.Write("</ul>");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TestGetSet test = new TestGetSet();

            //get
            test.a = "test get";
            Response.Write("<hr/>string b return : " + test.b + "<br/>");
            //set
            test.d = "test set";
            //get & set
            test.f = "test get & set";
            test.g = "modified";
            Response.Write("string g : "+test.g+"<br/>");
        }
        

    }
    
}