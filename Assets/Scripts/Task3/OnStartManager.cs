using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartManager : MonoBehaviour
{
    [SerializeField] 
    private FormView _view;
    void Start()
    {
        _view.Listen(OnClick);
    }

    private void OnClick()
    {
        Debug.Log("Mission Complete");
        this.gameObject.SetActive(false);
        _view.UnListen();
    }

}
