using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Settings/Task4/Station", fileName = "Station")]
public class Station : ScriptableObject
{
    enum Type
    {
        Mine,
        Fabric,
        Collector
    }
    
    [SerializeField] private string name;
    
    [SerializeField] private Image icon;
    
    [SerializeField] private int amountCells;
    
    [SerializeField] private List<Recipe> recipes;

    private static int costCell = 40;

    private int unlockedCells;
}
