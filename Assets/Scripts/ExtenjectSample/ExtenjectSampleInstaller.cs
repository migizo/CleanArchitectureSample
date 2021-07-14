using UnityEngine;
using Zenject;

public class ExtenjectSampleInstaller : MonoInstaller
{
  public override void InstallBindings()
  {
    Container.Bind<ExtenjectSample.ITestable>().To<ExtenjectSample.Huga>().AsCached();
  }
}

