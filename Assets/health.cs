using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
    public float currentHealth,
        healthLosingSpeed = 0.2f,
        frameCounter;
    public int secondCounter;

    // Use this for initialization
    void Start () {
        currentHealth = 100;
    }
	
	// Update is called once per frame
	void Update () {
        currentHealth = currentHealth - healthLosingSpeed * Time.deltaTime;
        countSeconds();
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Health " + Math.Round(currentHealth, 0).ToString() + " %");

    }

    void increaseLosingHealthSpeed()
    {
        if(secondCounter >= 15)
        {
            secondCounter = 0;
            healthLosingSpeed += 0.2f;
        }
    }

    void countSeconds()
    {
        frameCounter += Time.deltaTime;
        if (frameCounter >= 1)
        {
            secondCounter++;
            frameCounter = 0;
        }
    }
}
