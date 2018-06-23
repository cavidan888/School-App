using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Controller;

namespace School
{
    public partial class Choose : Form
    {
        Adder adder = new Adder();


        public Choose()
        {
            InitializeComponent();
            this.Width = 482;
            this.Height = 232;
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void addStud_Click(object sender, EventArgs e)
        {
            this.Hide();
            adder.Show();
            adder.studPanel.Visible = true;
           
            
        }

        private void addTeach_Click(object sender, EventArgs e)
        {
            
            adder.Show();
            adder.teacherPanel.Visible = true;
        }

        private void addClass_Click(object sender, EventArgs e)
        {
          
            adder.Show();
            adder.classPanel.Visible = true;
        }

        private void showClass_Click(object sender, EventArgs e)
        {
            ClassController.Read();
        }

        private void showStud_Click(object sender, EventArgs e)
        {
            StudentController.Read();
        }

        private void showTeach_Click(object sender, EventArgs e)
        {
            
            

            TeacherController.Read();
        }
    }
}
