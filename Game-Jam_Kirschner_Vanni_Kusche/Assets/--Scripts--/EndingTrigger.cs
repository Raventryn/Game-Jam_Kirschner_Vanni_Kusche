using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    public FoodTracker _foodTracker;

    public GameObject wonScreen;

    public GameObject loseScreen;

    public bool endingTriggered;

    // Start is called before the first frame update
    void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();

        loseScreen.SetActive(false);
        wonScreen.SetActive(false);

        endingTriggered = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _foodTracker.foodMeter <= 30)
        {
            loseScreen.SetActive(true);
        }

        if (other.CompareTag("Player") && _foodTracker.foodMeter >= 30)
        {
            wonScreen.SetActive(true);
            print("yes");
        }

    }

}
