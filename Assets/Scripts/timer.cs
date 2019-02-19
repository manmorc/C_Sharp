using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {
    //cube vars
    public GameObject cube, MyCube;
    public float cubeSpeed = 3f;

    public enum CubeStates
    {
        right,
        left,
    }
    public CubeStates curState = CubeStates.left;

    //timer vars
    public float counter, showNumber;

    void Start()
    {
        MyCube = Instantiate(cube);

        var tmp = MyCube.GetComponent<TestComponent>();
        tmp.Say();

    }

    void Update () {
        // cube movement
        var curPosition = MyCube.transform.position.x;
        switch (curState)
        {
            case CubeStates.right:
                if (curPosition < 3)
                {
                    MyCube.transform.position = new Vector3(curPosition + cubeSpeed * Time.deltaTime, 0, 0);
                }
                else WaitAndChangeDirection();
                break;
            case CubeStates.left:
                if (curPosition > -3)
                {
                    MyCube.transform.position = new Vector3(curPosition - cubeSpeed * Time.deltaTime, 0, 0);
                }
                else WaitAndChangeDirection();
                break;
        }
    }

    void WaitAndChangeDirection()
    {
        // Timer
        if (counter <= 1)
        {
            counter += Time.deltaTime;
        }
        else
        {
            if (curState == CubeStates.left) {
                curState = CubeStates.right;
            } else
            {
                curState = CubeStates.left;
            }
            counter = 0;
        }
    }
}
