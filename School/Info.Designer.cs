namespace School
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studinfo = new System.Windows.Forms.GroupBox();
            this.studentInfo = new System.Windows.Forms.TextBox();
            this.clasinfo = new System.Windows.Forms.GroupBox();
            this.classInfo = new System.Windows.Forms.TextBox();
            this.teacherInfo = new System.Windows.Forms.GroupBox();
            this.teachInfo = new System.Windows.Forms.RichTextBox();
            this.studinfo.SuspendLayout();
            this.clasinfo.SuspendLayout();
            this.teacherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // studinfo
            // 
            this.studinfo.Controls.Add(this.studentInfo);
            this.studinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studinfo.Location = new System.Drawing.Point(441, 101);
            this.studinfo.Name = "studinfo";
            this.studinfo.Size = new System.Drawing.Size(337, 202);
            this.studinfo.TabIndex = 3;
            this.studinfo.TabStop = false;
            this.studinfo.Text = "Student Info";
            // 
            // studentInfo
            // 
            this.studentInfo.Location = new System.Drawing.Point(6, 20);
            this.studentInfo.Multiline = true;
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(325, 176);
            this.studentInfo.TabIndex = 0;
            // 
            // clasinfo
            // 
            this.clasinfo.Controls.Add(this.classInfo);
            this.clasinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasinfo.Location = new System.Drawing.Point(814, 102);
            this.clasinfo.Name = "clasinfo";
            this.clasinfo.Size = new System.Drawing.Size(297, 197);
            this.clasinfo.TabIndex = 0;
            this.clasinfo.TabStop = false;
            this.clasinfo.Text = "Class Info";
            // 
            // classInfo
            // 
            this.classInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInfo.Location = new System.Drawing.Point(6, 20);
            this.classInfo.Multiline = true;
            this.classInfo.Name = "classInfo";
            this.classInfo.Size = new System.Drawing.Size(285, 171);
            this.classInfo.TabIndex = 0;
            // 
            // teacherInfo
            // 
            this.teacherInfo.Controls.Add(this.teachInfo);
            this.teacherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherInfo.Location = new System.Drawing.Point(97, 101);
            this.teacherInfo.Name = "teacherInfo";
            this.teacherInfo.Size = new System.Drawing.Size(295, 207);
            this.teacherInfo.TabIndex = 2;
            this.teacherInfo.TabStop = false;
            this.teacherInfo.Text = "Teacher Info";
            // 
            // teachInfo
            // 
            this.teachInfo.Location = new System.Drawing.Point(6, 20);
            this.teachInfo.Name = "teachInfo";
            this.teachInfo.Size = new System.Drawing.Size(283, 181);
            this.teachInfo.TabIndex = 4;
            this.teachInfo.Text = "";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.clasinfo);
            this.Controls.Add(this.studinfo);
            this.Controls.Add(this.teacherInfo);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.studinfo.ResumeLayout(false);
            this.studinfo.PerformLayout();
            this.clasinfo.ResumeLayout(false);
            this.clasinfo.PerformLayout();
            this.teacherInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox studinfo;
        private System.Windows.Forms.GroupBox clasinfo;
        public System.Windows.Forms.TextBox studentInfo;
        public System.Windows.Forms.TextBox classInfo;
        public System.Windows.Forms.GroupBox teacherInfo;
        public System.Windows.Forms.RichTextBox teachInfo;
    }
}