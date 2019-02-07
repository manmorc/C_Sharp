using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Dot coords = new Dot(1.2f, 2.2f);
        coords.Drow();
    }
}

public class Dot
{
    float x;
    float y;

    public Dot( float x,  float y ){
        this.x = x;
        this.y = y;
    }

    public void Drow()
    {
        Debug.Log($"Координаты: {x} {y}");
    }
}