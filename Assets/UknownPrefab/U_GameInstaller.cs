using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Zenject.Internal;

public class U_GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindFactory<Object, C, U_PrefabFacade, U_PrefabFacade.Factory>().FromFactory<CustomFactory>();
    }
}

public class CustomFactory : IFactory<Object, C, U_PrefabFacade>
{
    private DiContainer _container;

    public CustomFactory(DiContainer container)
    {
        _container = container;
    }

    public U_PrefabFacade Create(Object prefab, C c)
    {
        // This is marchingninja's solution:
        var instance = (GameObject) Object.Instantiate(prefab);
        var components = new List<MonoBehaviour>();
        ZenUtilInternal.GetInjectableMonoBehavioursUnderGameObject(instance, components);
        foreach (MonoBehaviour component in components)
        {
            _container.Inject(component, new[] {c});
        }

        return instance.GetComponent<U_PrefabFacade>();
    }
}