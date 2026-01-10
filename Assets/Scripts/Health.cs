using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int defaultHealth;
    public int baseHealth;
    public GameObject explosionPrefab;
    public System.Action onDead;
    public System.Action onHealthChange;
    // Start is called before the first frame update
    void Start()
    {
        baseHealth = defaultHealth;
        onHealthChange?.Invoke();
    }
    public void TakeDamage(int damage)
    {
        if(baseHealth <= 0) return;
        baseHealth -= damage;
        onHealthChange?.Invoke();
        if (baseHealth <= 0) Die();
    }
    public virtual void Die()
    {
        Destroy(gameObject);
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 0.5f);
        onDead?.Invoke();
    }
    
}
