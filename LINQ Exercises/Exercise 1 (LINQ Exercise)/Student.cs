using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Score { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        
    }
    public class MinimalStudent
    {
        public string StudentName { get; set; } 
    }
}