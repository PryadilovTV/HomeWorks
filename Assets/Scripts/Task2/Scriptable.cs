using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "Settings/TestData", fileName = "Our object")]   
public class Scriptable : ScriptableObject
   {
       public List<OurData> listData;
   }

