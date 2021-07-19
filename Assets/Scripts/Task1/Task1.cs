using System;
using System.Linq;
using System.Text;
using UnityEngine;

class Task1: MonoBehaviour  //Инвертировать входящую строку
    {
        [SerializeField]
        private string incomingString = "qwertyuiop asdfghjkl zxcvbnm";
        
        [SerializeField]
        private int tryCount = 10000000; //1 млн: около 1 сек; 10 млн: 10-120 сек; 100 млн: 100-2000 сек
        delegate string Invert();            

        void Start()
        {
            Debug.Log("tryCount = " + tryCount/1000000 + " mln" + ". Incoming string: " + incomingString);
            
            //Inversion(TryString, "String");                                   //80 сек
            Inversion(TryStringBuilderNew, "StringBuilder (append)");   //11 сек
            Inversion(TryStringBuilderCopy, "StringBuilder (copy)");    //15 сек
            Inversion(TryStringBuilderHalf, "StringBuilder (half)");    //12 сек
            Inversion(TryArray, "Array (half)");                        //9 сек
            //Inversion(TryArrayReverse, "Array (reverse)");                    //240 сек!
        }

        private void Inversion(Func<string> invert, string discription)
        {
            var resultString = "";

            var startTime = System.Diagnostics.Stopwatch.StartNew();
            
            for (int i = 1; i <= tryCount; i++) resultString = invert.Invoke();
            
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:000}",
                                                resultTime.Minutes, 
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            
            Debug.Log(elapsedTime + ": " + discription + ". Result: " + resultString);
        }
        
        private string TryString()
        {
            var resultString = "";
            
            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                resultString += incomingString[i];
            }
            
            return resultString;
        }
        
        private string TryStringBuilderNew()
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
        
        private string TryStringBuilderCopy()
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

        private string TryStringBuilderHalf()
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
        
        private string TryArray()
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
        
        private string TryArrayReverse()
        {
            var resultString = "";
            
            Char[] chars = new Char[incomingString.Length];

            for (int i = incomingString.Length - 1; i >= 0; i--)
            {
                chars[i] = incomingString[i];
            }

            Array.Reverse(chars);
            
            StringBuilder sb = new StringBuilder(32);
            sb.Append(chars);
            resultString = sb.ToString();
            
            return resultString;
        }
        
    }
