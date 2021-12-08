using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExaminationV1
{
    interface IHighScore
    {
        public void Save(PlayerData p);
        public List<PlayerData> GetHighScore();
       
    }
}
