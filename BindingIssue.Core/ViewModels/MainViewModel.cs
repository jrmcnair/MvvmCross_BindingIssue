using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace BindingIssue.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private MvxCommand _showDefaultCommand;
        public ICommand ShowDefaultCommand
        {
            get
            {
                _showDefaultCommand = _showDefaultCommand ?? new MvxCommand(DoShowDefaultCommand);
                return _showDefaultCommand;
            }
        }

        private void DoShowDefaultCommand()
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}