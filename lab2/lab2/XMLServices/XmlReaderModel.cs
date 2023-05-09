using lab2.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace lab2
{
    public class XmlReaderModel
    {
        public List<GraduateStudent> GetGraduateStudents(XmlDocument xmlDoc)
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

        public List<GraduateSupervisor> GetGraduateSupervisors(XmlDocument xmlDoc)
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
