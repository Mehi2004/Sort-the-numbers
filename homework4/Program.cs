using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numArry = ArryOfNumber();

            double[] newArryNum = BubbleSort(numArry);

            foreach (double number in newArryNum)
            {
                Console.Write($"{number}\t");
            }
        }
        /// <summary>
        /// گرفتن عدد
        /// </summary>
        /// <returns>عدد از کاربر به صورت رشته دریافت می کند</returns>
        static string GiveNum()
        {
            string number = "";

            Console.Write("Enter your number : ");
            number = Console.ReadLine();
            return number;
        }
        /// <summary>
        /// تبدل عدد گرفته شده به دابل
        /// </summary>
        /// <param name="number"></param>
        /// <returns>در صورت عدم تبدیل عدد جدیدی میگیرد</returns>
        static double ItsDouble(string number)
        {
            //double numberDouble = 0;
            try
            {
                double numberDouble = 0;
                numberDouble = Convert.ToDouble(number);
                numberDouble = numberDouble / 1;
                return numberDouble;
            }
            catch (Exception)
            {
                Console.Write("Enter your number (just number): ");
                number = (Console.ReadLine());
                return ItsDouble(number);
            }

            // return numberDouble ;
        }
        /// <summary>
        /// مرتب کردن
        /// </summary>
        /// <param ارایه="arr"></param>
        /// <returns> ارایه مرتب شده</returns>
        static double[] BubbleSort(double[] arr)
        {
            double n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }
        /// <summary>
        /// تبدیل کردن عداد به ارایه
        /// </summary>
        /// <returns>یک ارایه ک ده عدد دابل دارد</returns>
        static double[] ArryOfNumber()
        {

            int counter = 0;
            double[] numArry = { };
            while (counter < 10)
            {
                string userNumber = GiveNum();
                double userNumberDouble = ItsDouble(userNumber);


                Array.Resize(ref numArry, numArry.Length + 1);
                numArry[numArry.Length - 1] = userNumberDouble;
                counter++;

            }

            return numArry;
        }



    }

}
