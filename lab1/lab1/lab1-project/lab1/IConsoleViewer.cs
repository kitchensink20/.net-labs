using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public interface IConsoleViewer
    {
        void ShowAllStudents(IEnumerable<Student> students);
        void ShowAllSupervisors(IEnumerable<GraduateSupervisor> supervisors);
        void ShowStudentsOrderedByAverageScore(IEnumerable<Student> students);
        void ShowStudentsFilteredByAverageScore(IEnumerable<Student> students);
        void ShowSupervisorsFilteredByStudentAverageScore(IEnumerable<GraduateSupervisor> supervisors);
        void ShowStudentsFilderedByBirthYear(IEnumerable<Student> students);
        void ShowAverageStudentScore(double averageScore);
        void ShowStudentsGroupedByGroupNumber(IEnumerable<IGrouping<string, Student>> studentGroups);
        void ShowSupervisorsSkipFirstThree(IEnumerable<GraduateSupervisor> supervisors);
        void ShowJoinedStudentSupervisorNames(IEnumerable<StudentSupervisorNamesInnerJoin> joinedStudentAndSupervisorNames);
        void GetStudentsSupervisedBySpecificSupervisor(IEnumerable<GraduateStudent> students);
        void ShowStudentsWithSameSupervisor(IEnumerable<GraduateStudent> students);
        void ShowStudentWithMaxScore(IEnumerable<Student> students);
        void ShowSupervisersWithStudentSurnameStartWithChar(IEnumerable<GraduateSupervisor> supervisors);
        void ShowStudentsGroupedBySupervisorsSortedByBD(IEnumerable<IGrouping<int, GraduateStudent>> studentGroups);
        void ShowIfAllStudentsHaveSupervisor(IEnumerable<GraduateStudent> studentsNoSupervisor);
        void ShowSupervisorWithLowestStudentAvScore(GraduateSupervisor supervisor);
        void ShowTop3Students(IEnumerable<Student> students);
        void ShowStudentAndSupervisorPosition(IEnumerable<StudentNameSupervisorPosition> students);
        void ShowStudentsWithName(IEnumerable<Student> students);
        void ShowStudentsWithHighestScoreInGroup(IEnumerable<Student> students);
    }
}
