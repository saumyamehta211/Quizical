using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    internal class GenreGeology : GenreInterface
    {
        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();
        public GenreGeology()
        {
            questionBank.Add(1, new Genre("Question :In which Italian city can you find the Colosseum?", 4));
            questionBank.Add(2, new Genre("In which city is the Juventus Football Club based?", 4));
            questionBank.Add(3, new Genre("Which city was covered in ashes during the eruption of Mount Vesuvius in 79 AD?", 2));
            questionBank.Add(4, new Genre("In which city was Martin Luther King Jr. assassinated?", 4));
            questionBank.Add(5, new Genre("In which city were the 2000 Summer Olympics held?", 3));
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
