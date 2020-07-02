using System;
using System.Collections;

namespace ProgAssign2.test
{
    //inherits class Test
    class Paper : Test 
    {
        string topic;
        
        //default constructor
        public Paper() 
        {
            Console.WriteLine("Enter the topic for the test :");
            topic = Console.ReadLine();
        }
        //polymorphism
        public Paper(ArrayList aa1, ArrayList aa2) 
        {
            aa1.AddRange(new string[3, 5]);
            aa2.AddRange(new string[3]);
        }

        //Functions --- overriding the abstract method--method that marks the student test
        public override int calculateScore(ArrayList memo, ArrayList user) 
        {
            //number of correct answers that the student managed to get
            int ans = 0; 

            if (memo[4].Equals(user[0]))
            {
                ans++;
            }
            else
            {
                ans = + 0;
            }
            if (memo[9].Equals(user[1]))
            {
                ans++;
            }
            else
            {
                ans = + 0;
            }
            if (memo[14].Equals(user[2]))
            {
                ans++;
            }
            else
            {
                ans = + 0;
            }

            return ans;
        }
    }
}
