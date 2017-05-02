using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShotPowerText : MonoBehaviour {
    public float Power;
    private Text myText;

    // Use this for initialization
    void Start () {
        myText = GetComponent<Text>();
	}
	
	public void SendPowerText(float shotPower)
    {
        Power = shotPower;
        myText.text = Power.ToString();
    }
}
