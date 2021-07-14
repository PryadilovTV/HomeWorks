using System;
using UnityEngine;
using UnityEngine.EventSystems;

    public class SimpleButton : MonoBehaviour, IPointerClickHandler
    {
        protected Action _callback;

        public virtual void Listen(Action click)
        {
            _callback = click;
        }

        public virtual void Unlisten()
        {
            _callback = null;
        }
        protected virtual void Click()
        {
            if (_callback != null) _callback();
            
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            Click();
        }
    }
