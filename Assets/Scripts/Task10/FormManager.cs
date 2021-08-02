using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormManager : MonoBehaviour
{
    public GameObject _gratz;
    
    public void ShowGratz()
    {
        _gratz.SetActive(true);
    }
}
