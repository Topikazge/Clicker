using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAdder
{
    private int _points;

    private int _countObject;

    public ClickAdder(int points, int countObject)
    {
        _points = points;
        _countObject = countObject;
    }

    public void AddObject()
    {
        _countObject++;
    }


    public int GetPoints()
    {
        return _points * _countObject;
    }
}
