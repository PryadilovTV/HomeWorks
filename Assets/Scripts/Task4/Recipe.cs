using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Recipe
{
    [SerializeField] private string name;

    [SerializeField] private Image icon;

    [SerializeField] private int duration;

    [SerializeField] private List<Ingredient> ingredients;
}