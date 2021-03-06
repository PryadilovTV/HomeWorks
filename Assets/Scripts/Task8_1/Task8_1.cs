using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class Task8_1 : MonoBehaviour
{
    public int Pause;
    public Transform Target;
    public float Duration;
    
    void Start()
    {
        //DOVirtual.DelayedCall(Pause, JumpPuppy);
    }

    void JumpPuppy()
    {
        //var _seq = DOTween.Sequence();
        //_seq.Append(transform.DOMove(Target.transform.position, 0.5f));
        //_seq.Append(transform.DOMove(transform.position, 0.5f));
       // _seq.OnComplete(JumpPuppy);
        
        //transform.DOJump(Target.transform.position, 10, 1000, 1000);
        
    }
    
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.DOKill();

            //transform.DOMove(Input.mousePosition, Duration);

            
          //  var screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
          // var mouse = Input.mousePosition;
          //   var worldPosition = Camera.main.ScreenToWorldPoint(mouse);
          //   Debug.LogAssertion($"{mouse} : {worldPosition}");
          
          var camera = Camera.main;
          var mousePos2D = Input.mousePosition;

          var point = new Vector3(mousePos2D.x, mousePos2D.y, transform.position.z);
          var worldPointPos = camera.ScreenToWorldPoint(point);

          Debug.LogAssertion($"{mousePos2D}, {worldPointPos}");
         transform.DOMove(worldPointPos, Duration);
        }    
    }
}
