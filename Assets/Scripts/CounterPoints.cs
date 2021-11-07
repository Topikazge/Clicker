using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterPoints : MonoBehaviour
{
    private int _points;

    public event Action<int> OnChangePoints;

    public void AddPoints(int points)
    {
        Debug.Log("���������� points - " + points);
        if (points >= 0) 
        {
            _points += points;
            OnChangePoints.Invoke(_points);

            Debug.Log("���������� point - " + _points);
        }
        else
        {
            Debug.Log("�������� ��������� ������ ��� ����� 0");
        }
    }
}
