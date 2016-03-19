using Android.App;
using Android.OS;
using BindingIssue.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace BindingIssue.Droid.Views
{
    [Activity(Label = "Binding Issue", Theme = "@style/AppTheme")]
    public class MainView : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainView);

            ViewModel.ShowDefaultCommand.Execute(null);
        }
    }
}
