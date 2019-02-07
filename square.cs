using UnityEngine;
using System;

public class square : MonoBehaviour
{
    public string defaultText = "Введите число";
    public string defaultText1 = "Вычислить площадь Фигуры";
    
    public string width;
    public string height;
    
    public string radius;
    
    public string a;
    public string b;
    public string c;
    
   
    public bool showCounter;
    public int counter;
    public string type = "rectangle";


    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 100, 20), "Прямоугольник"))
        {
            type = "rectangle";
            showCounter = false;
        }
        if (GUI.Button(new Rect(200, 100, 100, 20), "Круг"))
        {
            type = "circle";
            showCounter = false;
        }
        if (GUI.Button(new Rect(300, 100, 100, 20), "Треугольник"))
        {
            type = "triangle";
            showCounter = false;
        }
        
        
        GUI.Label(new Rect(220, 280, 200, 80), defaultText);

        if (type == "rectangle")
        {
            width = GUI.TextField(new Rect(200, 300, 200, 20), width, 25);
            height = GUI.TextField(new Rect(200, 330, 200, 20), height, 25);
        }
        
        if (type == "circle")
        {
            radius = GUI.TextField(new Rect(200, 300, 200, 20), radius, 25);
        }
        
        if (type == "triangle")
        {
            a = GUI.TextField(new Rect(200, 300, 200, 20), a, 25);
            b = GUI.TextField(new Rect(200, 330, 200, 20), b, 25);
            c = GUI.TextField(new Rect(200, 350, 200, 20), c, 25);
        }
        

        if (GUI.Button(new Rect(200, 380, 200, 20), defaultText1))
        {
            showCounter = true;
        }
		
        if (showCounter)
        {
            if (type == "rectangle"){
                counter = CountSquareRectangle(int.Parse(width), int.Parse(height));
            } else if (type == "circle"){
                counter = CountSquareCircle(int.Parse(radius));
            } else if (type == "triangle"){
                counter = CountSquareTriangle(int.Parse(a),int.Parse(b),int.Parse(c));
            }
            
            GUI.Label(new Rect(200, 370, 200, 80), Convert.ToString(counter));
        }
    }
    public int CountSquareRectangle(int width, int height)
    {
        return width * height;
    }
    
    public int CountSquareCircle(int radius)
    {
        return Convert.ToInt32(Math.PI ) * radius * radius;
    }
    
    public int CountSquareTriangle(int a, int b, int c)
    {
        int p = (a + b + c)/2;
        double result = Convert.ToDouble(p * (p - a) * (p - b) * (p - c));
        
        return Convert.ToInt32(Math.Sqrt(result));
    }
}
