using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_hw3
{
    class Program
    {

        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("The result is: " + ClassDivide.DivideFunc(10, 2));
                Console.WriteLine("The result is: " + ClassDivide.DivideFunc(5, 0));
            }
            catch (Exception e)
            {

                log.Error(e.Message);
            }

            try
            {
                Console.WriteLine("The result is: " + ClassAvg.CalculateStudentGradesAvg(new int[] { 80, 70, 15, -50, 100 }));
                Console.WriteLine("The result is: " + ClassAvg.CalculateStudentGradesAvg(new int[] { 80, 70, 15, 60, 75 }));
                Console.WriteLine("The result is: " + ClassAvg.CalculateStudentGradesAvg(null));
            }
            catch (Exception e)
            {

                log.Error(e.Message);
            }
        }
    }
}
