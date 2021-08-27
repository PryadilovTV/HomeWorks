using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource _audioSource;
   [SerializeField] private SoundsScriptable _soundsScriptable;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play(Sounds sound)
    {
       var soundData = _soundsScriptable.Sounds.Find(x => x.Sound== sound);                   
       if (soundData != null)
       {
           _audioSource.clip = soundData.Clip;
           _audioSource.Play();
       } 
    }
    
}
