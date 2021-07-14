using UnityEngine;
using Zenject;

public class CounterSceneInstaller : MonoInstaller
{
  public override void InstallBindings()
  {
    // Container.Bind<IPresenter>().To<TestPresenter>().AsCached();
    // Container.Bind<IInteractor>().To<Interactor>().AsCached();



  }
}