using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
