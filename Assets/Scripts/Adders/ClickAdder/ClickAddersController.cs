using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAddersController
{
    private List<Iet> _clickAdders;

    public ClickAddersController(List<Iet> clickAdders)
    {
        _clickAdders = clickAdders;
    }

    public int Get()
    {
        int points = 0;
        foreach (Iet item in _clickAdders)
        {
            points += item.GetPoints();
        }
        return points;
    }
}
