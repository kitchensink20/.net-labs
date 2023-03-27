using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public class ConsoleViewer : IConsoleViewer
    {
        public void ShowAllStudents(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв:\n");

                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowAllSupervisors(IEnumerable<GraduateSupervisor> supervisors)
        {
            if (supervisors != null && supervisors.Any())
            {
                Console.WriteLine("\nСписок керiвникiв:\n");

                foreach (var supervisor in supervisors)
                    Console.WriteLine($"{supervisor}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsOrderedByAverageScore(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("Список студентiв, впорядкованих за середнiм балом:\n");

                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("Список пуст.");
        }

        public void ShowStudentsFilteredByAverageScore(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв, бал яких більше заданого значення:\n");

                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowSupervisorsFilteredByStudentAverageScore(IEnumerable<GraduateSupervisor> supervisors)
        {
            if (supervisors != null && supervisors.Any())
            {
                Console.WriteLine("\nСписок керiвникiв, якi мають студентiв, бал яких бiльше заданого значення:\n");

                foreach (var supervisor in supervisors)
                    Console.WriteLine($"{supervisor}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsFilderedByBirthYear(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв, якi були народженi, в заданому промiжку:\n");
                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowAverageStudentScore(double averageScore)
        {
            Console.WriteLine($"\nСереднiй бал студентiв дорiвнює приблизно {averageScore.ToString("F2")}:\n");
        }

        public void ShowStudentsGroupedByGroupNumber(IEnumerable<IGrouping<string, Student>> studentGroups)
        {
            if (studentGroups != null && studentGroups.Any())
            {
                Console.WriteLine("\nСписок студентiв, згрупованих за номером групи:\n");
                foreach (var studentGroup in studentGroups)
                {
                    Console.WriteLine($"Група {studentGroup.Key}:");
                    foreach (var student in studentGroup)
                        Console.WriteLine(student);
                    Console.WriteLine();
                }
                    
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowSupervisorsSkipFirstThree(IEnumerable<GraduateSupervisor> supervisors)
        {
            if (supervisors != null && supervisors.Any())
            {
                Console.WriteLine("\nСписок керiвникiв без перших трьох:\n");
                foreach (var supervisor in supervisors)
                    Console.WriteLine(supervisor);
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowJoinedStudentSupervisorNames(IEnumerable<StudentSupervisorNamesInnerJoin> joinedStudentAndSupervisorNames)
        {
            if (joinedStudentAndSupervisorNames != null && joinedStudentAndSupervisorNames.Any())
            {
                Console.WriteLine("\nСписок студентiв та їхнiх керiвникiв:\n");
                foreach (var names in joinedStudentAndSupervisorNames)
                    Console.WriteLine(names);
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void GetStudentsSupervisedBySpecificSupervisor(IEnumerable<GraduateStudent> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентів, який керуються викладачем з заданим айді:\n");
                foreach (var student in students)
                    Console.WriteLine(student);
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsWithSameSupervisor(IEnumerable<GraduateStudent> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв, якi мають такого самого керiвника:\n");
                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentWithMaxScore(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСтудент(и) з найвищим середнiм балом:\n");
                foreach (var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowSupervisersWithStudentSurnameStartWithChar(IEnumerable<GraduateSupervisor> supervisors)
        {
            if (supervisors != null && supervisors.Any())
            {
                Console.WriteLine("\nСписок керiвникiв, якi мають хоча б одного студента, фамiлiя якого починається на задану лiтеру:\n");
                foreach (var supervisor in supervisors)
                    Console.WriteLine(supervisor);
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsGroupedBySupervisorsSortedByBD(IEnumerable<IGrouping<int, GraduateStudent>> studentGroups)
        {
            if (studentGroups != null && studentGroups.Any())
            {
                Console.WriteLine("\nСписок студентiв, сгрупованих за керiвником та вiдсортованих за датою народження:\n");
                foreach (var studentGroup in studentGroups)
                {
                    Console.WriteLine($"Керiвник {studentGroup.Key}:");
                    foreach (var student in studentGroup)
                        Console.WriteLine(student.FullName);
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowIfAllStudentsHaveSupervisor(IEnumerable<GraduateStudent> studentsNoSupervisor)
        {
            if (studentsNoSupervisor == null)
                Console.WriteLine("\nВсi студенти мають наукового керiвника.\n");
            else
            {
                Console.WriteLine("\nЄ студенти, якi не мають наукового керiвника:");
                foreach(var student in studentsNoSupervisor)
                    Console.WriteLine(student.FullName);
            }
        }

        public void ShowSupervisorWithLowestStudentAvScore(GraduateSupervisor supervisor)
        {
            if (supervisor == null)
                Console.WriteLine("\nСписок пуст.\n");
            else
                Console.WriteLine($"\nКерiвник, який має студентiв з найнижчим середнiм значенням середнiх балiв є {supervisor.FullName}.");
        }

        public void ShowTop3Students(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nТоп 3 студентiв зa найкращим балом:\n");
                for(int i = 0; i < students.ToList().Count(); i++)
                    Console.WriteLine($"{i+1}. {students.ToList()[i]}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentAndSupervisorPosition(IEnumerable<StudentNameSupervisorPosition> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентів та їхніх наукових керівників:\n");
                foreach (var student in students)
                    Console.WriteLine(student);
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsWithName(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв, якi мають задане iм'я:\n");
                foreach(var student in students)
                    Console.WriteLine($"{student}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }

        public void ShowStudentsWithHighestScoreInGroup(IEnumerable<Student> students)
        {
            if (students != null && students.Any())
            {
                Console.WriteLine("\nСписок студентiв, якi мають найвищий середнiй бал, в своїй групi:\n");
                foreach (var student in students)
                    Console.WriteLine($"Група {student.GroupNumber}, студент {student.FullName}, середнiй бал {student.AverageScore}");
            }
            else
                Console.WriteLine("\nСписок пуст.");
        }
    }
}
