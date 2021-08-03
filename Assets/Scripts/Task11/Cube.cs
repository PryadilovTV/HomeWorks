using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _limitScale;
    void Update()
    {
        var changeScale = new Vector3(0.005f, 0.005f, 0.005f);
        //var changeRota
        
        transform.localScale += changeScale;
        
        if (transform.localScale.x >= _limitScale) Destroy(gameObject);
    }
}
