using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Controller
{
    class StudentController
    {
        public static void Create(string a , string b , int c)
        {
            Student student = new Student();
            student.Name = a;
            student.SurName = b;
            student.Age = c;

            SchoolMemberList schoolMemberList = new SchoolMemberList();
            schoolMemberList.Add(student);
        }

        public static void Read()
        {
            Info info = new Info();
            foreach (var item in SchoolMemberList.studentList)
            {
                info.studentInfo.Text += item.Name + " / " + item.SurName + " / " + item.Age + "\r\n";
            }

            info.Show();
        }
    }
}
