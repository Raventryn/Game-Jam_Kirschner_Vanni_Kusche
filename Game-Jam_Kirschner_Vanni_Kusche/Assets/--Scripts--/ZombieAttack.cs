using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public FoodTracker _foodTracker;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _foodTracker.foodMeter -= 15f;
            _audioSource.Play();

        }
        

        Debug.Log("ich collidiere mit" + other.name);
    }
}
