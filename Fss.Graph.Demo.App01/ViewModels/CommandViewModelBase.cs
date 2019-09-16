using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.App01.ViewModels
{
    public class CommandViewModelBase<TCommand> : ViewModelBase
    {
        public CommandViewModelBase(string commandName, TCommand command)
        {
            Name = commandName;
            Command = command;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            private set { Set(ref _name, value); }
        }

        private TCommand _command;
        public TCommand Command
        {
            get { return _command; }
            set { Set(ref _command, value); }
        }
    }
}
