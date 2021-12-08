using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExaminationV1
{
    class OneToHundredGame : IGame
    {
        public string Name => "1 to 100";
        public int Number { get; set; }

        public string Feedback(string guess)
        {
            if(!(guess == Number.ToString()))
            { return "Wrong answer, try again."; }
            else { return "RIGHT ANSWER!"; }
        }

        public string GetAnswer()
        {
            return Number.ToString();
        }

        public void SetUp()
        {
            Random r = new();
            Number = r.Next(0, 101);
           
        }

        public bool Validate(string guess)
        {
            return guess == Number.ToString();
        }
       
    }
}
