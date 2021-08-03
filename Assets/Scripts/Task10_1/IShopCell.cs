using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Task10
{
    interface IShopCell
    {
        string Uid { get; }
        void Set(Item item);
        void Buy();
        void Listen(Action<string> onBuy);
    }
}


