using System;

namespace QuizApp;

public class Program
{
    static void Main(string[] args)
    {
        QuizManager.Run();

        Quiz quiz = QuizManager.GetQuiz();
        Console.WriteLine(quiz.DisplayQuiz());

        Game.Start(quiz);
    }
}