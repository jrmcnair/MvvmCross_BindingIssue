using Android.App;
using Android.OS;
using BindingIssue.Core.ViewModels;
using BindingIssue.Droid;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace BindingExample.Droid.Views
{
    [Activity(Label = "MainView", Theme = "@style/AppTheme")]
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
