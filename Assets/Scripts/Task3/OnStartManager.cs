using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartManager : MonoBehaviour
{
    [SerializeField] 
    private FormView _view;
    void Start()
    {
        _view.Listen(OnClose, OnToggle);
    }

    private void OnClose()
    {
        Debug.Log("Mission Complete");
        this.gameObject.SetActive(false);
        _view.UnListen();
    }
    private void OnToggle(int value)
    {
        if (value == 1) Debug.Log("Toggle on");
		else Debug.Log("Toggle off");
    }
    
    
}
