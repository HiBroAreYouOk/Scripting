using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 20f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
            transform.LookAt(target.position);
        }
    }
}
