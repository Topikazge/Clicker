using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private int _countForClick = 1;
    private CounterPoints _counterPoints;
    private ClickAddersController _clickAddersController;


    public void Init(List<ClickAdder> clickAdders)
    {
        _clickAddersController = new ClickAddersController(clickAdders);
    }

    private void Start()
    {
        Init(new List<ClickAdder>() { new ClickAdder(2,1)});
        _counterPoints = FindObjectOfType<CounterPoints>();
    }

    public void OnClick()
    {
        int points = _countForClick + _clickAddersController.Get();
        _counterPoints.AddPoints(points);
    }
}
