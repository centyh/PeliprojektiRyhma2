﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    
    public float value;
    public abstract void OnCollect(PlayerData playerData);


}
