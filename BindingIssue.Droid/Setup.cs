using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.Fragging.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace BindingIssue.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        { }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var fragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(fragmentsPresenter);

            return fragmentsPresenter;
        }
    }
}
