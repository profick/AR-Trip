using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillText : MonoBehaviour
{

    private Text _text;



	// Use this for initialization
	void Start ()
	{
	    _text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _text.text = Input.compass.trueHeading + "\n" + Camera.main.transform.rotation.eulerAngles.y + "\n" + Input.location.lastData.latitude + "\n" +
	                 Input.location.lastData.longitude;
	}
}
