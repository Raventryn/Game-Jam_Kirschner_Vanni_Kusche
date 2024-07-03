using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    public bool gotHit;

    public FoodTracker _foodTracker;

    

    void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            Destroy(gameObject);
            print("yippie");
            
        }

        if(other.CompareTag("Enemy"))
        {
            _foodTracker.foodMeter -= 20;
            Destroy(gameObject);
        }
       
    }
}
