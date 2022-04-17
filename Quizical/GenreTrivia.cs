using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizical
{
    internal class GenreTrivia : GenrePrototype, GenreInterface
    {
        public GenreTrivia()
        {

        }

        public override GenrePrototype Clone()
        {
            return this.MemberwiseClone() as GenreTrivia;
        }

        public void getAnswers()
        {
            throw new NotImplementedException();
        }

        public void getQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
