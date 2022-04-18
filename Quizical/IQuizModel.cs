namespace Quizical
{
    //Model interface for Quiz structure
    internal interface IQuizModel
    {
        // method to display Score
        public void displayScore();

        // method to check the answers sent by the user
        public void checkAnswer(int id, int answer);

        // method to store the set of questions in the stack
        public MyStack<Dictionary<int, Genre>> generateRandomQuestions();
    }
}