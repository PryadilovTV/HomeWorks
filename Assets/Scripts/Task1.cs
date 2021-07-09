using System;
using System.Linq;
using System.Net.Mime;
using System.Text;
using UnityEngine;

class Task1 : MonoBehaviour //Инвертировать входящую строку
    {
        private const int tryCount = 50000000; //10 млн: 1-6 сек; 100 млн: 10-120 сек; 1 млрд: 2-20 минут 
        void Start()
        {
            
            //string incomingString = Console.ReadLine("Введите что-нибудь");
            string incomingString = "qwertyuiop asdfghjkl zxcvbnm";
            string resultString = "";
            
            Debug.Log(DateTime.Now + ": " + "Incoming string: " + incomingString);

            //resultString = TryString(incomingString); //Долго слишком
            resultString = TryStringBuilderNew(incomingString);
            resultString = TryStringBuilderCopy(incomingString);
            resultString = TryArray(incomingString);

        }

        string TryString(String incomingString)
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
            
            Debug.Log(DateTime.Now + ": " + "String: " + resultString);
            return resultString;
        }
        string TryStringBuilderNew(String incomingString)
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
            
            Debug.Log(DateTime.Now + ": " + "String builder new: " + resultString);
            return resultString;
        }
        
        string TryStringBuilderCopy(String incomingString)
        {
            
            StringBuilder sb = new StringBuilder(incomingString, 32);
            StringBuilder resultSb = new StringBuilder(incomingString, 32);

            for (int k = 1; k <= tryCount; k++)
            {
                for (int i = 0; i <= sb.Length - 1; i++)
                {
                    resultSb[i] = sb[sb.Length - i - 1];
                }

            }

            string resultString = resultSb.ToString();
            
            Debug.Log(DateTime.Now + ": " + "String builder copy: " + resultString);
            return resultString;
        }

        string TryArray(String incomingString)
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

            Debug.Log(DateTime.Now + ": " + "Array: " + resultString);
            return resultString;
        }
    }
