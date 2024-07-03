using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject throwable;
    public Transform playerPosition;
    public float throwForce = 20f;
    private Vector3 offset = new Vector3(0, 2, 0);
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ThrowItemAtEnemy();
            _audioSource.Play();
        }
    }

    void ThrowItemAtEnemy()
    {
        if (throwable != null && playerPosition != null)
        {
            GameObject throwItem = Instantiate(throwable, playerPosition.position + offset, playerPosition.rotation);

            GameObject nearestEnemy = FindNearestEnemy();
            if (nearestEnemy != null)
            {
                Vector3 direction = (nearestEnemy.transform.position - playerPosition.position).normalized;

                Rigidbody rb = throwItem.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(direction * throwForce, ForceMode.Impulse);
                }
            }
        }
    }

    GameObject FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(playerPosition.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        return nearestEnemy;

      
    }
 
}
