using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int playerHealth = 10;
    private int coins;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
        if (playerHealth <= 0)
        {
            string sceneName = GetComponent<SceneChange>().sceneName;
            EditorSceneManager.LoadScene(sceneName);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(other.GetComponent<Enemy>().playerDamage);
            print("Collided with enemy. Player health: " + playerHealth);
        }
    }
    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        print("Player health: " + playerHealth);
    }
    public void CollectCoins()
    {
        coins++;
        print("Coins collected: " + coins);
    }
}
