using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameObject player;
    public Ball2 ball;
    public Rigidbody zero;

    private Vector3 position;

    void start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        ball = player.GetComponent<Ball2>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            ball = player.GetComponent<Ball2>();
        }
        if (other.gameObject.tag == "Player")
        {
            position = ball.shotPosition;

            ball.count++;
            zero = player.GetComponent<Rigidbody>();
            zero.velocity = Vector3.zero;
            player.transform.position = position;
        }
    }
}
