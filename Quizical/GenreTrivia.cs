using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    internal class GenreTrivia : GenrePrototype, GenreInterface
    {
        GenreBiology gB =  new GenreBiology();

        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();


        public GenreTrivia()
        {
            GenreTrivia gT = (GenreTrivia)gB.Clone();
            gT.questionBank.Add(1, new Genre("Question : Who was elected President of the United States in 2017?",1));
            gT.questionBank.Add(2, new Genre("Question : When did Jonas Brothers make their comeback to the music world?", 3));
            gT.questionBank.Add(3, new Genre("Question : What is the national language of Canada?", 2));
            gT.questionBank.Add(4, new Genre("Question : A la Crecy is a French dish made of what?", 2));
            gT.questionBank.Add(5, new Genre("Question : What native country is Brazil?", 2));
        }

        public override GenrePrototype Clone()
        {
            return this.MemberwiseClone() as GenreTrivia;
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
