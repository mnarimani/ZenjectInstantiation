using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class B : MonoBehaviour
{
    [Inject]
    public void Init(C c)
    {
        Debug.Log("Init in B");
    }

    private void Awake()
    {
        Debug.Log("Awake in B");
    }
}
