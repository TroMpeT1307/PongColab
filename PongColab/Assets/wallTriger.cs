using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wallTriger : MonoBehaviour {


    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        var wallName = transform.name; 

        if (hitInfo.name == "Ball")
        {
            GameMgr.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

        }
	}
}
