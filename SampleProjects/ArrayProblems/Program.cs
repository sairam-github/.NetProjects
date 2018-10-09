using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };

            OpenOrSenior(input);
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> output = new List<string>();

            if (data == null || data.Length == 0)
            {
                throw new ArgumentNullException("data is null or empty.");
            }

            int length = data.Length;

            for (int i = 0; i < length; i++)
            {
                int[] temp = data[i];

                if(temp == null || temp.Length != 2)
                {
                    throw new ArgumentNullException($"data is not proper. " +
                        $"{i}th sub-array is null or length is more than two.");
                }

                if(temp[0] >= 55 && temp[1] > 7)
                {
                    output.Add("Senior");
                    continue;
                }

                output.Add("Open");
            }

            return output;
        }
    }
}
