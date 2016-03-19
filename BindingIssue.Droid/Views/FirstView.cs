using Android.OS;
using Android.Runtime;
using Android.Views;
using BindingIssue.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace BindingIssue.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.main_contentFrame)]
    [Register("bindingissue.droid.views.FirstView")]
    public class FirstView : MvxFragment<FirstViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View ignore = base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.FirstView, null);
        }
    }
}