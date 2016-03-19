using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace BindingIssue.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public void Init()
        {
            _fieldWithId = "First";
            _fieldWithoutId = "Second";
        }

        private string _fieldWithId;
        public string FieldWithId
        {
            get { return _fieldWithId; }
            set { SetProperty(ref _fieldWithId, value); }
        }

        private string _fieldWithoutId;
        public string FieldWithoutId
        {
            get { return _fieldWithoutId; }
            set { SetProperty(ref _fieldWithoutId, value); }
        }

        public int ViewModelHashCode => this.GetHashCode();

        private MvxCommand _showFirstViewCommand;
        public ICommand ShowFirstViewCommand
        {
            get
            {
                _showFirstViewCommand = _showFirstViewCommand ?? new MvxCommand(DoShowFirstViewCommand);
                return _showFirstViewCommand;
            }
        }

        private void DoShowFirstViewCommand()
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}
