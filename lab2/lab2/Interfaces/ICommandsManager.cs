using System.Collections.Generic;

namespace lab2.Interfaces
{
    public interface ICommandsManager
    {
        List<ICommand> GetCommands();
        int GetCommandsNum();
        void ExecuteCommand(int commandNumber);
        void AddCommand(ICommand command);
        void OrderCommands();
    }
}
