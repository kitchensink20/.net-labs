using lab2.Interfaces;
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

        public IEnumerable<XElement> GetAllCustStudentsXElements()
        {
            var query1 = from student in custStudentsDoc.Descendants("GraduateStudent")
                         select student;

            return query1;
        }

        public IEnumerable<XElement> GetAllGraduateSupervisors()
        {
            var query2 = from supervisor in custSupervisorsDoc.Descendants("GraduateSupervisor")
                         select supervisor;
            Console.Write(query2.ToList().Count);

            return query2;
        }

        public double GetStudentHighestAverageScore()
        {
            double query3 = studentsDoc.Root.Descendants("GraduateStudent")
                        .Max(student => double.Parse(student.Element("AverageScore").Value));

            return query3;
        }

        
    }
}
