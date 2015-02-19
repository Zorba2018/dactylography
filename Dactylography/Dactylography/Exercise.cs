using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylography
{
    [Serializable]
    public class Exercise
    {
        public string text { get; set; }
        public Statistics highScore { get; set; }
        public Statistics lastScore { get; set; }
    }
}
