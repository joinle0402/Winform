using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Student
    {
        public Student(string fullName, decimal markLTGD, decimal markMMT, decimal markCSDL)
        {
            this.FullName = fullName;
            this.MarkLTGD = markLTGD;
            this.MarkMMT = markMMT;
            this.MarkCSDL = markCSDL;
        }
        public Student() {}

        public string FullName { get; set; }
        public decimal MarkLTGD { get; set; }
        public decimal MarkMMT { get; set; }
        public decimal MarkCSDL { get; set; }
    }
}
