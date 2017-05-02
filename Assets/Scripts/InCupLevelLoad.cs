using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InCupLevelLoad : MonoBehaviour {
    public GameManager gm;
    public Ball2 ball;
    public GameObject player;
    public string levelToLoad;
    public AudioClip hole;

    private AudioSource source;

	// Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (gm == null)
        {
            gm = FindObjectOfType<GameManager>();
        }
        if (ball == null)
        {
            ball = player.GetComponent<Ball2>();
        }
        if (other.gameObject.tag == "Player")
        {
            source.PlayOneShot(hole);
            gm.totalScore += ball.count;
            ball.count = 0;
            LoadNextLevel(levelToLoad);
        }
    }

    public void LoadNextLevel(string levelToLoad)
    {
        StartCoroutine(delayLoad());
    }

    IEnumerator delayLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(levelToLoad);
    }
}
