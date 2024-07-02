using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodTrackerUI : MonoBehaviour
{
    private Image _fill;

    private Slider _slider;

    private FoodTracker _foodTracker;

    // Start is called before the first frame update
    void Start()
    {
        _fill = GetComponentInChildren<Image>();

        _slider = GetComponentInChildren<Slider>();

        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
    }


    void Update()
    {
        _slider.value = _foodTracker.foodMeter;
    }
}
