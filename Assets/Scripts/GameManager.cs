using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager: MonoBehaviour {

    public GameManager gm;
    public GameObject player;
    public Ball2 ball;
    public InCupLevelLoad level;
    public string levelToLoad;
    public int totalScore;

    private Scene currentScene;
    private string sceneName;
    private EndGameScore endGameScore;
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        ball = player.GetComponent<Ball2>();
        level = player.GetComponent<InCupLevelLoad>();
        currentScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Start" || sceneName == "Lose")
        {
            endGameScore = GameObject.Find("Number").GetComponent<EndGameScore>();
            endGameScore.SendEndGameScore(totalScore);
            Destroy(gameObject);
        }
	}

    private string GetScoreName(int strokes)
    {
        return "yay";
    }
}
