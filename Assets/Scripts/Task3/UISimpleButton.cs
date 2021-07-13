/*using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace.Task3
{
	public class UISimpleButton : MonoBehaviour, IPointerClickHandler
	{				
		protected Action _callback;
		protected Action<string> _callbackWithUid;		
		protected Action<int> _callbackWithId;
		
		protected string _uid;
		protected int _id;				
		
		public virtual void Listen(Action click) { _callback = click; }

		public virtual void Listen(Action<string> click, string uid)
		{
			_callbackWithUid = click;
			_uid = uid;
		}

		public virtual void Listen(Action<int> click, int uid)
		{
			_callbackWithId = click;
			_id = uid;
		}

		public virtual void Unlisten()
		{
			_callbackWithId = null;
			_callback = null;
			_callbackWithUid = null;
		}

		protected virtual void Click()
		{
			if (_callback != null) _callback();
			if (_callbackWithUid != null) _callbackWithUid(_uid);
			if (_callbackWithId != null) _callbackWithId(_id);
		}
		
		public void OnPointerClick(PointerEventData eventData)		
		{					
			Click();
		}
	}
}
*/