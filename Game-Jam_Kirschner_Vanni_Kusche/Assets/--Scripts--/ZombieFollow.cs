using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{
    public float speed;
    public Vector3 offset;
    public bool isClose;


    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        isClose = true;
    }

    private void Update()
    {
        if(isClose == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, (player.transform.position - offset), speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isClose = false;

    }
}
