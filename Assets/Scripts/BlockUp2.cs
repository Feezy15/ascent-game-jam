﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUp2 : MonoBehaviour {

   
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Destroy(gameObject);
            if (collision.gameObject.name.Equals("Player1"))
            {
                GameObject.Find("Player1").GetComponent<PlayerInventory>().AddItem(1,3);
            }
            
                
        }

    }

    void Pickup()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
