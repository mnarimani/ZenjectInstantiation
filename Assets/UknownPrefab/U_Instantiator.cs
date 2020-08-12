using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class U_Instantiator : MonoBehaviour
{
    public GameObject PrefabThatIsOnlyKnownInRuntime;

    [Inject] private U_PrefabFacade.Factory _factory;

    private void Start()
    {
        // The content of C is only known in runtime.
        var c = new C {DefinitionMaybe = 3, SomeOtherData = 5, SomeDataLikeId = "DFasdf"};
        _factory.Create(PrefabThatIsOnlyKnownInRuntime, c);
    }
}