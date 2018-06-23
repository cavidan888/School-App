using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace School.Controller
{


    class TeacherController
    {

        public static void Create(string a , string b , int c)
        {
            Teacher teacher = new Teacher();
            teacher.Name = a;
            teacher.SurName = b;
            teacher.Age = c;

            SchoolMemberList school = new SchoolMemberList();

            school.Add(teacher);

           

        }



        public static  void Read()
        {
            //SchoolMemberList school = new SchoolMemberList();

          

            Info info = new Info();

            foreach (var item in SchoolMemberList.teacherList)
            {
                info.teachInfo.Text += item.Name + " . " + item.SurName + " . " + item.Age + "\r\n";
            }

            //((Label)info.Controls["label1"]).Text = "test";

            info.Show();

            //foreach (var item in SchoolMemberList.teacherList)
            //{


            //    info.label2.Text = item.SurName;
            //    info.label3.Text = item.Age.ToString();

            //}


        }
    }
}
