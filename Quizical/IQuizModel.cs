namespace Quizical
{
    //Model interface
    internal interface IQuizModel
    {
        public void displayScore();
        public void checkAnswer(int id, int answer);
        public MyStack<Dictionary<int, Genre>> generateRandomQuestions();
    }
}