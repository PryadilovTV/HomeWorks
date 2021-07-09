using System;
using System.Text;
using UnityEngine;

class Task1 : MonoBehaviour //Инвертировать входящую строку
    {
        public string incomingString = "qwertyuiop asdfghjkl zxcvbnm";
        
        private const int TRY_COUNT = 10000000; //10 млн: 2-10 сек; 100 млн: 10-120 сек; 1 млрд: 2-20 минут
        delegate string Invert();            

        void Start()
        {
            Debug.Log("TRY_COUNT = " + TRY_COUNT + ". Incoming string: " + incomingString);
            
            //Inversion(TryString, "String"); //раз в 10 дольше остального, убрал нафиг
            Inversion(TryStringBuilderNew, "StringBuilder (append)");
            Inversion(TryStringBuilderCopy, "StringBuilder (copy)");
            Inversion(TryArray, "Array");
        }

        void Inversion(Func<string> invert, string discription)
        {
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            
            var resultString = invert.Invoke();
            
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:000}",
                                                resultTime.Minutes, 
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            
            Debug.Log(elapsedTime + ": " + discription + ". Result: " + resultString);
        }
        
        public string TryString()
        {
            string resultString = "";
            
            for (int k = 1; k <= TRY_COUNT; k++)
            {
                resultString = "";

                for (int i = incomingString.Length - 1; i >= 0; i--)
                {
                    resultString += incomingString[i];
                }
                
            }
            
            return resultString;
        }
        string TryStringBuilderNew()
        {
            StringBuilder sb = new StringBuilder(incomingString, 32);
            StringBuilder resultSb = new StringBuilder(32);

            for (int k = 1; k <= TRY_COUNT; k++)
            {
                resultSb = new StringBuilder(32);
                
                for (int i = sb.Length - 1; i >= 0; i--)
                {
                    resultSb.Append(sb[i]);
                }
            }

            string resultString = resultSb.ToString();
            
            return resultString;
        }
        
        string TryStringBuilderCopy()
        {
            
            StringBuilder sb = new StringBuilder(incomingString, 32);
            StringBuilder resultSb = new StringBuilder(incomingString, 32);

            for (int k = 1; k <= TRY_COUNT; k++)
            {
                for (int i = 0; i <= sb.Length - 1; i++)
                {
                    resultSb[i] = sb[sb.Length - i - 1];
                }

            }

            string resultString = resultSb.ToString();
            
            return resultString;
        }

        string TryArray()
        {
            string resultString = "";
            char a;
            
            Char[] chars = new Char[incomingString.Length];

            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                chars[i] = incomingString[i];
            }

            for (int k = 1; k <= TRY_COUNT-1; k++)
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
            
            return resultString;
        }
    }
