using Prism.Mvvm;
using Prism.Navigation;

namespace WPF_MVVM_Prism.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
