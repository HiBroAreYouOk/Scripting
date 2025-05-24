using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 2.5f;
    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject); // Destroy the missile after hitting the enemy
        }
        else if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().TakeDamage(4); // Assuming Player has a TakeDamage method
            Destroy(gameObject); // Destroy the missile after hitting the player
        }
    }

}
