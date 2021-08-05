using System;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Action<string, Cube> _onClick;
    public string Uid;

    public void Listen(Action<string, Cube> onClick)
    {
        _onClick = onClick;
    }
    
    private void OnMouseDown()
    {
        _onClick?.Invoke(Uid, this);
    }
}