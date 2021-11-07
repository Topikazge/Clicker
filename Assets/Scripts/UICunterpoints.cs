using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICunterpoints : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        FindObjectOfType<CounterPoints>().OnChangePoints += UpdateCoint;
    }

    private void UpdateCoint(int count)
    {
        if (count >= 0)
        {
            _text.text = count.ToString();
        }
   
    }

}
