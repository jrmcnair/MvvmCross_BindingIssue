using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace BindingIssue.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        private MvxCommand _showSecondViewCommand;
        public ICommand ShowSecondViewCommand
        {
            get
            {
                _showSecondViewCommand = _showSecondViewCommand ?? new MvxCommand(DoShowSecondViewCommand);
                return _showSecondViewCommand;
            }
        }

        private void DoShowSecondViewCommand()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
