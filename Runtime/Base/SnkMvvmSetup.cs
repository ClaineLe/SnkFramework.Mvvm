using Loxodon.Framework.Binding.Proxy.Targets;
using SnkFramework.FluentBinding.Base;

namespace SnkFramework.Mvvm.Base
{
    public abstract class SnkMvvmSetup : SnkBindingSetup
    {
        protected override TargetProxyFactory CreateTargetProxyFactory()
        {
            TargetProxyFactory targetFactory = base.CreateTargetProxyFactory();
            targetFactory.Register(new UnityTargetProxyFactory(), 10);
#if UNITY_2019_1_OR_NEWER
            targetFactory.Register(new VisualElementProxyFactory(), 30);
#endif
            return targetFactory;
        }
    }
}