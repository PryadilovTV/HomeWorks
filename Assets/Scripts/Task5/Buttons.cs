using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour, IPointerClickHandler
{
    private byte currentButton = 1;

    public void OnPointerClick(PointerEventData eventData)
    {
        
        var _windowManager = this.gameObject.GetComponent<WindowsManager>();

        
        if (currentButton == 1)
        {
            _windowManager.Show("12345");
        }
        else if (currentButton == 2)
        {
            _windowManager.Show("23456");
        }
        else if (currentButton == 3)
        {
            _windowManager.Hide("12345");
        }
        else if (currentButton == 4)
        {
            _windowManager.Hide("23456");
            currentButton = 0;
        }
        currentButton++;
        
    }
}
