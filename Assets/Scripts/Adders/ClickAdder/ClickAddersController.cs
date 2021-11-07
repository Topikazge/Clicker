using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAddersController
{
    private List<ClickAdder> _clickAdders;

    public ClickAddersController(List<ClickAdder> clickAdders)
    {
        _clickAdders = clickAdders;
    }

    public int Get()
    {
        int points = 0;
        foreach (var item in _clickAdders)
        {
            points += item.GetPoints();
        }
        return points;
    }
}
