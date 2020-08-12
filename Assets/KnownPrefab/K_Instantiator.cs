using System;
using KnownPrefab;
using UnityEngine;
using Zenject;

public class K_Instantiator : MonoBehaviour
{
    // Since the prefab was known in initialization phase, we don't have a public field here.

    [Inject] private K_PrefabFacade.Factory _factory;

    private void Start()
    {
        // The content of C is only known in runtime.
        var c = new C {DefinitionMaybe = 3, SomeOtherData = 5, SomeDataLikeId = "DFasdf"};
        _factory.Create(c);
    }
}