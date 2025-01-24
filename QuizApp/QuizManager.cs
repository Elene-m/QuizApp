using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public static class QuizManager
{
    private static Quiz Quiz { get; set; }
    public static void Run()
    {
        Console.Write("Quiz name: ");
        string quizName = Console.ReadLine();

        Quiz newQuiz = new Quiz(quizName);

        Console.Write("Questions count: ");
        int questionsCount = int.Parse(Console.ReadLine());

        newQuiz.QuestionsCount = questionsCount;

        Console.Write("Answer per question: ");
        int answerPerQuestion = int.Parse(Console.ReadLine());

        Console.WriteLine("*Reminder: Correct answer first");

        FillQuestionsInQuiz(newQuiz, answerPerQuestion);
        Quiz = newQuiz;
    }
    private static void FillQuestionsInQuiz(Quiz quiz, int answerPerQuestion)
    {
        for (int i = 1; i <= quiz.QuestionsCount; i++)
        {
            Console.Write($"Question {i}: ");
            string questionText = Console.ReadLine();
            Question question = new Question(questionText);

            for (int j = 1; j <= answerPerQuestion; j++)
            {
                Console.Write($"Answer {j}: ");
                string answerText = Console.ReadLine();

                bool isCorrect = j == 1;

                Answer answer = new Answer(answerText, isCorrect);

                question.AddAnswer(answer);
                //if (j == 1)
                //{
                //    Answer answer = new Answer(answerText, true);
                //}
                //else
                //{
                //    Answer answer = new Answer(answerText, false);
                //}
            }
            quiz.AddQuestion(question);
        }
    }
    public static Quiz GetQuiz()
    {
        return Quiz;
    }
}