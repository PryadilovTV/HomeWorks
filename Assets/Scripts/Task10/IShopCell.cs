using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class IShopCell : MonoBehaviour
{
    public Button _button;
    
    public Text _name;
    public Text _price;
    public Image _image;

    //private Item _item;
    
    public void FillGameObject(Item item)
    {
        //_item = item;
        _name.text = item.Name;
        _price.text = item.Price.ToString();
        _image.sprite = item.Icon;
    }
    
    private void Start()
    {
        _button.onClick.AddListener(Buy);    
    }

    private void Buy()
    {
        gameObject.SetActive(false);

    }
    
}
