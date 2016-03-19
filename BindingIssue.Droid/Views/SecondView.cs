using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using BindingIssue.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace BindingIssue.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.main_contentFrame)]
    [Register("bindingissue.droid.views.SecondView")]
    public class SecondView : MvxFragment<SecondViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View ignore = base.OnCreateView(inflater, container, savedInstanceState);

            Log.Debug("SecondView", $"Fragment HashCode={this.GetHashCode()}");
            Log.Debug("SecondView", $"ViewModel HashCode={ViewModel.ViewModelHashCode}");
            Log.Debug("SecondView", $"DataContext HashCode={this.DataContext.GetHashCode()}");

            return this.BindingInflate(Resource.Layout.SecondView, null);
        }
    }
}