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
            questionBank.Add(1, new Genre("Question :In which Italian city can you find the Colosseum? 1) Venice \t 2) Rome \t 3) \t Naples 4) Milan", 2));
            questionBank.Add(2, new Genre("In which city is the Juventus Football Club based? 1) Turin \t 2) Barcelona \t 3) Manchester \t 4) Marseille", 1));
            questionBank.Add(3, new Genre("Which city was covered in ashes during the eruption of Mount Vesuvius in 79 AD? 1) Rome \t 2) Catania \t 3) Pompeii \t 4) Naples", 3));
            questionBank.Add(4, new Genre("In which city was Martin Luther King Jr. assassinated? 1) New York \t 2)  Austin \t 3) Miami \t  4) Memphis", 4));
            questionBank.Add(5, new Genre("In which city were the 2000 Summer Olympics held? 1) London \t 2) Paris \t 3) Barcelona \t 4)Sydney", 4));
        }

        //implementing the Interface Methods

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

        
        public Dictionary<int, Genre> getQuestionDetails()
        {
            return questionBank;
        }

    }
}
