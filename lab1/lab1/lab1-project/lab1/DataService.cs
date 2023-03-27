using lab1.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace lab1
{
    public class DataService : IDataService
    {
        public DataService(IDataContext dataContext)  
        {
            this.dataContext = dataContext;
        }

        private IDataContext dataContext;

        public IEnumerable<GraduateStudent> GetStudents()
        {
            var query1 = dataContext.Students.Select(student => student);
            // var query1 = from student in dataContext.Students
            // select student;

            return query1;
        }

        public IEnumerable<GraduateSupervisor> GetSupervisors()
        {
            var query2 = from supervisor in dataContext.Supervisors
                         select supervisor;
            // var query2 = dataContext.Supervisors.Select(supervisor => supervisor);

            return query2;
        }

        public IEnumerable<GraduateStudent> OrderStudentsByAverageScore()
        {
            var query3 = from student in dataContext.Students
                         orderby student.AverageScore descending
                         select student;
            // var query3 = dataContext.Students.OrderByDescending(student => student.AverageScore);

            return query3;
        }

        public IEnumerable<GraduateStudent> FilterStudentsByAverageScore(float minValue)
        {
            var query4 = dataContext.Students.Where(student => student.AverageScore >= minValue);
            //var query4 = from student in dataContext.Students
            // where student.AverageScore => minValue
            // select student

            return query4;
        }

        public IEnumerable<GraduateSupervisor> FilterSupervisorsByStudentsAverageScore(float minValue)
        {
            var query5 = dataContext.Students.Where(student => student.AverageScore >= minValue)
                            .Join(dataContext.Supervisors,
                            student => student.SupervisorId,
                            supervisor => supervisor.Id,
                            (student, supervisor) => supervisor).Distinct();
            //var query5 = (from student in dataContext.Students
                         //join supervisor in dataContext.Supervisors
                         //on student.SupervisorId equals supervisor.Id
                         //where student.AverageScore >= minValue
                         //select supervisor).Distinct();

            return query5;
        }

        public IEnumerable<GraduateStudent> FilterStudentsByBirthYear(int minYear, int maxYear)
        {
            var query6 = from student in dataContext.Students
                         where student.BirthDate.Year >= minYear && student.BirthDate.Year <= maxYear
                         orderby student.BirthDate descending
                         select student;
            // var query6 = dataContext.Students.Where(student => student.BirthDate.Year >= minYear && student.BirthDate.Year <= maxYear).OrderByDescending(student => student.BirthDate);

            return query6;
        }

        public double AverageStudentScore()
        {
            var query7 = dataContext.Students.Average(student => student.AverageScore);

            return query7;
        }

        public IEnumerable<IGrouping<string, GraduateStudent>> GroupStudentsByGroupNumber()
        {
            var query8 = dataContext.Students.OrderBy(student => student.GroupNumber).GroupBy(student => student.GroupNumber);
            // var query8 = from student in dataContext.Students
            // orderby student.GroupNumber
            // group student by student.GroupNumber;

            return query8;
        }

        public IEnumerable<GraduateSupervisor> SkipFirstThreeSupervisors()
        {
            var query9 = dataContext.Supervisors.Skip(3);

            return query9;
        }

        public IEnumerable<StudentSupervisorNamesInnerJoin> JoinStudentAndSupervisorNames()
        {
            var query10 = from student in dataContext.Students
                          join supervisor in dataContext.Supervisors
                          on student.SupervisorId equals supervisor.Id
                          select new StudentSupervisorNamesInnerJoin
                          {
                              StudentName = student.FullName,
                              SupervisorName = supervisor.FullName
                          };

            //var query10 = dataContext.Students.Join(
                            //dataContext.Supervisors,
                            //student => student.SupervisorId,
                            //supervisor => supervisor.Id,
                            //(student, supervisor) => new StudentSupervisorNamesInnerJoin
                            //{
                            //StudentName = student.FullName,
                            //SupervisorName = supervisor.FullName
                            //});

            return query10;
        }

         public IEnumerable<GraduateStudent> GetStudentsSupervisedBySpecificSupervisor(int supervisorId)
         {
            var query11 = dataContext.Students.Where(student =>  student.SupervisorId == supervisorId);
            //var query11 = from student in dataContext.Students
                          //where student.SupervisorId == supervisorId
                          //select student;
          
             return query11;
         }

        public IEnumerable<GraduateStudent> GetStudentsWithSameSupervisor(string studentName)
        {
            var chosenStudent = dataContext.Students.FirstOrDefault(student => student.FullName == studentName);

            if (chosenStudent != null)
            {
                var query12 = from student in dataContext.Students
                              where student.SupervisorId == chosenStudent.SupervisorId
                              && student.FullName != chosenStudent.FullName
                              select student;
                // var query12 = dataContext.Students.Where(student => student.SupervisorId == chosenStudent.SupervisorId
                // && student.FullName != chosenStudent.FullName);

                return query12;
            }

            return null;
        }

        public IEnumerable<GraduateStudent> FindStudentWithMaxScore()
        {
            double maxScore = dataContext.Students.Max(student => student.AverageScore);

            var query13 = dataContext.Students.Where(student => student.AverageScore == maxScore);
            // var query13 = from student in dataContext.Students
            // where student.AverageScore == maxScore
            // select student;

            return query13;
        }

        public IEnumerable<GraduateSupervisor> GetSupervisersWithStudentSurnameStartWithChar(string letter)
        {
            var query14 = from student in dataContext.Students
                          join supervisor in dataContext.Supervisors
                          on student.SupervisorId equals supervisor.Id
                          where student.FullName.StartsWith(letter)
                          select supervisor;
            // var query14 = dataContext.Supervisors.Where(supervisor => supervisor.Students.Any(student => student.FullName.StartsWith(letter)));

            return query14;
        }

        public IEnumerable<IGrouping<int, GraduateStudent>> GroupStudentsBySupervisorsSortByBD()
        {
            //var query15 = dataContext.Students.OrderBy(student => student.BirthDate).GroupBy(student => student.GraduateSupervisor);
            var query15 = from student in dataContext.Students
                          join supervisor in dataContext.Supervisors
                          on student.SupervisorId equals supervisor.Id
                          orderby student.BirthDate
                          group student by student.SupervisorId;
       
            return query15;
        }

        public IEnumerable<GraduateStudent> AllStudentsHaveSupervisor()
        {
            bool haveSupervisor = dataContext.Students.All(student => student.SupervisorId != 0);
            if (haveSupervisor)
                return Enumerable.Empty<GraduateStudent>();
            else
                return from student in dataContext.Students
                       where student.SupervisorId == 0
                       select student;
            // return dataContext.Students.Where(student => student.GraduateSupervisor == null);    
        }

        public GraduateSupervisor GetSupervisorWithLowestStudentAvScore()
        {
            var groups = dataContext.Students.GroupBy(s => s.SupervisorId)
                     .Select(g => new { SupervisorId = g.Key, AvgScore = g.Average(s => s.AverageScore) });
            var lowestGroup = groups.OrderBy(g => g.AvgScore).First();
            var query17 = dataContext.Supervisors.FirstOrDefault(s => s.Id == lowestGroup.SupervisorId);

            return query17;
        }

        public IEnumerable<GraduateStudent> Get3TopStudents()
        {
            var query18 = (
                    from student in dataContext.Students
                    orderby student.AverageScore descending
                    select student
                ).Take(3);
            // var query18 = dataContext.Students.OrderByDescending(student => student.AverageScore).Take(3);

            return query18;
        }

        public IEnumerable<StudentNameSupervisorPosition> GetStudentsAndSupervisorPosition()
        {
            var query19 = from student in dataContext.Students
                          join supervisor in dataContext.Supervisors
                          on student.SupervisorId equals supervisor.Id
                          select new StudentNameSupervisorPosition
                          {
                              StudentName = student.FullName,
                              SupervisorPosition = supervisor.Position
                          };

            return query19;
        }

        public IEnumerable<GraduateStudent> GetStudentsWithName(string name)
        {
            var query20 = dataContext.Students.Where(student => student.FullName.Contains(name));

            return query20;
        }

        public IEnumerable<GraduateStudent> GetStudentsWithHighestScroreInGroup()
        {
            var groups = dataContext.Students.GroupBy(student => student.GroupNumber);

            var query21 = new List<GraduateStudent>();
            foreach (var group in groups)
            {
                var topStudent = group.OrderByDescending(student => student.AverageScore).FirstOrDefault();
                query21.Add(topStudent);
            }

            return query21;
        }
    }
}
