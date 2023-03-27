using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string GroupNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public double AverageScore { get; set; }

        public override string ToString()
        {
            return $"Студент {FullName}, група {GroupNumber}, дн - {BirthDate.ToString("dd/M/yyyy")}, середнiй бал ~ {AverageScore}"; ;
        }
    }
}
