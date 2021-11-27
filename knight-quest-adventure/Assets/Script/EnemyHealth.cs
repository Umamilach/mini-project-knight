using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 1;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        print("Enemy take damage");
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            EnemyDied();
        }
    }

    private void EnemyDied()
    {
        // print("Enemy died");
        SoundManager.PlaySound("enemyDeath");
        GetComponent<Collider2D>().enabled = false;
        GetComponent<EnemyMovement>().enabled = false;
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        this.enabled = false;
    }
}
