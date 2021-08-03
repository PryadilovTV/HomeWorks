using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class Task8_UI : MonoBehaviour
{
    public int Pause;
    public Transform Target;
    public float Duration;
    
    void Start()
    {
        DOVirtual.DelayedCall(Pause, JumpPuppy);
    }

    void JumpPuppy()
    {
        //var _seq = DOTween.Sequence();
        //_seq.Append(transform.DOMove(Target.transform.position, 0.5f));
        //_seq.Append(transform.DOMove(transform.position, 0.5f));
       // _seq.OnComplete(JumpPuppy);
        
        transform.DOJump(Target.transform.position, 10, 1000, 1000);
        
    }
    
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.DOKill();
            
            transform.DOMove(Input.mousePosition, Duration);

            
            //var screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //var worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.DOMove(new Vector3(worldPosition.x, worldPosition.y), Duration);
            
            
        }    
    }
}
