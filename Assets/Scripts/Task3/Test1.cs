using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{

    [SerializeField]
    private Button button;

    private void Start()
    {
        button.onClick.AddListener(Close);    
    }

    private void Close()
    {
        this.gameObject.SetActive(false);    
    }
}
