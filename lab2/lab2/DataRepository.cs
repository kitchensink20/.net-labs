using lab2.Interfaces;
using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace lab2
{
    public class DataRepository : IDataRepository
    {
        private readonly XDocument studentsDoc;
        private readonly XDocument supervisorsDoc;
        private readonly XDocument custStudentsDoc;
        private readonly XDocument custSupervisorsDoc;

        public DataRepository(string studentsXmlFile, string supervisorsXmlFile, string custStudentsXmlFile, string custSupervisorsXmlFile)
        {
            studentsDoc = XDocument.Load(studentsXmlFile);
            supervisorsDoc = XDocument.Load(supervisorsXmlFile);
            custStudentsDoc = XDocument.Load(custStudentsXmlFile);
            custSupervisorsDoc = XDocument.Load(custSupervisorsXmlFile);
        }

        // query 1
        public IEnumerable<XElement> GetAllCustStudentsXElements()
        {
            var result = from student in custStudentsDoc.Descendants("GraduateStudent")
                         select student;

            return result;
        }

        // query 2
        public IEnumerable<XElement> GetAllCustSupervisorsXElements()
        {
            var result = from supervisor in custSupervisorsDoc.Descendants("GraduateSupervisor")
                         select supervisor;

            return result;
        }

        // query 3
        public double GetStudentHighestAverageScore()
        {
            double result = studentsDoc.Root.Descendants("GraduateStudent")
                        .Max(student => double.Parse(student.Element("AverageScore").Value));

            return result;
        }

        // query 4
        public XElement ChangeStudentAverageScore(string fullName, double newScore)
        {
            var student = custStudentsDoc.Root.Descendants("GraduateStudent")
                        .Where(student => student.Element("FullName").Value == fullName).First();
            student.Element("AverageScore").Value = newScore.ToString();

            return student;
        }

        // query 5
        public int GetCountOfStudentsFromSelectedGroup(string groupNumber)
        {
            var result = studentsDoc.Root.Descendants("GraduateStudent")
                .Where(student => student.Element("GroupNumber").Value == groupNumber)
                .Count();

            return result;
        }

        // query 6
        public IEnumerable<XElement> SortSupervisorsByFullName()
        {
            var result = from supervisor in supervisorsDoc.Descendants("GraduateSupervisor")
                         orderby supervisor.Element("FullName").Value
                         select supervisor;

            return result;
        }

        // query 7
        public IEnumerable<XElement> GetStudentsBornInSpecifiedYear(int startYear, int endYear)
        {
            var result = from student in studentsDoc.Descendants("GraduateStudent")
                         where DateTime.Parse(student.Element("BirthDate").Value).Year >= startYear 
                                && DateTime.Parse(student.Element("BirthDate").Value).Year <= endYear
                         select student;

            return result;
        }

        // query 8
        public IEnumerable<XElement> DescSortStudentsByAverageScore()
        {
            var result = from student in studentsDoc.Descendants("GraduateStudent")
                         orderby student.Element("AverageScore").Value descending
                         select student;

            return result;
        }

        // query 9
        public XElement GetStudentDataByFullName(string fullName)
        {
            var result = custStudentsDoc.Root.Descendants("GraduateStudent")
                       .Where(student => student.Element("FullName").Value == fullName).FirstOrDefault();

            return result;
        }

        // query 10
        public IEnumerable<XElement> TakeWhileGreaterAverageScore(double averageScore)
        {
            var result = studentsDoc.Descendants("GraduateStudent")
                                    .OrderByDescending(student => double.Parse(student.Element("AverageScore").Value))
                                    .TakeWhile(student => double.Parse(student.Element("AverageScore").Value) > averageScore);

            return result;
        }

        // query 11
        public IEnumerable<XElement> Get3TopStudents()
        {
            var result = (from student in studentsDoc.Descendants("GraduateStudent")
                          orderby student.Element("AverageScore").Value descending
                          select student)
                          .Take(3);

            return result;
        }

        // query 12
        public IEnumerable<XElement> GetStudentsWithHighestScroreInGroup()
        {
            var groups = studentsDoc.Descendants("GraduateStudent").GroupBy(student => student.Element("GroupNumber").Value);

            var result = new List<XElement>();
            foreach (var group in groups)
            {
                var topStudent = group.OrderByDescending(student => student.Element("AverageScore").Value).First();
                result.Add(topStudent);
            }

            return result;
        }

        // query 13
        public XElement GetSupervisorWithLowestStudentAvScore()
        {
            var groups = studentsDoc.Descendants("GraduateStudent")
                        .GroupBy(student => student.Element("SupervisorId").Value)
                        .Select(group => new { 
                                            SupervisorId = group.Key, 
                                            AvgScore = group.Average(student => double.Parse(student.Element("AverageScore").Value))
                                          });
            var lowestGroup = groups.OrderBy(group => group.AvgScore).First();
            var result = supervisorsDoc.Descendants("GraduateSupervisor")
                            .First(s => s.Element("Id").Value == lowestGroup.SupervisorId);

            return result;
        }

        // query 14
        public IEnumerable<XElement> GetStudentsSupervisedBySpecificSupervisor(int supervisorId)
        {
            var result = studentsDoc.Descendants("GraduateStudent")
                        .Where(student => Int32.Parse(student.Element("SupervisorId").Value) == supervisorId);

            return result;
        }

        // query 15
        public IEnumerable<XElement> SkipFirstThreeSupervisors()
        {
            var result = supervisorsDoc.Descendants("GraduateSupervisor").Skip(3);

            return result;
        }

        // query 16
        public double GetAverageStudentScore()
        {
            var result = studentsDoc.Descendants("GraduateStudent").Average(student => double.Parse(student.Element("AverageScore").Value));

            return result;
        }

        // query 17
        public IEnumerable<XElement> FilterSupervisorsByStudentsAverageScore(float minValue)
        {
            var result = studentsDoc.Descendants("GraduateStudent")
                            .Where(student => float.Parse(student.Element("AverageScore").Value) >= minValue)
                            .Join(supervisorsDoc.Descendants("GraduateSupervisor"),
                            student => student.Element("SupervisorId").Value,
                            supervisor => supervisor.Element("Id").Value,
                            (student, supervisor) => supervisor).Distinct();

            return result;
        }

    }
}
