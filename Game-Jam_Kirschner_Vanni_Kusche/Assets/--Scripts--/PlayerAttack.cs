using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwable;
    private GameObject _player;
    public Transform playerPosition;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateAtPlayerPosition();
        }
    }

    void InstantiateAtPlayerPosition()
    {
        if (throwable != null && playerPosition != null)
        {
            Instantiate(throwable, playerPosition.position, playerPosition.rotation);
            print("yippie");
        }
    }
}
