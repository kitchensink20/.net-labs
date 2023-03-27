using System;

namespace lab1.Classes
{
    public class GraduateStudent : Student
    {
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
