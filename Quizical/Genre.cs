namespace Quizical
{
    public class Genre
    {
        private string question;
        private int answer;

        public string Question { get { return question; } set { question = value; } }

        public int Answer { get { return answer; } set { answer = value;} }

        public Genre(string question, int answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}