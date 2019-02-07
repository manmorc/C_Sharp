using System;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
	public string defaultText = "Введите число";
	public string defaultText1 = "Вычислить квадрат числа";
	public string defaultText2 = "";
	public bool showCounter;
	public int counter;


	private void OnGUI()
	{
		GUI.Label(new Rect(220, 280, 200, 80), defaultText);

		defaultText2 = GUI.TextField(new Rect(200, 300, 200, 20), defaultText2, 25);

		if (GUI.Button(new Rect(200, 330, 200, 20), defaultText1))
		{
			showCounter = true;
		}
		
		if (showCounter)
		{
			counter = int.Parse(defaultText2);
			counter = counter * counter;
			GUI.Label(new Rect(200, 350, 200, 80), Convert.ToString(counter));
		}

	}
}
