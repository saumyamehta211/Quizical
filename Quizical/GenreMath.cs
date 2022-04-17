using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    internal class GenreMath : GenreInterface
    {
        // represents the genre collection containing the question and answer.
        // Question number is set in this class.
        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();


        public GenreMath()
        {
            questionBank.Add(1, new Genre("Question : What is three fifth of 100?", 4));
            questionBank.Add(2, new Genre("Question : What is the remainder of 21 divided by 7?", 4));
            questionBank.Add(3, new Genre("Question : How many years are there in a decade?", 2));
            questionBank.Add(4, new Genre("Question : What is the square of 15?", 4));
            questionBank.Add(5, new Genre("Question : In a century how many months are there?", 3));
        }


        public List<int> getAnswers()
        {           
            List<int> answers = new List<int>();
            foreach (var question in questionBank.Values)
            {
                answers = questionBank.Values.answers;
            }
            return answers;
        }

        public void getQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
