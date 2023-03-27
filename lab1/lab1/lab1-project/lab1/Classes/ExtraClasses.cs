using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace lab1.Classes
{
    public class StudentSupervisorNamesInnerJoin
    {
        public string SupervisorName { get; set; }

        public string StudentName { get; set; }

        public override string ToString()
        {
            return $"Студент {StudentName}\nКерiвник {SupervisorName}\n";
        }
    }

    public class StudentNameSupervisorPosition
    {
        public string StudentName { get; set; }

        public string SupervisorPosition { get; set; }

        public override string ToString()
        {
            return $"Студент {StudentName}, позиція наукового керівника {SupervisorPosition}";
        }
    }
}
