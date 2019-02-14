using System;
using System.Collections.Generic;
using UnityEngine;


public class TestGui : MonoBehaviour
{
    public GameObject instance;
    public GameObject toCreate;
    public List<GameObject> quaters = new List<GameObject>() { };
    public float X = 0.02f;
    public int timeCount;

    void OnGUI()
    {
        timeCount++;
        if(timeCount == 60)
        {
            quaters.Add(Instantiate(instance));
            timeCount = 0;
        }

        if(GUI.Button(new Rect(10, 10, 150, 50), "CREATE GAMEOBJECT"))
        {
            quaters.Add(Instantiate(instance));
        }

        if(GUI.Button(new Rect(200, 10, 150, 50), "DESTROY GAMEOBJECT"))
        {
            Destroy(quaters[0]);
            quaters.RemoveAt(0);
        }

        for (int i=0; i < quaters.Count; i++)
        {
            var oldPos = quaters[i].transform.position;
            if (oldPos.x >= 6)
            {
                Destroy(quaters[i]);
                quaters.RemoveAt(i);
            } else
            {
                oldPos.x += X;
                quaters[i].transform.position = oldPos;
            }
        }

        // another row

        /*
        if (GUI.Button(new Rect(10, 110, 150, 50), "MOVE LEFT GAMEOBJECT"))
        {
            RotationScript.ChangePosition(toCreate, "X", -10);
        }

        if (GUI.Button(new Rect(10, 110, 150, 50), "MOVE RIGHT GAMEOBJECT"))
        {
            RotationScript.ChangePosition(toCreate, "X", 10);
        }
        */

    }

    public void CreateObj()
    {

    }

    public void DestroyObj(GameObject instance)
    {

    }
}
