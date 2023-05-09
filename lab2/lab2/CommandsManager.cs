using lab2.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class CommandsManager : ICommandsManager
    {
        private List<ICommand> commands = new List<ICommand>();


        public List<ICommand> GetCommands()
        {
            return commands;
        }
        public int GetCommandsNum()
        {
            return commands.Count;
        }
        public void ExecuteCommand(int commandNumber)
        {
            commands[--commandNumber].Execute();
        }
        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void OrderCommands()
        {
            commands = commands.OrderBy(command => command.GetNumber()).ToList();
        }
    }
}
