/*
Используя 3 структуры данных: array, List, Dictionary
написать методы для добавления объекта, поиска нужного и удаления

Данные которые будут хранится:
string Uid,
string Data
int Count

Поиск и удаление будет осуществлять по Uid

Необязательные, но желательные задания:
Доп. усложненное задание №1: сделать хранение данных для List в ScriptableObject.
Доп. усложненное задание №2: в List'е из 5 объектов сделать 1, 3 и 4 с одинаковым Count = 10, написать метод удаляющий объекты по полю Count
Доп. усложненное задание №3: попробовать заменить for на foreach и на Linq 
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Task2 : MonoBehaviour
{
    void Start()
    {
        /*
        //Массив
        var arrayData = new OurData[0];
        
        Debug.Log(arrayData.Length);
        AppendData(ref arrayData, new OurData("1", "12345", 5));
        AppendData(ref arrayData, new OurData("2", "23456", 2));
        AppendData(ref arrayData, new OurData("3", "34567", 4));
        Debug.Log(arrayData.Length);

        var neededData = SearchData(arrayData, "2");
        Debug.Log(neededData.Data);
        
        DeleteData(ref arrayData, "3");
        Debug.Log(arrayData.Length);
        */

        /*
        //List
        var listData = new List<OurData>();
        
        Debug.Log(listData.Count);
        AppendData(ref listData, new OurData("1", "12345", 5));
        AppendData(ref listData, new OurData("2", "23456", 2));
        AppendData(ref listData, new OurData("3", "34567", 4));
        AppendData(ref listData, new OurData("2", "45678", 12));
        Debug.Log(listData.Count);
        
        var neededData = SearchData(listData, "2");
        Debug.Log(neededData.Data);
        
        DeleteData(ref listData, "2");
        Debug.Log(listData.Count);
        */

        /*
        //Dictionary
        var dictData = new Dictionary<string, OurData>();

        Debug.Log(dictData.Count);
        AppendData(ref dictData, new OurData("1", "12345", 5));
        AppendData(ref dictData, new OurData("2", "23456", 2));
        AppendData(ref dictData, new OurData("3", "34567", 4));
        Debug.Log(dictData.Count);

        var neededData = SearchData(dictData, "2");
        Debug.Log(neededData.Data);

        DeleteData(ref dictData, "2");
        Debug.Log(dictData.Count);
        */

    }

    private void AppendData(ref OurData[] arrayData, OurData newData)
    {
        Array.Resize(ref arrayData, arrayData.Length + 1);
        arrayData[arrayData.Length - 1] = newData;
    }
    private void AppendData(ref List<OurData> listData, OurData newData)
    {
        listData.Add(newData);
    }
    private void AppendData(ref Dictionary<string, OurData> dictData, OurData newData)
    {
        dictData.Add(newData.Uid, newData);
    }

    private OurData SearchData(OurData[] arrayData, string uid)
    {
        for (int i = 0; i < arrayData.Length - 1; i++)
        {
            if (string.Equals(arrayData[i].Uid, uid))
            {
                return arrayData[i];
            }
        }

        return new OurData();
    }
    private OurData SearchData(List<OurData> listData, string uid)
    {

        var selectedOurData = 
            from ourData in listData
            where string.Equals(ourData.Uid, uid)
            select ourData;

        if (selectedOurData.Any())
        {
            return selectedOurData.ElementAt(0);
        }
        

        /*
        for (int i = 0; i < listData.Count - 1; i++)
        {
            if (string.Equals(listData[i].Uid, uid))
            {
                return listData[i];
            }
        }
        */
        
        return new OurData();
        
    }
    private OurData SearchData(Dictionary<string, OurData> dictData, string uid)
    {
        return dictData[uid];
    }

    private void DeleteData(ref OurData[] arrayData, string uid)
    {
        for (int i = 0; i < arrayData.Length; i++)
        {
            if (string.Equals(arrayData[i].Uid, uid))
            {
                if (i == arrayData.Length - 1)
                {
                    Array.Resize(ref arrayData, arrayData.Length - 1);
                }
                else
                {
                    var newArrayData = new OurData[arrayData.Length - 1];
                    Array.Copy(arrayData, newArrayData, i);
                    Array.Copy(arrayData, i + 1, newArrayData, i, arrayData.Length - i - 1);
                    arrayData = newArrayData;
                }
            }
        }
    }
    private void DeleteData(ref List<OurData> listData, string uid)
    {
        var _deleteList = new List<OurData>();

        foreach (var objectList in listData)
        {
            if (string.Equals(objectList.Uid, uid))
            {
                _deleteList.Add(objectList);
            }
        }

        foreach (var _deleteObject in _deleteList)
        {
            listData.Remove(_deleteObject);
        }
    }
    private void DeleteData(ref Dictionary<string, OurData> dictData, string uid)
    {
        dictData.Remove(uid);
    }
}

public class OurData
{
    private string _uid;
    private string _data;
    private int _count;

    public string Uid
    {
        get { return _uid; }
        set { _uid = value; }
    }
    public string Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public int Count
    {
        get { return _count; }
        set { _count = value; }
    }
    public OurData() {}
    public OurData(string uid, string data, int count)
    {
        _uid = uid;
        _data = data;
        _count = count;
    }

}
