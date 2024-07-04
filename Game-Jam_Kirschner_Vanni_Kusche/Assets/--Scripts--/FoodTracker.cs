using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTracker : MonoBehaviour
{
    public PlayerController _playerController;

    public float foodMeter;

    private float damage;

    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        foodMeter = 100f;
        damage = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            foodMeter -= damage * Time.deltaTime;
        }

        if (foodMeter >= 100)
        {
            foodMeter = 100;
        }
    }
  
}
