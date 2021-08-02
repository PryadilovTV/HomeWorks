using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCell : AbstractShopCell
{

    public void FillGameObject(Item item)
    {
        //_item = item;
        _name.text = item.Name;
        _price.text = item.Price.ToString();
        _image.sprite = item.Icon;
    }
    
   
    public override void Buy()
    {
        //gameObject.SetActive(false));
        Destroy(gameObject);

        var task10 = GameObject.Find("Task10");
        task10.GetComponent<FormManager>().ShowGratz();
    }

}
