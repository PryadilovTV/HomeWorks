using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Station
{
    [SerializeField] private string _uid;
    
    [SerializeField] private Image _icon;
    
    [SerializeField] private int _amountCells;

    [SerializeField] private StationTypes.StationType _stationType;
    
    [SerializeField] private List<Recipe> _recipes;
    
    private int unlockedCells;
}
