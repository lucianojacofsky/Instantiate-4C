﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneObjects : MonoBehaviour
{
    public GameObject objectToClone;

    public void InstantiateObject() {
        Instantiate(objectToClone);
    }

}
