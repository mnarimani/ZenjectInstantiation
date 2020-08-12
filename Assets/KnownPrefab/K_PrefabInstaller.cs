using System.Collections;
using System.Collections.Generic;
using KnownPrefab;
using UnityEngine;
using Zenject;

public class K_PrefabInstaller : MonoInstaller
{
    [Inject] private C c;

    public override void InstallBindings()
    {
        Container.BindInstance(c);
        Container.Bind<K_PrefabFacade>().FromComponentInHierarchy().AsSingle();
    }
}
