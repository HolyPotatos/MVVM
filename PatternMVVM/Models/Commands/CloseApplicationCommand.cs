using PatternMVVM.Models.Commands.Base;
using System.Windows;

namespace PatternMVVM.Models.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
