using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task5
{
    public class Window2 : Window
    {
        public static Window2 Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }
    }

}