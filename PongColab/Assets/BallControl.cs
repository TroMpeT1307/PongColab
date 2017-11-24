using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {


    public Rigidbody2D rb;
    public float speed = 10;
    public float ballSpeed = 100;
    // Use this for initialization
    void Start ()
    {
        
        transform.position = new Vector2(0, 0);

        Invoke("GoBall", 2.0f);

    }
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Player")
        {
            rb.velocity = new Vector2(rb.velocity.x, GetComponent<Rigidbody2D>().velocity.y / 2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y / 3);

            AudioSource audio = GetComponent<AudioSource>();
            audio.pitch = Random.Range(0.8f, 1.2f);
            audio.Play();

        }
	}
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        float xVel = rb.velocity.x;
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {

            if (xVel > 0)
            {
                rb.velocity = new Vector2(20, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-20, rb.velocity.y);
            }

        }
    }

    public void GoBall()
    {
        double randNum = Random.Range(0, 2);
        rb = GetComponent<Rigidbody2D>();
        if (randNum <= 0.5)
        {
            rb.AddForce(new Vector2(ballSpeed, 10));
            Debug.Log("Right");

        }
        else
        {
            rb.AddForce(new Vector2(-ballSpeed, -10));
            Debug.Log("Left");
        }
    }

    void ResetBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
        Invoke("GoBall", 2.0f);

    }
}
