using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH
{
    class SportmanManager
    {
        public static void Main()
        {
            var sportmen = new Sportman[]
                {
                    new Sportman("Leon"),
                    new Sportman("Dezső"),
                    new Sportman("Sanyi"),
                    new Sportman("Béla")
                };

            var random = new Random();

            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    sportmen[y].NewResult(random.Next(1, 10));
                }
            }

            var worldRecorder = sportmen.Where(sportman => sportman.Name == Sportman.WorldRecorder).First();

            Console.WriteLine(worldRecorder);
            Console.ReadKey();
        }

        private static Sportman CreateSportMan(string name, int[] results)
        {
            var sportMan = new Sportman(name);

            foreach (var result in results)
            {
                sportMan.NewResult(result);
            }

            return sportMan;
        }
    }
}

