using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GratzView : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Start()
    {
        _button.onClick.AddListener(Close);    
    }

    private void Close()
    {
        gameObject.SetActive(false);    
    }
}
