using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormControls();
        }

        private void InitializeFormControls()
        {
            this.Text = "Student Registration";

            if (comboboxCourse.Items.Count == 0)
            {
                comboboxCourse.Items.AddRange(new object[] { "BSIT", "BSCS", "BSIS" });
            }

            comboboxCourse.SelectedIndex = -1;
            labelFeedback.Text = string.Empty;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string studentId = textboxStudentid.Text.Trim();
            string studentName = textboxStudentName.Text.Trim();
            string selectedCourse = comboboxCourse.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please enter a student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxStudentid.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a student name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxStudentName.Focus();
                return;
            }

            if (comboboxCourse.SelectedIndex == -1 || string.IsNullOrWhiteSpace(selectedCourse))
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboboxCourse.Focus();
                return;
            }

            Student student = new Student(studentId, studentName, selectedCourse);
            labelFeedback.Text = student.GetSummary();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textboxStudentid.Clear();
            textboxStudentName.Clear();
            comboboxCourse.SelectedIndex = -1;
            labelFeedback.Text = string.Empty;
            textboxStudentid.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}