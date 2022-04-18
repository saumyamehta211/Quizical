using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{

    abstract class GenrePrototype
    {
        public abstract GenrePrototype Clone();
    } 

    internal class GenreBiology : GenrePrototype, GenreInterface
    {
        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();

        public GenreBiology() 
        {
            questionBank.Add(1, new Genre("Question : How many hairs does the average person have on their head?", 2));
            questionBank.Add(2, new Genre("Question : How many bones make up our whole skeleton?", 1));
            questionBank.Add(3, new Genre("Question : Which type of blood cells help our bodies to fight infection?", 1));
            questionBank.Add(4, new Genre("Question : Approximately how many times does your heart beat every 24 hours?", 3));
            questionBank.Add(5, new Genre("Question : The average adult human brain weighs about ……?", 1));
        }

        public override GenrePrototype Clone()
        {
            return this.MemberwiseClone() as GenreBiology;
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

        public Dictionary<int, Genre> getQuestionDetails()
        {
            return questionBank;
        }

    }
}
