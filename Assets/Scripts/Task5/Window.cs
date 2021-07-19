using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task5
{
    public class Window : MonoBehaviour
    {
        public string _uid;
        public static Window Instance { get; private set; }
        
        private void Awake()
        {
            Instance = this;
            /*
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(Instance);
            }
            else
            {
                Destroy(gameObject);
            }
            */
        }

        public void Show()
        {
            this.gameObject.SetActive(true);    
        }

        public void Hide()
        {
            this.gameObject.SetActive(false);
        }

    }

}