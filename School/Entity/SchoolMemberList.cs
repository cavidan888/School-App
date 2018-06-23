using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Controller;

namespace School
{
    class SchoolMemberList:IEnumerable
    {
        public static  Teacher[] teacherList = new Teacher[0];
        public static Student[] studentList = new Student[0];
        public static Class[] classList = new Class[0];

        int index;
        private int count;
        private int countStud;
        private int countClass;
        public int Count
        {
            get { return teacherList.Length; }
        }


        public int CountStud
        {
            get { return studentList.Length; }
        }


        public int CountClass
        {
            get { return classList.Length; }
        }

        public void Add(Teacher _str)
        {

            if (index == teacherList.Length)
            {
                Resize();
            }

            teacherList[index] = _str;
            index++;
        }


        public void Add(Student _str)
        {

            if (index == studentList.Length)
            {
                Resize();
            }

            studentList[index] = _str;
            index++;
        }



        public void Add(Class _str)
        {

            if (index == studentList.Length)
            {
                Resize();
            }

            classList[index] = _str;
            index++;
        }

        public void Resize()
        {
            var emptyArray = new Teacher[teacherList.Length + 1];
            var emptyArray2 = new Student[teacherList.Length + 1];
            var emptyArray3 = new Class[teacherList.Length + 1];
            Array.Copy(teacherList,emptyArray,teacherList.Length);
            Array.Copy(studentList, emptyArray2, studentList.Length);
            Array.Copy(classList, emptyArray3, classList.Length);
            teacherList = emptyArray;
            studentList = emptyArray2;
            classList = emptyArray3;
        }

       


        public IEnumerator GetEnumerator()
        {
            return teacherList.GetEnumerator();
           
        }

        public IEnumerator GetEnumerator2()
        {
            return studentList.GetEnumerator();

        }

        public IEnumerator GetEnumerator3()
        {
            return classList.GetEnumerator();

        }

    }
}
