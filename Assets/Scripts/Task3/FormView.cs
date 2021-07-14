using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormView : MonoBehaviour
{
    [SerializeField] private SimpleButton _button;

    public void Listen(Action onClick)
    {
        Debug.Log("Start Listen view");
        _button.Listen(onClick);
    }

    public void UnListen()
    {
        Debug.Log("UnListen view");
        _button.Unlisten();
    }
}
