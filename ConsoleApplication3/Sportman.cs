using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH
{
    class Sportman
    {
        public static int WorldRecord;
        public static string WorldRecorder;

        private int nextResult;
        private int[] results = new int[20];
        private string name;


        public Sportman(string name)
        {
            this.name = name;
        }

        public int BestPersonalResult
        {
            get
            {
                return this.results.Max();
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string PersonalCategory
        {
            get
            {
                if (this.BestPersonalResult >= WorldRecord * 0.75)
                {
                    return "klasszis";
                }
                if (this.BestPersonalResult >= WorldRecord * 0.3)
                {
                    return "profi";
                }
                return "amatőr";
            }
        }

        /// <summary>
        /// This method calculate the latest personal best result.
        /// </summary>
        /// <param name="getResult"> an int value, which is a result  </param>
        public void NewResult(int newResult)
        {
            if (this.results.Length <= 20)
            {
                if (newResult > WorldRecord)
                {
                    Console.WriteLine("ÚJ VILÁGREKORD!!!");
                    Console.WriteLine("{0} eredménye: {1}", this.name, newResult);
                    Console.WriteLine("");
                    WorldRecord = newResult;
                    WorldRecorder = this.name;
                }
                this.results[this.nextResult] = newResult;
                this.nextResult++;
            }

        }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();

            resultBuilder.AppendFormat("{0} eredményei: ", this.name);

            bool notFirst = false;
            foreach (var result in results)
            {
                if (result > 0)
                {
                    if (notFirst)
                    {
                        resultBuilder.Append(", ");
                    }

                    notFirst = true;

                    resultBuilder.Append(result.ToString());
                }
            }

            resultBuilder.AppendLine();
            resultBuilder.AppendFormat("Legjobb eredménye: {0}", this.BestPersonalResult);
            resultBuilder.AppendLine();
            resultBuilder.AppendFormat("Kategóriája: {0}", this.PersonalCategory);


            return resultBuilder.ToString();
        }
    }
}
