using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour {

    private Text myText;

	// Use this for initialization
	void Start () {
        myText = GetComponent<Text>();
	}
	
	public void SendEndGameScore(int FinalScore)
    {
        myText.text = FinalScore.ToString(); 
    }
	
}
