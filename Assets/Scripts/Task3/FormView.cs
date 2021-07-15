using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormView : MonoBehaviour
{
    [SerializeField] private SimpleButton _buttonClose;
    [SerializeField] private SimpleButton _buttonOn;
    [SerializeField] private SimpleButton _buttonOff;

    public void Listen(
		Action onClose,
		Action<int> onToggle	
	)

    {
        Debug.Log("Start Listen view");
        _buttonClose.Listen(onClose);
        _buttonOn.Listen(onToggle, 1);
        _buttonOff.Listen(onToggle, 0);
    }

    public void UnListen()
    {
        Debug.Log("UnListen view");
        _buttonClose.Unlisten();
        _buttonOn.Unlisten();
        _buttonOff.Unlisten();
    }

}
