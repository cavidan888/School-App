namespace School
{
    partial class Choose
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
            this.addTeach = new System.Windows.Forms.Button();
            this.addClass = new System.Windows.Forms.Button();
            this.addStud = new System.Windows.Forms.Button();
            this.showTeach = new System.Windows.Forms.Button();
            this.showStud = new System.Windows.Forms.Button();
            this.showClass = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTeach
            // 
            this.addTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeach.Location = new System.Drawing.Point(59, 17);
            this.addTeach.Name = "addTeach";
            this.addTeach.Size = new System.Drawing.Size(98, 36);
            this.addTeach.TabIndex = 0;
            this.addTeach.Text = "Add Teacher";
            this.addTeach.UseVisualStyleBackColor = true;
            this.addTeach.Click += new System.EventHandler(this.addTeach_Click);
            // 
            // addClass
            // 
            this.addClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClass.Location = new System.Drawing.Point(309, 17);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(98, 36);
            this.addClass.TabIndex = 1;
            this.addClass.Text = "Add Class";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // addStud
            // 
            this.addStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStud.Location = new System.Drawing.Point(184, 17);
            this.addStud.Name = "addStud";
            this.addStud.Size = new System.Drawing.Size(98, 36);
            this.addStud.TabIndex = 2;
            this.addStud.Text = "Add Student";
            this.addStud.UseVisualStyleBackColor = true;
            this.addStud.Click += new System.EventHandler(this.addStud_Click);
            // 
            // showTeach
            // 
            this.showTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTeach.Location = new System.Drawing.Point(184, 84);
            this.showTeach.Name = "showTeach";
            this.showTeach.Size = new System.Drawing.Size(98, 36);
            this.showTeach.TabIndex = 3;
            this.showTeach.Text = "Show Teachers";
            this.showTeach.UseVisualStyleBackColor = true;
            this.showTeach.Click += new System.EventHandler(this.showTeach_Click);
            // 
            // showStud
            // 
            this.showStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStud.Location = new System.Drawing.Point(59, 84);
            this.showStud.Name = "showStud";
            this.showStud.Size = new System.Drawing.Size(98, 36);
            this.showStud.TabIndex = 4;
            this.showStud.Text = "Show Student";
            this.showStud.UseVisualStyleBackColor = true;
            this.showStud.Click += new System.EventHandler(this.showStud_Click);
            // 
            // showClass
            // 
            this.showClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showClass.Location = new System.Drawing.Point(309, 84);
            this.showClass.Name = "showClass";
            this.showClass.Size = new System.Drawing.Size(98, 36);
            this.showClass.TabIndex = 5;
            this.showClass.Text = "Show Class";
            this.showClass.UseVisualStyleBackColor = true;
            this.showClass.Click += new System.EventHandler(this.showClass_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(309, 137);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 36);
            this.back.TabIndex = 6;
            this.back.Text = "Back To front";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 191);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showClass);
            this.Controls.Add(this.showStud);
            this.Controls.Add(this.showTeach);
            this.Controls.Add(this.addStud);
            this.Controls.Add(this.addClass);
            this.Controls.Add(this.addTeach);
            this.Name = "Choose";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTeach;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.Button addStud;
        private System.Windows.Forms.Button showTeach;
        private System.Windows.Forms.Button showStud;
        private System.Windows.Forms.Button showClass;
        private System.Windows.Forms.Button back;
    }
}