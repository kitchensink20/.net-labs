using lab2.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System;

namespace lab2
{
    public class XmlSerializerModel
    {
        [XmlRoot("GraduateStudents")]
        public class GraduateStudents
        {
            [XmlElement("GraduateStudent")]
            public List<GraduateStudent> Students { get; set; }
        }

        public List<GraduateStudent> GetGraduateStudents(string filePath)
        {
            Type dataType = typeof(GraduateStudent);
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                GraduateStudents students = (GraduateStudents)xmlSerializer.Deserialize(fileStream);
                return students.Students;
            }
        }

        [XmlRoot("GraduateSupervisors")]
        public class GraduateSupervisors
        {
            [XmlElement("GraduateSupervisor")]
            public List<GraduateSupervisor> Supervisors { get; set; }
        }

        public List<GraduateSupervisor> GetGraduateSupervisors(string filePath)
        {
            Type dataType = typeof(GraduateSupervisors);
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                GraduateSupervisors supervisors = (GraduateSupervisors)xmlSerializer.Deserialize(fileStream);
                return supervisors.Supervisors;
            }
        }
    }
}

