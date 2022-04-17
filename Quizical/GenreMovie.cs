using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    internal class GenreMovie : GenreInterface
    {
        // represents the genre collection containing the question and answer.
        // Question number is set in this class.
        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();



        public GenreMovie()
        {
            questionBank.Add(1, new Genre("Question : WHAT WAS THE FIRST FEATURE-LENGTH ANIMATED MOVIE EVER RELEASED?", 2));
            questionBank.Add(2, new Genre("Question : WHAT MOVIE MUSICAL WAS SET AT RYDELL HIGH SCHOOL?", 2));
            questionBank.Add(3, new Genre("Question : IN WHAT 1976 MOVIE DOES ROBERT DE NIRO SAY THE FAMOUS LINE, “YOU TALKIN’ TO ME?”", 3));
            questionBank.Add(4, new Genre("Question : FOR WHAT MOVIE DID STEVEN SPIELBERG WIN HIS FIRST OSCAR FOR BEST DIRECTOR?", 4));
            questionBank.Add(5, new Genre("Question : WHAT WAS QUENTIN TARANTINO’S FIRST FILM AS WRITER AND DIRECTOR?", 2));
        }

        public List<int> getAnswers()
        {
            List<int> answers = new List<int>();
            foreach (Genre question in questionBank.Values)
            {
                answers.Add(question.Answer);
            }
            return answers;
        }

        public List<string> getQuestions()
        {
            List<string> Questions = new List<string>();
            foreach (Genre question in questionBank.Values)
            {
                Questions.Add(question.Question);
            }
            return Questions;
        }

        // Returns dictionary with all the specific genre details and  
        public Dictionary<int, Genre> getQuestionDetails()
        {
            return questionBank;
        }
    }
}
