using lab1.Classes;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public interface IDataService
    {
        IEnumerable<GraduateStudent> GetStudents();
        IEnumerable<GraduateSupervisor> GetSupervisors();
        IEnumerable<GraduateStudent> OrderStudentsByAverageScore();
        IEnumerable<GraduateStudent> FilterStudentsByAverageScore(float minValue);
        IEnumerable<GraduateSupervisor> FilterSupervisorsByStudentsAverageScore(float minValue);
        IEnumerable<GraduateStudent> FilterStudentsByBirthYear(int minYear, int maxYear);
        double AverageStudentScore();
        IEnumerable<IGrouping<string, GraduateStudent>> GroupStudentsByGroupNumber();
        IEnumerable<GraduateSupervisor> SkipFirstThreeSupervisors();
        IEnumerable<StudentSupervisorNamesInnerJoin> JoinStudentAndSupervisorNames();
        IEnumerable<GraduateStudent> GetStudentsSupervisedBySpecificSupervisor(int supervisorId);
        IEnumerable<GraduateStudent> GetStudentsWithSameSupervisor(string studentName);
        IEnumerable<GraduateStudent> FindStudentWithMaxScore();
        IEnumerable<GraduateSupervisor> GetSupervisersWithStudentSurnameStartWithChar(string letter);
        IEnumerable<IGrouping<int, GraduateStudent>> GroupStudentsBySupervisorsSortByBD();
        IEnumerable<GraduateStudent> AllStudentsHaveSupervisor();
        GraduateSupervisor GetSupervisorWithLowestStudentAvScore();
        IEnumerable<GraduateStudent> Get3TopStudents();
        IEnumerable<StudentNameSupervisorPosition> GetStudentsAndSupervisorPosition();
        IEnumerable<GraduateStudent> GetStudentsWithName(string name);
        IEnumerable<GraduateStudent> GetStudentsWithHighestScroreInGroup();
    }
}
