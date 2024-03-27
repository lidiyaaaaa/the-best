using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GlassWall : MonoBehaviour
{
    public float value = 60;
    private bool deleted = false;
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
            deleted = true;
        }
    }

    public bool IsDeleted()
    {
        return deleted; 
    }
}
