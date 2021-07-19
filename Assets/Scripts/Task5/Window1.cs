using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task5
{
    public class Window1 : Window
    {
        public static Window1 Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }
    }

} 