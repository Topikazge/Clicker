using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adder : Iet
{
    private int _id;
    private int _points;
    private int _countObject;

    public Adder(int id, int points, int countObject)
    {
        _id = id;
        _points = points;
        _countObject = countObject;
    }

    public int ID
    {
        get
        {
            return _id;
        }
    }

    public void AddObject(int count)
    {
        if (count >= 0)
        {
            _countObject += count;
        }
    }

    public int GetPoints()
    {
        return _points * _countObject;
    }
}
