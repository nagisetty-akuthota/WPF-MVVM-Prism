using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPF_MVVM_Prism.Core;
using WPF_MVVM_Prism.Modules.ModuleName.Views;

namespace WPF_MVVM_Prism.Modules.ModuleName
{
    public class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}