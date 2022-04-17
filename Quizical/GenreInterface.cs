using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    //Interface for Genre CLasses in the quiz
    interface GenreInterface
    {

        // returns all the question specific to the genre
        public List<int> getAnswers();

        // returns all the question specific to the genre
        public List<string> getQuestions();


        // returns a dictionary with question number and genre
        public Dictionary<int, Genre> getQuestionDetails();


    }
}
