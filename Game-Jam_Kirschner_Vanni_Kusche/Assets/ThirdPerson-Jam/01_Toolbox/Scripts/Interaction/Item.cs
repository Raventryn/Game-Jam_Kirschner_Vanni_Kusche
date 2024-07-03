using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public FoodTracker _foodTracker;

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
            _audioSource.Play();
            
            _foodTracker.foodMeter += 30f;

            StartCoroutine(DestroyAfterSound());

        }
    }
    private IEnumerator DestroyAfterSound()
    {
        yield return new WaitForSeconds(_audioSource.clip.length);

        Destroy(gameObject);
    }
}
