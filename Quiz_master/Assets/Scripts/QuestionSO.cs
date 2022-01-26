using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField]
    string question = "Enter new question";

    [SerializeField]
    string[] answers = new string[4];

    [Min(0)]
    [SerializeField]
    int correctAnswerIndex;

    public string GetQuestion() {
        return this.question;
    }

    public int GetCorrectAnswerIndex() {
        return this.correctAnswerIndex;
    }

    public string GetAnswer(int index) {
        return this.answers[index];
    }
}
