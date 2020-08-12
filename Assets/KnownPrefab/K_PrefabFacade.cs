using UnityEngine;
using Zenject;

namespace KnownPrefab
{
    public class K_PrefabFacade : MonoBehaviour
    {
        public class Factory : PlaceholderFactory<C, K_PrefabFacade>
        {
        }
    }
}