using System;
using UnityEngine;
using UnityEngine.EventSystems;

    public class SimpleButton : MonoBehaviour, IPointerClickHandler
    {
        protected Action _callback;
        protected Action<int> _callbackWithId;
        protected int _id;

        public virtual void Listen(Action click)
        {
            _callback = click;
        }
		
		public virtual void Listen(Action<int> click, int uid)
		{
            _callbackWithId = click;
			_id = uid;
		}	
	

        public virtual void Unlisten()
        {
            _callback = null;
            _callbackWithId = null;
        }
        protected virtual void Click()
        {
            if (_callback != null) _callback();
            if (_callbackWithId != null) _callbackWithId(_id);
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            Click();
        }
    }
