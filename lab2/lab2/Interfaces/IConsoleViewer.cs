using System.Collections.Generic;
using System.Xml.Linq;

namespace lab2.Interfaces
{
    public interface IConsoleViewer
    {
        void ShowCustomXmlFileContent(IEnumerable<XElement> nodes);
        void ShowStudentHighestAverageScore(double score);
        void ShowStudentData(XElement student);
        void ShowSupervisorData(XElement supervisor);
        void ShowStudentCountFromGroup(int num);
        void ShowSupervisorsList(IEnumerable<XElement> supervisors);
        void ShowStudentsList(IEnumerable<XElement> students);
        void ShowStudentAverageScore(double score);
    }
}
