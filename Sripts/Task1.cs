using System;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace HomeWorks
{
    class Task1
    {
        private const int tryCount = 100000000; //10 млн: 1-6 сек; 100 млн: 10-120 сек; 1 млрд: 2-20 минут 
        static void Main()
        {
            //incomingString = Console.ReadLine("Введите что-нибудь");
            string incomingString = "qwertyuiop asdfghjkl zxcvbnm";
            string resultString = "";
            
            Console.WriteLine(DateTime.Now + ": " + "Incoming string: " + incomingString);

            //resultString = TryString(incomingString);
            resultString = TryStringBuilder(incomingString);
            resultString = TryArray(incomingString);

        }

        static string TryString(String incomingString)
        {
            string resultString = "";
            
            for (int k = 1; k <= tryCount; k++)
            {
                resultString = "";

                for (int i = incomingString.Length - 1; i >= 0; i--)
                {
                    resultString += incomingString[i];
                }
                
            }
            
            Console.WriteLine(DateTime.Now + ": " + "String: " + resultString);
            return resultString;
        }
        static string TryStringBuilder(String incomingString)
        {
            
            StringBuilder sb = new StringBuilder(incomingString, 32);
            StringBuilder resultSb = new StringBuilder(32);

            for (int k = 1; k <= tryCount; k++)
            {
                resultSb = new StringBuilder(32);
                
                for (int i = sb.Length - 1; i >= 0; i--)
                {
                    resultSb.Append(sb[i]);
                }

            }

            string resultString = resultSb.ToString();
            
            Console.WriteLine(DateTime.Now + ": " + "String builder: " + resultString);
            return resultString;
        }
        static string TryArray(String incomingString)
        {
            string resultString = "";
            char a;
            
            Char[] chars = new Char[incomingString.Length];

            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                chars[i] = incomingString[i];
            }

            for (int k = 1; k <= tryCount-1; k++)
            {

                for (int i = 0; i <= incomingString.Length / 2; i++)
                {
                    a = chars[i];
                    chars[i] = chars[incomingString.Length - i - 1];
                    chars[incomingString.Length - i - 1] = a;
                }
                
            }

            for (int i = 0; i <= incomingString.Length - 1; i++)
            {
                resultString += chars[i];
            }

            Console.WriteLine(DateTime.Now + ": " + "Array: " + resultString);
            return resultString;
        }
    }
}