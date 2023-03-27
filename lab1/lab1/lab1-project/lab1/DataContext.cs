using lab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public class DataContext : IDataContext
    {
        public List<GraduateSupervisor> Supervisors { get; set; }

        public List<GraduateStudent> Students { get; set; }
    }
}
