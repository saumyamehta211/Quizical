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
        public Dictionary<Genre, int> questionBank = new Dictionary<Genre, int>();

        public GenreBiology() 
        {
            
        }

        public override GenrePrototype Clone()
        {

            Console.WriteLine("blahblahblah");
            return this.MemberwiseClone() as GenreBiology;
        }

        public void getAnswers()
        {
            throw new NotImplementedException();
        }

        public void getQuestions()
        {
            
        }
    }
}
