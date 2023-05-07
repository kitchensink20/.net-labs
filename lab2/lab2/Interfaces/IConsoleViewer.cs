using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2.Interfaces
{
    public interface IConsoleViewer
    {
        void ShowCustomXmlFileContent(IEnumerable<XElement> nodes);
        void ShowStudentHighestAverageScore(double score);
    }
}
