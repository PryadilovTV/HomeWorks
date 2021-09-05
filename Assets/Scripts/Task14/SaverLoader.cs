using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SaverLoader
{
    public static void SaveData(string data, string key)
    {
        Save(data, key);
    }
    
    public static void SaveData(int data, string key)
    {
        Save(data, key);
    }

    public static void SaveData(float data, string key)
    {
        Save(data, key);
    }
    
    public static void SaveData<T>(T data, string key)
    {
        try
        {
            var dataString = ObjectToString(data);
            Save(dataString, key);
        }
        catch (Exception e)
        {
            Debug.LogAssertion(e);
        }
    }
    private static void Save(string data, string key)
    {
        PlayerPrefs.SetString(key, data);
        PlayerPrefs.Save();
    }
    private static void Save(int data, string key)
    {
        PlayerPrefs.SetInt(key, data);
        PlayerPrefs.Save();
    }
    private static void Save(float data, string key)
    {
        PlayerPrefs.SetFloat(key, data);
        PlayerPrefs.Save();
    }
    
    public static string LoadDataString(string key)
    {
        return LoadString(key);
    }
    
    public static int LoadDataInt(string key)
    {
        return LoadInt(key);
    }
    public static float LoadDataFloat(string key)
    {
        return LoadFloat(key);
    }
    public static T LoadData<T>(string key)
    {
        /*
        switch (typeof(T).ToString())
        {
            case "string":
                return (T)LoadString(key); 
        }
        */
        
        var dataString = LoadString(key);
        
        return StringToObject<T>(dataString);
    }
    private static string LoadString(string key)
    {
        if (!PlayerPrefs.HasKey(key)) return "";
        return PlayerPrefs.GetString(key);
    }
    private static int LoadInt(string key)
    {
        if (!PlayerPrefs.HasKey(key)) return 0;
        return PlayerPrefs.GetInt(key);
    }
    private static float LoadFloat(string key)
    {
        if (!PlayerPrefs.HasKey(key)) return 0;
        return PlayerPrefs.GetFloat(key);
    }
    private static string ObjectToString<T>(T data)
    {
        return JsonUtility.ToJson(data);
    }
    private static T StringToObject<T>(string dataString)
    {
        return JsonUtility.FromJson<T>(dataString);
    }
}
