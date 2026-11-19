using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Form 
{
    
    public class Person 
    {
        public string Name { get; set; } 

        public Person(string name) 
        {
            Name = name; 
        }

        public virtual string GetSummary() 
        {
            return $"Person: {Name}"; 
        }
    }
}