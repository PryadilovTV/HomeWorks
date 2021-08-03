using System;
using System.Collections;
using System.Collections.Generic;
using Task10;
using UnityEngine;
using UnityEngine.UI;

public class ItemsGenerator : MonoBehaviour
{
    [SerializeField] private FormManager _formManager;
    [SerializeField] private Items Items;
    [SerializeField] private AbstractShopCell _ItemPrefab;
    [SerializeField] private Transform _content;

    private readonly List<AbstractShopCell> _cells = new List<AbstractShopCell>();
    private Action<string> _onBuy;

    private void Start()
    {
    }

    public void Create(List<Item> list, Action<string> onBuy)
    {
        _onBuy = onBuy;
        foreach (var item in list)
        {
            var cell = Instantiate(_ItemPrefab, _content, false);
            cell.Set(item);
            _cells.Add(cell);
            cell.Listen(OnBuy);
        }   
    }

    private void OnBuy(string uid)
    {
        var cell = _cells.Find(x => x.Uid == uid);
        GameObject.Destroy(cell.gameObject);
        _cells.Remove(cell);
        
        _formManager.ShowGratz();
        
        _onBuy?.Invoke(uid);
    }



}
