using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task5
{
    public class Window2 : Windows
    {
        private static Window2 instance;
        public string uid = "23456";
        public static Window2 GetInstance()
        {
            if (instance == null)
            {
                instance = new Window2();
            }

            return instance;
        }
    
    }

}