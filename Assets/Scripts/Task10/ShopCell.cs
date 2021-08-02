using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCell : IShopCell
{

    private void Start()
    {
        _button.onClick.AddListener(Buy);    
    }
    
    private void Buy()
    {
        gameObject.SetActive(false);

        var task10 = GameObject.Find("Task10");
        task10.GetComponent<FormManager>().ShowGratz();
    }


}
