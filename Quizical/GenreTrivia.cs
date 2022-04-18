using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{

    // Prototype class
    internal class GenreTrivia : GenrePrototype, GenreInterface
    {
        GenreBiology gB =  new GenreBiology();

        public Dictionary<int, Genre> questionBank = new Dictionary<int, Genre>();

        public GenreTrivia()
        {
            GenreBiology gT = (GenreBiology)gB.Clone();
            questionBank.Add(1, new Genre("Question : Who was elected President of the United States in 2017? 1) Donald Trump \t 2) Barack Obama \t 3) George Bush", 1));
            questionBank.Add(2, new Genre("Question : When did Jonas Brothers make their comeback to the music world? 1) 2015 \t 2) 2011 \t 3) 2019", 3));
            questionBank.Add(3, new Genre("Question : What is the national language of Canada? 1) English \t 2) Dutch \t 3) French", 2));
            questionBank.Add(4, new Genre("Question : A la Crecy is a French dish made of what? 1) Apples \t 2) Carrots \t 3) Potatoes", 2));
            questionBank.Add(5, new Genre("Question : What native country is Brazil? 1) South American \t 2) North American \t 3) West American", 2));
        }

        public override GenrePrototype Clone()
        {
            return this.MemberwiseClone() as GenreTrivia;
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
