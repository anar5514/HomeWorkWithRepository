using HomeWorkWithRepository.Commands.MainViewCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWithRepository.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public LogInCommand LogInCommand => new LogInCommand(this);
    }
}
