using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task14 : MonoBehaviour
{
    [SerializeField] private ScriptableData _scriptable;
    [SerializeField] private Data _data;
    void Start()
    {
        /*
        var dataString = "asdf";
        SaverLoader.SaveData(dataString, "dataString");
        var dataStringLoad = SaverLoader.LoadDataString("dataString");
        Debug.Log($"String: {dataString} => {dataStringLoad}");
        
        var dataInt = 123;
        SaverLoader.SaveData(dataInt, "dataInt");
        var dataIntLoad = SaverLoader.LoadDataInt("dataInt");
        Debug.Log($"Int: {dataInt} => {dataIntLoad}");

        var dataFloat = 234f;
        SaverLoader.SaveData(dataFloat, "dataFloat");
        var dataFloatLoad = SaverLoader.LoadDataFloat("dataFloat");
        Debug.Log($"Float: {dataFloat} => {dataFloatLoad}");
        
        _data = new Data();
        SaverLoader.SaveData(_data, "_data");
        _data = SaverLoader.LoadData<Data>("_data");
        */

        /*
        
        var listData = new List<string>();
        listData.Add("qwer");
        listData.Add("asdf");
        listData.Add("zxcv");
        SaverLoader.SaveData(listData, "_list");
        listData = SaverLoader.LoadData<List<string>>("_list");
        */
       
        /*
        var arrayData = new string[3];
        arrayData[0] = "qwer";
        arrayData[1] = "asdf";
        arrayData[2] = "zxcv";
        SaverLoader.SaveData(arrayData, "_array");
        arrayData = SaverLoader.LoadData<string[]>("_list");
        */
       
    }
}
