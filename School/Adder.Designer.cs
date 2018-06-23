namespace School
{
    partial class Adder
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
            this.studPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtnFromAdder = new System.Windows.Forms.Button();
            this.personAdder = new System.Windows.Forms.Button();
            this.persName = new System.Windows.Forms.TextBox();
            this.persSurName = new System.Windows.Forms.TextBox();
            this.persAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.teacherSurName = new System.Windows.Forms.TextBox();
            this.teacherAge = new System.Windows.Forms.TextBox();
            this.studPanel.SuspendLayout();
            this.classPanel.SuspendLayout();
            this.teacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studPanel
            // 
            this.studPanel.Controls.Add(this.label4);
            this.studPanel.Controls.Add(this.label2);
            this.studPanel.Controls.Add(this.label1);
            this.studPanel.Controls.Add(this.backBtnFromAdder);
            this.studPanel.Controls.Add(this.personAdder);
            this.studPanel.Controls.Add(this.persName);
            this.studPanel.Controls.Add(this.persSurName);
            this.studPanel.Controls.Add(this.persAge);
            this.studPanel.Location = new System.Drawing.Point(15, 35);
            this.studPanel.Name = "studPanel";
            this.studPanel.Size = new System.Drawing.Size(400, 265);
            this.studPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Student Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Student SurName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Name";
            // 
            // backBtnFromAdder
            // 
            this.backBtnFromAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtnFromAdder.Location = new System.Drawing.Point(235, 210);
            this.backBtnFromAdder.Name = "backBtnFromAdder";
            this.backBtnFromAdder.Size = new System.Drawing.Size(113, 37);
            this.backBtnFromAdder.TabIndex = 12;
            this.backBtnFromAdder.Text = "Back To Front";
            this.backBtnFromAdder.UseVisualStyleBackColor = true;
            this.backBtnFromAdder.Click += new System.EventHandler(this.backBtnFromAdder_Click);
            // 
            // personAdder
            // 
            this.personAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personAdder.Location = new System.Drawing.Point(235, 169);
            this.personAdder.Name = "personAdder";
            this.personAdder.Size = new System.Drawing.Size(113, 37);
            this.personAdder.TabIndex = 11;
            this.personAdder.Text = "Add";
            this.personAdder.UseVisualStyleBackColor = true;
            this.personAdder.Click += new System.EventHandler(this.personAdder_Click);
            // 
            // persName
            // 
            this.persName.Location = new System.Drawing.Point(117, 19);
            this.persName.Multiline = true;
            this.persName.Name = "persName";
            this.persName.Size = new System.Drawing.Size(231, 43);
            this.persName.TabIndex = 10;
            // 
            // persSurName
            // 
            this.persSurName.Location = new System.Drawing.Point(117, 68);
            this.persSurName.Multiline = true;
            this.persSurName.Name = "persSurName";
            this.persSurName.Size = new System.Drawing.Size(231, 42);
            this.persSurName.TabIndex = 9;
            // 
            // persAge
            // 
            this.persAge.Location = new System.Drawing.Point(117, 116);
            this.persAge.Multiline = true;
            this.persAge.Name = "persAge";
            this.persAge.Size = new System.Drawing.Size(231, 40);
            this.persAge.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Teacher Age";
            // 
            // classPanel
            // 
            this.classPanel.Controls.Add(this.label9);
            this.classPanel.Controls.Add(this.button3);
            this.classPanel.Controls.Add(this.button4);
            this.classPanel.Controls.Add(this.ClassName);
            this.classPanel.Location = new System.Drawing.Point(882, 35);
            this.classPanel.Name = "classPanel";
            this.classPanel.Size = new System.Drawing.Size(390, 265);
            this.classPanel.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Class Name";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(212, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back To Front";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(212, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(113, 22);
            this.ClassName.Multiline = true;
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(212, 43);
            this.ClassName.TabIndex = 10;
            // 
            // teacherPanel
            // 
            this.teacherPanel.Controls.Add(this.label5);
            this.teacherPanel.Controls.Add(this.label3);
            this.teacherPanel.Controls.Add(this.label6);
            this.teacherPanel.Controls.Add(this.button1);
            this.teacherPanel.Controls.Add(this.button2);
            this.teacherPanel.Controls.Add(this.teacherName);
            this.teacherPanel.Controls.Add(this.teacherSurName);
            this.teacherPanel.Controls.Add(this.teacherAge);
            this.teacherPanel.Location = new System.Drawing.Point(435, 35);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(430, 265);
            this.teacherPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Teacher SurName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Teacher Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back To Front";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(111, 17);
            this.teacherName.Multiline = true;
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(262, 43);
            this.teacherName.TabIndex = 10;
            // 
            // teacherSurName
            // 
            this.teacherSurName.Location = new System.Drawing.Point(111, 66);
            this.teacherSurName.Multiline = true;
            this.teacherSurName.Name = "teacherSurName";
            this.teacherSurName.Size = new System.Drawing.Size(262, 42);
            this.teacherSurName.TabIndex = 9;
            // 
            // teacherAge
            // 
            this.teacherAge.Location = new System.Drawing.Point(111, 114);
            this.teacherAge.Multiline = true;
            this.teacherAge.Name = "teacherAge";
            this.teacherAge.Size = new System.Drawing.Size(262, 40);
            this.teacherAge.TabIndex = 8;
            // 
            // Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 516);
            this.Controls.Add(this.classPanel);
            this.Controls.Add(this.teacherPanel);
            this.Controls.Add(this.studPanel);
            this.Name = "Adder";
            this.Text = "Adder";
            this.studPanel.ResumeLayout(false);
            this.studPanel.PerformLayout();
            this.classPanel.ResumeLayout(false);
            this.classPanel.PerformLayout();
            this.teacherPanel.ResumeLayout(false);
            this.teacherPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtnFromAdder;
        private System.Windows.Forms.Button personAdder;
        private System.Windows.Forms.TextBox persName;
        private System.Windows.Forms.TextBox persSurName;
        private System.Windows.Forms.TextBox persAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.TextBox teacherSurName;
        private System.Windows.Forms.TextBox teacherAge;
        public System.Windows.Forms.Panel classPanel;
        public System.Windows.Forms.Panel teacherPanel;
        public System.Windows.Forms.Panel studPanel;
    }
}