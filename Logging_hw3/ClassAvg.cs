using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_hw3
{
    static class ClassAvg
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static double CalculateStudentGradesAvg(int[] arr)
        {
            if (arr == null)
            {
                throw new NullReferenceException("Null reference exception - function 'CalculateAvg'");
            }
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    log.Warn($"Number in the array is a negative - The number is {arr[i]} in position {i}");
                }
                else if (arr[i] > 100)
                {
                    log.Warn($"Number in the array is bigger than 100 - The number is {arr[i]} in position {i}");
                }

                sum += arr[i];
            }

            return sum / arr.Length;
        }
    }
}
