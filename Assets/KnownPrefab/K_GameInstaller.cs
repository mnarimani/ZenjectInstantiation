using System.Collections;
using System.Collections.Generic;
using KnownPrefab;
using UnityEngine;
using Zenject;

public class K_GameInstaller : MonoInstaller
{
    public GameObject Prefab;

    public override void InstallBindings()
    {
        Container.BindFactory<C, K_PrefabFacade, K_PrefabFacade.Factory>().FromSubContainerResolve()
            .ByNewContextPrefab<K_PrefabInstaller>(Prefab);
    }
}