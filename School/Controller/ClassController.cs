using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Controller
{
    class ClassController
    {
       
        public static void Create(string a)
        {
            Class @class = new Class();
            @class.Name = a;

            SchoolMemberList scm = new SchoolMemberList();
            scm.Add(@class);
        }

        public static void Read()
        {
            Info info = new Info();
            info.Show();

            foreach (var item in SchoolMemberList.classList)
            {
                info.classInfo.Text += item.Name + " / " + "\r\n";
            }
        }
    }
}
