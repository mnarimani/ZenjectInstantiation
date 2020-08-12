using UnityEngine;
using Zenject;

public class U_PrefabFacade : MonoBehaviour
{
    public class Factory : PlaceholderFactory<Object, C, U_PrefabFacade>
    {
    }
}
