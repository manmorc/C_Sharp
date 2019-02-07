using System;
using UnityEngine;


public class TestGui : MonoBehaviour
{
    
    public string startText = "Отвечайте на вопросы выбирая правильный ответ";
    public string endText = "Поздравляю, вы прошли тест!";
    public int successAnswers;
    public int currentQuestion;

    public Question[] questions = new[]
    {
        new Question {
            Text = "Cколько лет Земле?",
            Variants = new string[] {"4,54 миллиардов", "6 тысяч"}, 
            RightIndex = 0
        },
        new Question {
            Text = "Земля плоская?",
            Variants = new string[] {"Да", "Нет"},
            RightIndex = 1
        },
        new Question {
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

        DrawQuestion();
          

        
    }
    
    private void DrawQuestion()
    {
        GUI.Label(new Rect(10, 10, 200, 80), questions[currentQuestion].Text);
        GUI.Label(new Rect(10, 40, 200, 80), successAnswers.ToString());

        Console.WriteLine(questions[currentQuestion]);
        if (GUI.Button(new Rect(10, 100, 200, 100), questions[currentQuestion].Variants[0]))
        {
            checkQuestion(0, questions[currentQuestion].RightIndex);
        }
        else if (GUI.Button(new Rect(250, 100, 200, 100), questions[currentQuestion].Variants[1]))
        {
            checkQuestion(1, questions[currentQuestion].RightIndex);
        }

        if (currentQuestion >= questions.Length)
        {
            GUI.Label(new Rect(10, 40, 200, 80), endText);
        }

        GUI.Label(new Rect(10, 240, 200, 80), currentQuestion.ToString());
        GUI.Label(new Rect(110, 240, 200, 80), questions.Length.ToString());

    }

}

public class Question
{
    public string Text;
    public string[] Variants;
    public int RightIndex;
}