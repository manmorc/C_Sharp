using System;
using UnityEngine;


public class TestGui : MonoBehaviour
{
    
    public string startText = "Отвечайте на вопросы выбирая правильный ответ";
    public string endText = "Поздравляю, вы прошли тест!";
    public int successAnswers;
    public int currentQuestion = 0;

    public object[] questions = new[]
    {
        new {
            Text = "Cколько лет Земле?",
            Variants = new string[] {"4,54 миллиардов", "6 тысяч"}, 
            RightIndex = 0
        },
        new {
            Text = "Земля плоская?",
            Variants = new string[] {"Да", "Нет"},
            RightIndex = 0
        },
        new {
            Text = "Какой настоящий цвет неба?",
            Variants = new string[] {"Голубое", "Фиолетовое"},
            RightIndex = 1
        }
    };
    
  

    public bool checkQuestion(int enteredIndex, int rightIndex)
    {
        currentQuestion++;
        if (enteredIndex == rightIndex)
        {
            successAnswers++;
            return true;
        }

        return false;
    }

    void OnGUI()
    {
        
        Debug.Log(questions.Length);
        for (; currentQuestion < questions.Length;)
        {
            
            //GUI.Label(new Rect(10, 10, 200, 80), questions[currentQuestion].Text);
            GUI.Label(new Rect(10, 40, 200, 80), successAnswers.ToString());
            
            Console.WriteLine(questions[currentQuestion]);
            if (GUI.Button(new Rect(10, 100, 100, 100), "Button One"))
            {
                //checkQuestion(0, questions[currentQuestion].RightIndex);
            }
            else if (GUI.Button(new Rect(150, 100, 100, 100), "Button Two"))
            {
                //checkQuestion(0, questions[currentQuestion].RightIndex);
            }
        }

        if (currentQuestion == questions.Length)
        {
            GUI.Label(new Rect(10, 40, 200, 80), endText);
        }
    }   
}