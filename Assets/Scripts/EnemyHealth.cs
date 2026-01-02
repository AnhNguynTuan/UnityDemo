using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Health
{
    public GameObject explosionPrefab;
    public override void Die()
    {
        base.Die();
    }
}
