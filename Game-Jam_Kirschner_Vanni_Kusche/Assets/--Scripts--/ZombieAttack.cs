using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public FoodTracker _foodTracker;

    // Start is called before the first frame update
    void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _foodTracker.foodMeter -= 1f;
    }
}
