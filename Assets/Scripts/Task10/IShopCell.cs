using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class IShopCell : AbstractShopCell
{
    public Button _button;
    
    public Text _name;
    public Text _price;
    public Image _image;

    //private Item _item;
    
    private void Start()
    {
        _button.onClick.AddListener(Buy);    
    }

    public virtual void Buy()
    {
        //gameObject.SetActive(false));
        Destroy(gameObject);
    }
    
}
