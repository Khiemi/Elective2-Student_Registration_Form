using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Form 
{ 
    public class Student : Person 
    {
        public string StudentId { get; private set; } 
        public string Course { get; set; }

        public Student(string studentId, string name, string course) : base(name) 
        {
            StudentId = studentId; 
            Course = course;
        }

        public override string GetSummary() 
        {
            return $"Saved: {StudentId} - {Name} - {Course}"; 
        }
    }
}