using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    AudioSource source;

    public GameManager gm;
    public float speed = 50000;
    public Vector3 shotPosition;
    public GameObject player;
    public int count;
    public int scoreValue = 1;
    public AudioClip putter;

    private Rigidbody rb;
    private ScoreKeeper scoreKeeper;
    private ShotPowerText shotPowerText;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        count = 0;
        scoreKeeper=GameObject.Find("Score").GetComponent<ScoreKeeper>();
        shotPowerText = GameObject.Find("Power").GetComponent<ShotPowerText>();
        source = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");

        shotPowerText.SendPowerText(speed);

        if (Input.GetKey(KeyCode.UpArrow) && speed <= 80000)
        {
            speed += 500;
            shotPowerText.SendPowerText(speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && speed >= 0)
        {
            speed -= 500;
            shotPowerText.SendPowerText(speed);
        }

        if (rb.velocity == Vector3.zero)

		if (Input.GetKey (KeyCode.UpArrow)) {
			speed += 5000;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			speed -= 5000;
		}
        if (rb.velocity == Vector3.zero && count != 10)

        {
            shotPosition = player.transform.position;
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                scoreKeeper.Score(scoreValue);
                Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
                Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);

                rb.AddForce(relativeMovement * speed);
                source.PlayOneShot(putter);
                speed = 0f;
            }
        }
    }
}