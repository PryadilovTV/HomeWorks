using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsGenerator : MonoBehaviour
{
    [SerializeField] private Items Items;
    [SerializeField] private GameObject _ItemPrefab;
    [SerializeField] private GameObject _content;
    
    private void Start()
    {
        foreach (var item in Items._items)
        {
            GameObject gameObjectItem = Instantiate(_ItemPrefab, _content.transform) as GameObject;
            gameObjectItem.transform.SetParent(_content.transform, false);

            ShopCell itemManager = gameObjectItem.gameObject.GetComponent<ShopCell>();
            itemManager.FillGameObject(item);
        }
    }



}
