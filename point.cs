using System;
using UnityEngine;

public class point : MonoBehaviour {
	void Start () {
        Debug.Log("START");
        StartPoint first = new StartPoint(2.2, 5.5);
        StartPoint second = new StartPoint(10.2, 15.5);
        StartPoint third = new StartPoint(18.2, 55.5);

        Debug.Log(first.ToString());
        Debug.Log(second.ToString());

        Debug.Log("Расстояние от A до B " + first.Find(second).ToString());
        Triangle triangle = new Triangle(first, second, third);
        Debug.Log("Площадь треугольника: " + triangle.square.ToString());
    }
	
	void Update () {
        Debug.Log("FRAME");
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 40, 200, 80), "from OnGui");
    }

    
}

public class StartPoint
{
    public StartPoint(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
    internal double X { get; set; }
    internal double Y { get; set; }

    public double Find(StartPoint anotherPoint)
    {
        return Math.Sqrt(
            Math.Pow(anotherPoint.X - this.X, 2) +
            Math.Pow(anotherPoint.Y - this.Y, 2)
        );
    }
}

public class Triangle
{
    public Triangle(StartPoint firstPoint, StartPoint secondPoint, StartPoint thirdPoint)
    {
        double a = firstPoint.Find(secondPoint);
        double b = secondPoint.Find(thirdPoint);
        double c = thirdPoint.Find(firstPoint);
        double p = (a + b + c) / 2;

        this.square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    internal double square { get; set; }
}