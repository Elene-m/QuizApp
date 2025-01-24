using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class Question
{
    public Question(string questionText)
    {
        QuestionText = questionText;
        Answers = new List<Answer>();
    }
    public string QuestionText { get; set; }
    public List<Answer> Answers { get; set; }
    public void AddAnswer(Answer answer)
    {
        Answers.Add(answer);
    }
    public void RemoveAnswer(Answer answer)
    {
        Answers.Remove(answer);
    }
    public string GetQuestionContent()
    {
        return $"\nQuestion text: {QuestionText}";
    }
}