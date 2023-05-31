using lab5.Interfaces;

namespace lab5
{
    public class Invoker
    {
        private ICommand command;

        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand() 
        {
            command.Execute();
        }
    }
}
