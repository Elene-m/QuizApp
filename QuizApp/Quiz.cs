using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class Quiz
{
    public Quiz(string name)
    {
        Name = name;
        Questions = new List<Question>();
    }
    public string Name { get; set; }
    public List<Question> Questions { get; set; }
    public int QuestionsCount { get; set; }
    public void AddQuestion(Question question)
    {
        Questions.Add(question);
    }
    public void RemoveQuestion(Question question)
    {
        Questions.Remove(question);
    }
    public string GetQuizContent()
    {
        string content = "";
        foreach (Question question in Questions)
        {
            content += question.GetQuestionContent();
            foreach (Answer answer in question.Answers)
            {
                content += answer.GetAnswerContent();
            }
        }
        return content;
    }
    public string DisplayQuiz()
    {
        string content = $"Quiz name: {Name}";
        content += GetQuizContent();

        return content;
    }
}