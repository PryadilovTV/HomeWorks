using System;
using System.Collections;
using System.Collections.Generic;
using Task5;
using UnityEngine;

[Serializable]
public class WindowsManager: MonoBehaviour
{

    //[SerializeField] private List<Windows> _windows;
    private List<Windows> _windows;

    public void Awake()
    {
        var _window1 = Window1.GetInstance();
        _windows.Add(_window1);
        _windows.Add(Window2.GetInstance());
    }

    public void Show(string uid)
    {
        var _window = FindWindow(uid);
        _window.Show();
    }

    public void Hide(string uid)
    {
        var _window = FindWindow(uid);
        _window.Hide();
    }

    private Windows FindWindow(string uid)
    {

        /*
        foreach (var window in _windows)
        {
            if (window.uid == uid)
            {
                Windows _ourWindow = Window1.GetInstance();
                
            }
        }
        */

        return null;
    }

}
