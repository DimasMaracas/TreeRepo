using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> Q = new List<Question>();
            Random rand = new Random();
            Random rand1 = new Random();

            for (byte i=1; i <= 20; i++)
            {
                var questions = new Question()
                {
                    description = "Вопрос №" + i,
                    correct_answer = (byte)rand.Next(1, 4),
                    difficty = i / 7 == 0 ? i : (byte)rand1.Next(1,5),
                };
                Q.Add(questions);
            }                        
            

            var x = Q.Where(n => n.difficty > 3 && n.difficty < 5).ElementAt(1);
            try
            {
                foreach (var xx in x)
                {
                    Console.WriteLine(xx);
                    //Console.WriteLine(xx.description + " | " + xx.correct_answer + " | " + xx.difficty);
                }
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
                //throw;
            }
                                 

        }
    }
}
