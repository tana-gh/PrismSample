using System.Windows;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using PrismSample.Lib.Views;
using PrismSample.Lib.ViewModels;
using PrismSample.Lib.Models;

namespace PrismSample.App.Main
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDialogHelper, DialogHelper>();
            containerRegistry.Register<IModel, Model>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainWindow , MainWindowViewModel>();
            ViewModelLocationProvider.Register<OperandView, OperandViewModel   >();
            ViewModelLocationProvider.Register<AnswerView , AnswerViewModel    >();
        }
    }
}
