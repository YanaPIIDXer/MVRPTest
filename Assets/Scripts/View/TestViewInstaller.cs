using UnityEngine;
using Zenject;

namespace View
{

    public class TestViewInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ITestView>()
                     .To<TestView>()
                     .FromComponentInHierarchy()
                     .AsCached();
        }
    }
}
