using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2.Interfaces
{
    public interface IDataRepository
    {
        IEnumerable<XElement> GetAllCustStudentsXElements();
        IEnumerable<XElement> GetAllCustSupervisorsXElements();
        double GetStudentHighestAverageScore();
        XElement ChangeStudentAverageScore(string fullName, double newScore);
        XElement GetStudentDataByFullName(string fullName);
        int GetCountOfStudentsFromSelectedGroup(string groupNumber);
        IEnumerable<XElement> SortSupervisorsByFullName();
        IEnumerable<XElement> DescSortStudentsByAverageScore();
        IEnumerable<XElement> GetStudentsBornInSpecifiedYear(int startYear, int endYear);
        //IDictionary<XElement, int> GroupStudentsBySupervisorId();
        IEnumerable<XElement> Get3TopStudents();
        IEnumerable<XElement> GetStudentsWithHighestScroreInGroup();
        XElement GetSupervisorWithLowestStudentAvScore();
        IEnumerable<XElement> GetStudentsSupervisedBySpecificSupervisor(int supervisorId);
        IEnumerable<XElement> SkipFirstThreeSupervisors();
        double GetAverageStudentScore();
        IEnumerable<XElement> FilterSupervisorsByStudentsAverageScore(float minValue);
    }
}
