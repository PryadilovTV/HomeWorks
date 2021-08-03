using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TaskManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private int _countCubes;

    void Start()
    {
        for (int i = 1; i < _countCubes; i++)
        {
            Invoke("CreateCube", i);
        }
    }

    void CreateCube()
    {
        var pos = new Vector3((float) Random.Range(-40, 40), (float) Random.Range(-30, 30), 0);
        GameObject newCube = Instantiate(_cubePrefab);
        newCube.transform.position = pos;
        //newCube.transform.rotation = Quaternion.identity;
    }

    private void Update()
    {
        {
            if (Input.GetMouseButtonDown(0)){
            
                var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);

                if (hit.collider.CompareTag("Cube")) 
                {
                   Debug.Log("Cube pushed");
                }
            }
     
        }
    }
}
