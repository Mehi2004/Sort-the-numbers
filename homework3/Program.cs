namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your word : ");
            string userWord = Console.ReadLine();
            //while (usreWord.Length < 5)
            //{

            //    Console.Write("enter your word : (It must have 5 Chars) ");
            //    usreWord = Console.ReadLine();

            //}
            userWord = MoreThan5Char(userWord);

            Console.WriteLine($"your 5 right chars are {RightSide(userWord)}");
            Console.WriteLine($"your 5 left chars are {LeftSide(userWord)}");
        }
        /// <summary>
        /// کمتر از پنج تا کارکتر نمی پذیرد
        /// </summary>
        /// <param name="text"></param>
        /// <returns>رشته بیشتر از پنج کارکتر می دهد</returns>
        static string MoreThan5Char(string text)
        {
            while (text.Length < 5)
            {

                Console.Write("enter your word : (It must have 5 Chars) ");
                text = Console.ReadLine();
                
            }
            return text;
        }
        /// <summary>
        /// جدا کننده سمت راست
        /// </summary>
        /// <param name="text"></param>
        /// <returns>نوشتن 5 کارکتر اخر</returns>
        static string RightSide(string text)
        {
            int len = text.Length;
            var rightChar = text.Substring(len - 5, 5);
            return rightChar;
        }
        /// <summary>
        /// جدا کننده سمت چپ
        /// </summary>
        /// <param name="text"></param>
        /// <returns>نوشتن 5 کاراکتر اول</returns>
        static string LeftSide(string text) 
        {
            int len = text.Length;
            var leftChars = text.Substring(0, 5);
            return leftChars;
        }
    
        
        
    }

}
