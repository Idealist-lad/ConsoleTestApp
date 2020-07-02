using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecturer
{
    public class Class1
    {
        
        string firstName;
        string[] correctAnswer;
        //default constructor
        public Class1()
        {
            firstName = "";
            correctAnswer = new string[3];
        }
        //polymorphism
        public Class1(string name)
        {
            firstName = name;
        }
        //retuns testData
        public string[,] setTest()
        {
            //Variables
            //For lectuter to set the test
            int rows = 3;
            int cols = 4;
            string divider = "\n_________________________________________\n";

            //PROCESS
            string[,] ans = new string[3, 5];
            Console.Write(divider);
            for (int i = 0; i < rows; i++)
            {
                Console.Write(divider + "Type question {0}: ", (i + 1));
                ans[i, 0] = Console.ReadLine(); //saving the question

                //A loop for the lecturer to set the test
                for (int j = 1; j < cols; j++)
                {
                    Console.Write("Type option {0}: ", j);
                    //saving the options
                    ans[i, j] = Console.ReadLine();
                }

                Console.Write("Type the key of the correct letter from given options: ");
                ans[i, 4] = Console.ReadLine(); //saving the correct answer
                correctAnswer[i] = ans[i, 4];
            }

            //OUTPUT
            return ans;
        }

        public string[] getCorrectAns()

        {
            return correctAnswer;
        }
    }
}