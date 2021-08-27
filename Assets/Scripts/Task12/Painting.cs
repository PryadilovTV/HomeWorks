using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    [SerializeField] private List<Material> _materials;
    [SerializeField] private GameObject _lOD0;
    [SerializeField] private GameObject _lOD1;
    private int _currentMaterial = 0;
    private SkinnedMeshRenderer _renderer;
    private Material _material; 
    void Start()
    {
        _renderer = _lOD0.GetComponent<SkinnedMeshRenderer>();
    }

    private void OnMouseDown()
    {
        _currentMaterial++;
        if (_currentMaterial >= _materials.Count) _currentMaterial = 0;
        
        _renderer.material = _materials[_currentMaterial];
    }
}
