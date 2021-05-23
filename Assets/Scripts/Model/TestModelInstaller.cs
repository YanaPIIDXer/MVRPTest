using UnityEngine;
using Zenject;

namespace Model
{
    public class TestModelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ITestModel>()
                     .To<TestModel>()
                     .FromComponentInHierarchy()
                     .AsCached();
        }
    }
}
