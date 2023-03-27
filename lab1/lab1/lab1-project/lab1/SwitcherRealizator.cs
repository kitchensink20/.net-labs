using lab1.Properties;
using System;

namespace lab1
{
    public class SwitcherRealizator : ISwitcherRealizator
    {
        IConsoleViewer consoleViewer;
        IDataService dataService;

        public SwitcherRealizator(IConsoleViewer consoleViewer, IDataService dataService)
        {
            this.consoleViewer = consoleViewer;
            this.dataService = dataService;
        }

        public void Switch()
        {
            while (true)
            {
                Console.WriteLine("\n" + ConsoleTexts.StartMessage);

                int option;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out option))
                {
                    if (input == "exit")
                        break;
                    Console.WriteLine(ConsoleTexts.InputErrorMessage);
                    continue;
                }
                if (option < 0 || option > 21)
                {
                    Console.WriteLine(ConsoleTexts.InputErrorMessage);
                    continue;
                }

                switch (option)
                {
                    case 1:
                        var result1 = dataService.GetStudents();
                        consoleViewer.ShowAllStudents(result1);
                        break;
                    case 2:
                        var result2 = dataService.GetSupervisors();
                        consoleViewer.ShowAllSupervisors(result2);
                        break;
                    case 3:
                        var result3 = dataService.OrderStudentsByAverageScore();
                        consoleViewer.ShowStudentsOrderedByAverageScore(result3);
                        break;
                    case 4:
                        var result4 = dataService.FilterStudentsByAverageScore(90);
                        consoleViewer.ShowStudentsFilteredByAverageScore(result4);
                        break;
                    case 5:
                        var result5 = dataService.FilterSupervisorsByStudentsAverageScore(95);
                        consoleViewer.ShowSupervisorsFilteredByStudentAverageScore(result5);
                        break;
                    case 6:
                        var result6 = dataService.FilterStudentsByBirthYear(2000, 2002);
                        consoleViewer.ShowStudentsFilderedByBirthYear(result6);
                        break;
                    case 7:
                        var result7 = dataService.AverageStudentScore();
                        consoleViewer.ShowAverageStudentScore(result7);
                        break;
                    case 8:
                        var result8 = dataService.GroupStudentsByGroupNumber();
                        consoleViewer.ShowStudentsGroupedByGroupNumber(result8);
                        break;
                    case 9:
                        var result9 = dataService.SkipFirstThreeSupervisors();
                        consoleViewer.ShowSupervisorsSkipFirstThree(result9);
                        break;
                    case 10:
                        var result10 = dataService.JoinStudentAndSupervisorNames();
                        consoleViewer.ShowJoinedStudentSupervisorNames(result10);
                        break;
                    case 11:
                        var result11 = dataService.GetStudentsSupervisedBySpecificSupervisor(2);
                        consoleViewer.GetStudentsSupervisedBySpecificSupervisor(result11);
                        break;
                    case 12:
                        var result12 = dataService.GetStudentsWithSameSupervisor("Литовченко Алiна Олександрiвна");
                        consoleViewer.ShowStudentsWithSameSupervisor(result12);
                        break;
                    case 13:
                        var result13 = dataService.FindStudentWithMaxScore();
                        consoleViewer.ShowStudentWithMaxScore(result13);
                        break;
                    case 14:
                        var result14 = dataService.GetSupervisersWithStudentSurnameStartWithChar("Л");
                        consoleViewer.ShowSupervisersWithStudentSurnameStartWithChar(result14);
                        break;
                    case 15:
                        var result15 = dataService.GroupStudentsBySupervisorsSortByBD();
                        consoleViewer.ShowStudentsGroupedBySupervisorsSortedByBD(result15);
                        break;
                    case 16:
                        var result16 = dataService.AllStudentsHaveSupervisor();
                        consoleViewer.ShowIfAllStudentsHaveSupervisor(result16);
                        break;
                    case 17:
                        var result17 = dataService.GetSupervisorWithLowestStudentAvScore();
                        consoleViewer.ShowSupervisorWithLowestStudentAvScore(result17);
                        break;
                    case 18:
                        var result18 = dataService.Get3TopStudents();
                        consoleViewer.ShowTop3Students(result18);
                        break;
                    case 19:
                        var result19 = dataService.GetStudentsAndSupervisorPosition();
                        consoleViewer.ShowStudentAndSupervisorPosition(result19);
                        break;
                    case 20:
                        var result20 = dataService.GetStudentsWithName("Алiна");
                        consoleViewer.ShowStudentsWithName(result20);
                        break;
                    case 21:
                        var result21 = dataService.GetStudentsWithHighestScroreInGroup();
                        consoleViewer.ShowStudentsWithHighestScoreInGroup(result21);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
