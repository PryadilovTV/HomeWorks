using System;
using System.Collections;
using System.Collections.Generic;
using Task10;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractShopCell : MonoBehaviour, IShopCell
{
    public Button _button;
    
    [SerializeField] private Text _name;
    [SerializeField] private Text _price;
    [SerializeField] private Image _image;
    private Action<string> _onBuy;
    private string _uid;

    public string Uid => _uid;

    //private Item _item;
    
    private void Start()
    {
        _button.onClick.AddListener(Buy);    
    }


    public void Set(Item item)
    {
        _uid = item.Uid;
        _name.text = item.Name;
        _price.text = item.Price.ToString();
        _image.sprite = item.Icon;
    }

    public virtual void Buy()
    {
        //gameObject.Se+tActive(false));
        Destroy(gameObject);
        _onBuy?.Invoke(_uid);
    }

    public void Listen(Action<string> onBuy)
    {
        _onBuy = onBuy;
    }
}
