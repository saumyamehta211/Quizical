using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    //Prototype class
    abstract class GenrePrototype
    {
        public abstract GenrePrototype Clone();
    } 

    internal class GenreBiology : GenrePrototype, GenreInterface
    {
        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();

        public GenreBiology() 
        {
            questionBank.Add(1, new Genre("Question : How many hairs does the average person have on their head? 1) Approximately 25,000 \t  2) Approx. 125,000  \t  3) Approx. 1,125,000", 2));
            questionBank.Add(2, new Genre("Question : How many bones make up our whole skeleton? 1) 206 \t 2) 306 \t 3) 406", 1));
            questionBank.Add(3, new Genre("Question : Which type of blood cells help our bodies to fight infection? 1) White blood cells \t 2) Red blood cells  \t 3) Both red and white blood cells", 1));
            questionBank.Add(4, new Genre("Question : Approximately how many times does your heart beat every 24 hours? 1) 1000 times  \t 2) 10,000 times  \t 3) 100,000 times", 3));
            questionBank.Add(5, new Genre("Question : The average adult human brain weighs about ……? 1) 1.5kg \t 2) 2.5kg \t 3) 3.5kg ", 1));
        }

        public override GenrePrototype Clone()
        {
            return this.MemberwiseClone() as GenreBiology;
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
