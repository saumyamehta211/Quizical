using System;

namespace Quizical
{
    internal class Quiz
    {
        private IQuizModel quizModel;
        private int quizId;

        //Quiz Constructor
        public Quiz(string quizModel)
        {
            QuizModelFactory craftModelFactory = QuizModelFactory.GetInstance();
            this.quizModel = craftModelFactory.GetQuizModel(quizModel);
        }
        //to string method
        public override string ToString()
        {
            return string.Format("{0} Quiz selected", quizModel);
        }

        //launch method to write quiz details to console
        public void Play()
        {
           Console.WriteLine(this.ToString());
        }
    }
}