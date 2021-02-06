using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WPF_MVVM_Prism.Modules.ModuleName;
using WPF_MVVM_Prism.Services;
using WPF_MVVM_Prism.Services.Interfaces;
using WPF_MVVM_Prism.Views;

namespace WPF_MVVM_Prism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
