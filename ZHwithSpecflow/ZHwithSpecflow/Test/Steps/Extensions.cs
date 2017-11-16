using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZH;

namespace ZHwithSpecflow.Test.Steps
{
    public class Extensions
    {
        public Sportman CreateResults(Sportman sportman, int n, int m)
        {
            var random = new Random();

            for (int x = 0; x < 20; x++)
            {
                sportman.NewResult(random.Next(n, m));
            }
            return sportman;
        }

        public Sportman CreateTheHighestResults(Sportman sportman)
        {
            return CreateResults(sportman, 11, 20);
        }

        public Sportman CreateProfessionalResults(Sportman sportman)
        {
            return CreateResults(sportman, 7, 8);
        }

        public Sportman CreateAmateurResults(Sportman sportman)
        {
            return CreateResults(sportman, 1, 3);
        }

        public Sportman CreateClassResults(Sportman sportman)
        {
            return CreateResults(sportman, 16, 18);
        }
    }
}
