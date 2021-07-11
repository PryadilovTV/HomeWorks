using System;
using System.Text;
using UnityEngine;

class Task1: MonoBehaviour  //Инвертировать входящую строку
    {
        [SerializeField]
        private string incomingString = "qwertyuiop asdfghjkl zxcvbnm";
        
        [SerializeField]
        private int TRY_COUNT = 10000000; //1 млн: около 1 сек; 10 млн: 10-120 сек; 100 млн: 100-2000 сек
        delegate string Invert();            

        void Start()
        {
            Debug.Log("TRY_COUNT = " + TRY_COUNT/1000000 + " mln" + ". Incoming string: " + incomingString);
            
            //Inversion(TryString, "String"); //раз в 10 дольше остального, убрал нафиг
            Inversion(TryStringBuilderNew, "StringBuilder (append)");
            Inversion(TryStringBuilderCopy, "StringBuilder (copy)");
            Inversion(TryStringBuilderHalf, "StringBuilder (half)");
            Inversion(TryArray, "Array");
        }

        void Inversion(Func<string> invert, string discription)
        {
            var resultString = invert.Invoke();

            var startTime = System.Diagnostics.Stopwatch.StartNew();
            
            for (int i = 1; i <= TRY_COUNT; i++) resultString = invert.Invoke();
            
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
            var resultString = "";
            
            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                resultString += incomingString[i];
            }
            
            return resultString;
        }
        
        string TryStringBuilderNew()
        {
            var resultString = "";
            var sb = new StringBuilder(incomingString, incomingString.Length);
            var resultSb = new StringBuilder(incomingString.Length);
                
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                resultSb.Append(sb[i]);
            }
            resultString = resultSb.ToString();
            
            return resultString;
        }
        
        string TryStringBuilderCopy()
        {
            var resultString = "";
            var sb = new StringBuilder(incomingString, incomingString.Length);
            var resultSb = new StringBuilder(incomingString, incomingString.Length);

                for (int i = 0; i <= sb.Length - 1; i++)
                {
                    resultSb[i] = sb[sb.Length - i - 1];
                }

                resultString = resultSb.ToString();
            
            return resultString;
        }

        string TryStringBuilderHalf()
        {
            var resultString = "";
            var sb = new StringBuilder(incomingString, incomingString.Length);
            char a;

            for (int i = 0; i <= sb.Length/2; i++)
            {
                a = sb[i];
                sb[i] = sb[sb.Length - i - 1];
                sb[sb.Length - i - 1] = a;
            }

            resultString = sb.ToString();
            
            return resultString;
        }
        
        string TryArray()
        {
            var resultString = "";
            char a;
            
            Char[] chars = new Char[incomingString.Length];

            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                chars[i] = incomingString[i];
            }
            
            for (int i = 0; i <= incomingString.Length / 2; i++)
            {
                a = chars[i];
                chars[i] = chars[incomingString.Length - i - 1];
                chars[incomingString.Length - i - 1] = a;
            }

            StringBuilder sb = new StringBuilder(32);
            sb.Append(chars);
            resultString = sb.ToString();
            
            return resultString;
        }
    }
