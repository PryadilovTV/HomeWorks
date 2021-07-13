using System;

[Serializable]
public class OurData
{
    public string Uid;
    public string Data;
    public int Count;

    public OurData()
    {
    }

    public OurData(string uid, string data, int count)
    {
        Uid = uid;
        Data = data;
        Count = count;
    }

}