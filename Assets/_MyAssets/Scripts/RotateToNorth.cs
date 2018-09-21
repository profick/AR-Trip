using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateToNorth : MonoBehaviour
{
    public Text _text;
    private float _smoothFactor = 0.5f;


    //void Start()
    //{
    //    _text.text = "root: " + transform.rotation.eulerAngles.y;
    //    // InvokeRepeating("RotateMapIfNeeded", 2.0f, 1.0f);
    //}


    public void StartInvoke()
    {
        InvokeRepeating("RotateMapIfNeeded", 5.0f, 2.0f);
    }


    public void RotateMapIfNeeded()
    {
        float _oldAngle = transform.eulerAngles.y;
        for (int i = 0; i < 10; i++)
        {
            var x = Input.compass.trueHeading;
            var y = Camera.main.transform.eulerAngles.y - transform.eulerAngles.y;
            var newAngle = x > y ? x - y : 360 - y + x;
            _oldAngle = _oldAngle + _smoothFactor * (newAngle - _oldAngle);
        }
        transform.eulerAngles = new Vector3(0, _oldAngle, 0);
    }



    //void Update()
    //{
    //    _text.text = "root: " + transform.eulerAngles.y + "\nCamera: " + Camera.main.transform.eulerAngles.y;
    //}
}
