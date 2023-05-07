using System;

namespace lab2.Models
{
    public class GraduateStudent
    {
        public string FullName { get; set; }

        public string GroupNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public double AverageScore { get; set; }

        public int SupervisorId { get; set; }

        public override string ToString()
        {
            string studentsToString;
            if (SupervisorId == 0)
                studentsToString = $"Студент {FullName}, група {GroupNumber}, дн - {BirthDate.ToString("dd/M/yyyy")}, середнiй бал ~ {AverageScore}, \nнауковий керiвник - вiдсутнiй";
            else
                studentsToString = $"Студент {FullName}, група {GroupNumber}, дн - {BirthDate.ToString("dd/M/yyyy")}, середнiй бал ~ {AverageScore}, \nайді наукового керiвника - {SupervisorId}";

            return studentsToString;
        }
    }
}
