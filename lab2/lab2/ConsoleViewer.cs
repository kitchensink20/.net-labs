using lab2.Commands;
using lab2.Interfaces;
using lab2.Models;
using lab2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace lab2
{
    public class ConsoleViewer : IConsoleViewer
    {
        public void ShowCustomXmlFileContent(IEnumerable<XElement> nodes)
        {
            foreach (var node in nodes)
            {
                Console.WriteLine(node);
            }
        }

        public void ShowStudentHighestAverageScore(double score)
        {
            Console.WriteLine("\n" + ConsoleTexts.HighestStudentScoreCommandMsg + score + ".");
        }

        public void ShowStudentData(XElement student)
        {
            Console.WriteLine("\n" + ConsoleTexts.StudentDataMessage);
            Console.WriteLine("ПІБ:\t" + student.Element("FullName").Value);
            Console.WriteLine("Група:\t" + student.Element("GroupNumber").Value);
            Console.WriteLine("Середній бал:\t" + student.Element("AverageScore").Value);
            Console.WriteLine("Дата народження:\t" + student.Element("BirthDate").Value);
            Console.WriteLine("Id керівника:\t" + student.Element("GraduateSupervisorId").Value);
        }

        public void ShowSupervisorData(XElement supervisor)
        {
            Console.WriteLine("\n" + ConsoleTexts.SupervisorDataMessage);
            Console.WriteLine("ПІБ:\t" + supervisor.Element("FullName").Value);
            Console.WriteLine("Айді:\t" + supervisor.Element("Id").Value);
            Console.WriteLine("Позиція:\t" + supervisor.Element("Position").Value);
        }

        public void ShowStudentCountFromGroup(int num)
        {
            Console.WriteLine("\n" + ConsoleTexts.StudentGroupAmountCommandMsg + num + ".");
        }

        public void ShowStudentAverageScore(double score) 
        {
            Console.WriteLine("\n" + ConsoleTexts.StudentAverageScoreMessage + score + ".");
        }

        public void ShowSupervisorsList(IEnumerable<XElement> supervisors)
        {
            Console.WriteLine();
            foreach (var supervisor in supervisors)
                Console.WriteLine(supervisor.Element("Position").Value + " " + supervisor.Element("FullName").Value + 
                    ", Id: " + supervisor.Element("Id").Value + "; ");
        }

        public void ShowStudentsList(IEnumerable<XElement> students)
        {
            Console.WriteLine();
            if (students.Count() == 0)
            {
                Console.WriteLine(ConsoleTexts.EmptyStudentListMessage);
                return;
            }
            foreach (var student in students)
                Console.WriteLine("ПІБ: " + student.Element("FullName").Value +
                    ", група: " + student.Element("GroupNumber").Value + ", ДН: "  
                    + student.Element("BirthDate").Value + ", сер. бал: " +
                    student.Element("AverageScore").Value + ", айді керівника: " +
                    student.Element("SupervisorId").Value);
        }
        public void ShowDeserializedStudentsData(IEnumerable<GraduateStudent> students)
        {
            foreach(var student in students)
                Console.WriteLine(student);
        }
        public void ShowDeserializedSupervisorsData(IEnumerable<GraduateSupervisor> supervisors)
        {
            foreach (var supervisor in supervisors)
                Console.WriteLine(supervisor);
        }
    }
}
