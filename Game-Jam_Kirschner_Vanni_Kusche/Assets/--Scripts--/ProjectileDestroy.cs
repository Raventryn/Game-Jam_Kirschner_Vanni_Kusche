using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    public bool gotHit;

    public FoodTracker _foodTracker;

    private AudioSource _audioSource;

    void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
        _audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            Destroy(gameObject);
            print("yippie");
            _audioSource.Play();
        }

        if(other.CompareTag("Enemy"))
        {
            _foodTracker.foodMeter -= 20;
            Destroy(gameObject);
        }
       
    }
}
