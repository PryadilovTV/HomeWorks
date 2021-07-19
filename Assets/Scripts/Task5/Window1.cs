using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task5
{
    public class Window1 : Windows
    {
        private static Window1 instance;
        public string uid = "12345";
        public static Window1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Window1();
            }

            return instance;
        }
    }

}