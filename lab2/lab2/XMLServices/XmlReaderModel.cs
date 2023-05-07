using lab2.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace lab2
{
    public static class XmlReaderModel
    {
        public static List<GraduateStudent> GetGraduateStudents(XmlDocument xmlDoc)
        { 
            List<GraduateStudent> graduateStudents = new List<GraduateStudent>();

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                GraduateStudent graduateStudent = new GraduateStudent()
                {
                    FullName = node.SelectSingleNode("FullName").InnerText,
                    GroupNumber = node.SelectSingleNode("GroupNumber").InnerText,
                    BirthDate = DateTime.Parse(node.SelectSingleNode("BirthDate").InnerText),
                    AverageScore = Single.Parse(node.SelectSingleNode("AverageScore").InnerText),
                    SupervisorId = Int32.Parse(node.SelectSingleNode("SupervisorId").InnerText)
                };
                
                graduateStudents.Add(graduateStudent);
            };
       
            return graduateStudents;
        }

        public static List<GraduateSupervisor> GetGraduateSupervisors(XmlDocument xmlDoc)
        {
            List<GraduateSupervisor> graduateSupervisors = new List<GraduateSupervisor>();

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                GraduateSupervisor graduateSupervisor = new GraduateSupervisor()
                {
                    Id = Int32.Parse(node.SelectSingleNode("Id").InnerText),
                    FullName = node.SelectSingleNode("FullName").InnerText,
                    Position = node.SelectSingleNode("Position").InnerText
                };

                graduateSupervisors.Add(graduateSupervisor);
            };

            return graduateSupervisors;
        }
    }
}

/*
    XmlDocument це клас, що представляє Xml документ і надає
    спосіб керувати XML даними програмним шляхом.

    XmlNode клас, що представляє окремий вузол в XML-документі.
    Має метод SelectSingleNode(string nodeName), що обирає перший XmlNode, який
    збігається з XPath виразом.
*/