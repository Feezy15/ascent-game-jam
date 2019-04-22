﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour {

	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Destroy(gameObject);
            if (collision.gameObject.name.Equals("Player1"))
            {
                GameObject.Find("Player1").GetComponent<SimplePlatformController>().SpeedUp();
            }
                
            else if (collision.gameObject.name.Equals("Player2"))
            {
                GameObject.Find("Player2").GetComponent<SimplePlatformController>().SpeedUp();
            }
                
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
