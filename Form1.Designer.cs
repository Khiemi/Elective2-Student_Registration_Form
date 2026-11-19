namespace Student_Registration_Form
{
    partial class Form1
    {
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

      
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.textboxStudentid = new System.Windows.Forms.TextBox();
            this.textboxStudentName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboboxCourse = new System.Windows.Forms.ComboBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(253, 227);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(50, 16);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Course";
            
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(253, 277);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(69, 16);
            this.labelFeedback.TabIndex = 3;
            this.labelFeedback.Text = "Feedback";
            this.labelFeedback.Click += new System.EventHandler(this.label4_Click);
            
            this.textboxStudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxStudentid.Location = new System.Drawing.Point(392, 135);
            this.textboxStudentid.Name = "textboxStudentid";
            this.textboxStudentid.Size = new System.Drawing.Size(121, 24);
            this.textboxStudentid.TabIndex = 4;
             
            this.textboxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxStudentName.Location = new System.Drawing.Point(392, 175);
            this.textboxStudentName.Name = "textboxStudentName";
            this.textboxStudentName.Size = new System.Drawing.Size(121, 24);
            this.textboxStudentName.TabIndex = 5;
            
            this.comboboxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCourse.FormattingEnabled = true;
            this.comboboxCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSIS"});
            this.comboboxCourse.Location = new System.Drawing.Point(392, 217);
            this.comboboxCourse.Name = "comboboxCourse";
            this.comboboxCourse.Size = new System.Drawing.Size(121, 26);
            this.comboboxCourse.TabIndex = 6;
            
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSave.Location = new System.Drawing.Point(256, 324);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(88, 39);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Location = new System.Drawing.Point(425, 324);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(88, 39);
            this.ButtonClear.TabIndex = 8;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
           
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(250, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Registration Form";
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.comboboxCourse);
            this.Controls.Add(this.textboxStudentName);
            this.Controls.Add(this.textboxStudentid);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.TextBox textboxStudentid;
        private System.Windows.Forms.TextBox textboxStudentName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboboxCourse;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label label3;
    }
}