using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Task11Manager : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private int _countCubes;
    [SerializeField] private Button _button;
    [SerializeField] private float _limitScale;
    
    private Action<string> _onClick;

    void Start()
    {
        _button.onClick.AddListener(CreateCubes);    
    }

    public void CreateCubes()
    {
        for (int i = 0; i < _countCubes; i++)
        {
            StartCoroutine(CreateCube(i));
        }
    }
    
    private IEnumerator CreateCube(int index)
    {
        yield return new WaitForSeconds(index);
        var pos = new Vector3((float) Random.Range(-40, 40), (float) Random.Range(-30, 30), 0);
        
        var newCube = Instantiate(_cubePrefab);
        newCube.transform.position = pos;
        newCube.transform.Rotate((float)Random.Range(0,360), (float)Random.Range(0,360), (float)Random.Range(0,360));
        newCube.Uid = index.ToString();
        
        newCube.Listen(OnCubeClick);

        StartCoroutine(GrowCube(newCube));
    }

    private IEnumerator GrowCube(Cube cube)
    {
        var changeScale = new Vector3(0.01f, 0.01f, 0.01f);

        while (cube.transform.localScale.x < _limitScale)
        {
            yield return new WaitForFixedUpdate();

            cube.transform.localScale += changeScale;
        }
        
        Destroy(cube.gameObject);
    }

    private static void OnCubeClick(string uid, Cube cube)
    {
        Debug.LogAssertion("Click on " + uid);
        
        cube.GetComponent<Rigidbody>().AddForce(cube.transform.forward * 1000);
        cube.GetComponent<Rigidbody>().useGravity = true;
    }
}
