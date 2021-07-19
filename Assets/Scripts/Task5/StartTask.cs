using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTask : MonoBehaviour
{
    //[SerializeField] private WindowsManager _windowsManager;
    void Start()
    {
        var _windowsManager= this.gameObject.GetComponent<WindowsManager>(); 
        _windowsManager.Show("12345");    
        _windowsManager.Show("12345");
        _windowsManager.Show("23456");
    }

}
