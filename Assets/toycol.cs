﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toycol : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player") 
        {
            Destroy(gameObject);
        }
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
