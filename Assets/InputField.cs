﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    public InputField ifUserName;
    public Text txtUserName;

    public void UserGreetongs()
    {
        Debug.Log(int.Parse(txtUserName.text)*2);
    }
}
