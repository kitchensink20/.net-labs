using lab1.Classes;
using System.Collections.Generic;

namespace lab1.Classes
{
    public class GraduateSupervisor 
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            string supervisorData = $"Керiвник {FullName}, позицiя {Position}, айді {Id}";
            return supervisorData;
        }
    }
}
