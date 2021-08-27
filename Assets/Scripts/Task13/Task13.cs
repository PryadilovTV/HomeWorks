using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task13 : MonoBehaviour
{
    [SerializeField] private SoundManager _soundManager;

    void Start()
    {
        _soundManager.Play(Sounds.Sound3);
    }
}
