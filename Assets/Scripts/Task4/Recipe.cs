using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Settings/Task4/Recipe", fileName = "Recipe")]

[Serializable]
public class Recipe : ScriptableObject
{
    [SerializeField] private string name;

    [SerializeField] private Image icon;

    [SerializeField] private int duration;

    [SerializeField] private List<Ingridient> ingridients;
}