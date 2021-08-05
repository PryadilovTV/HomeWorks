using System;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Action<string> _onClick;
    public string Uid;

    public void Listen(Action<string> onClick)
    {
        _onClick = onClick;
    }
    
    private void OnMouseDown()
    {
        _onClick?.Invoke(Uid);
    }
}