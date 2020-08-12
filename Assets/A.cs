using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class A : MonoBehaviour
{
   [Inject]
   public void Init(C c)
   {
      Debug.Log("Init in A");
   }

   private void Awake()
   {
      Debug.Log("Awake in A");
   }
}
