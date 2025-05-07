using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class BaseUI : MonoBehaviour
{

    protected UIManager uIManager;
    public virtual void Init(UIManager uIManager)
    { 
      this.uIManager = uIManager;

    }

    
}
