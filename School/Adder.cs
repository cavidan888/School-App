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
    public partial class Adder : Form
    {

        
        public Adder()
        {
            InitializeComponent();
            studPanel.Visible = false;
            teacherPanel.Visible = false;
            classPanel.Visible = false;
        }

        private void personAdder_Click(object sender, EventArgs e)
        {
            var a = persName.Text;
            var b = persSurName.Text;
            var c = int.Parse(persAge.Text);
            StudentController.Create(a,b,c);
            Choose choose = new Choose();
            this.Hide();
            choose.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
      

            var a = teacherName.Text;
            var b = teacherSurName.Text;
            var c = int.Parse(teacherAge.Text);
            TeacherController.Create(a, b, c);

            Choose choose = new Choose();
            this.Hide();
            choose.Show();
        }

        private void backBtnFromAdder_Click(object sender, EventArgs e)
        {
            StudentController.Read();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void studShwr_Click(object sender, EventArgs e)
        {
           ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = ClassName.Text;
            ClassController.Create(a);
            Choose choose = new Choose();
            choose.Show();
        }
    }
}
