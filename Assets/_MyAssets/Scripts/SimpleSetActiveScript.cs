﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSetActiveScript : MonoBehaviour {

    public void SetActive()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
