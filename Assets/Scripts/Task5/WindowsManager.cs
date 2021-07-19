using System;
using System.Collections;
using System.Collections.Generic;
using Task5;
using UnityEngine;

[Serializable]
public class WindowsManager: MonoBehaviour
{
    private List<Window> _windows;

    void Start()
    {
        _windows = new List<Window>();
        _windows.Add(Window1.Instance);
        _windows.Add(Window2.Instance);

        foreach (var window in _windows)
        {
            window.Hide();
        }
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

    private Window FindWindow(string uid)
    {

        foreach (var window in _windows)
        {
            if (window._uid == uid)
            {
                return window;
            }
            
        }
        return null;
    }

}
