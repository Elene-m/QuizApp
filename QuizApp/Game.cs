using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public static class Game
{
    public static void Start(Quiz quiz)
    {
        int questionsCount = quiz.QuestionsCount;
        int answersCount = quiz.Questions.First().Answers.Count;
        List<Question> questions = quiz.Questions;

        int correctAnswers = 0;

        for (int i = 0; i < questionsCount; i++)
        {
            Question question = questions[i];

            Console.WriteLine($"{i + 1}. {question.QuestionText}");
            List<Answer> answers = question.Answers;

            for (int j = 0; j < answersCount; j++)
            {
                Answer answer = answers[j];
                Console.WriteLine($"{j + 1}) {answers[j].AnswerText}");
            }
            Console.WriteLine("Your answer: ");
            string Curranswer = Console.ReadLine();

            bool isCorrect = CheckAnswer(question, Curranswer);
            if (isCorrect) correctAnswers++;
        }
        Console.WriteLine($"{correctAnswers}/{questionsCount}");
    }
    private static bool CheckAnswer(Question question, string curranswer)
    {
        //return question.Answers.FirstOrDefault(a => a.AnswerText == answer).IsCorrect;
        foreach (Answer answer in question.Answers)
        {
            if (answer.AnswerText == curranswer)
            {
                return answer.IsCorrect;
            }
        }
        return false;
    }
    private static List<Answer> Shuffle(List<Answer> answers)
    {
        List<Answer> newAnswersList = new List<Answer>();
        List<Answer> currentAnswersList = new List<Answer>();
        currentAnswersList.AddRange(answers);
        int lastIndex = currentAnswersList.Count - 1;
        Random random = new Random();
        int currentLastIndex = lastIndex;
        for (int i = 0; i <= lastIndex; i++)
        {
            int randomIndex=random.Next(0, currentLastIndex);
            Answer answer=currentAnswersList[randomIndex];
            newAnswersList.Add(answer);
            currentAnswersList.Remove(answer);
            currentLastIndex--;
        }
        return newAnswersList;
    }
}