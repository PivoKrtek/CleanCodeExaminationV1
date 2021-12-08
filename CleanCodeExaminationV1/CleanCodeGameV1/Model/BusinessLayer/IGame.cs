using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExaminationV1
{
    public interface IGame
    {
        public string Name { get; }
        public void SetUp();
        public string GetAnswer();
        public bool Validate(string guess);
        public string Feedback(string guess);
       

        //public List<PlayerData> GetHighScore();

    }
}
