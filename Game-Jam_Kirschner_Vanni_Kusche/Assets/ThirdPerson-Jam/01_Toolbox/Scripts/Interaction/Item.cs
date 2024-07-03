using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public FoodTracker _foodTracker;

    // How valuable the item is
    public int ItemValue = 1;

    public float rotationSpeed = 30;

    private AudioSource _audioSource;

    private void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<PlayerInventory>() != null) 
        {
            other.GetComponent<PlayerInventory>().ItemCollected(ItemValue);
            Destroy(gameObject);

            _foodTracker.foodMeter += 50f;
            
        }

       

    }
}
