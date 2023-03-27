using lab1.Classes;
using System.Collections.Generic;

namespace lab1
{
    public interface IDataContext
    {
        List<GraduateStudent> Students { get; set; }
        List<GraduateSupervisor> Supervisors {  get; set; } 
    }
}
