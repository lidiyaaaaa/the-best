using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.GameCenter;

public class EnemyOnScripts : MonoBehaviour
{
    public PlayerController player;
    private GlassWall _glassWall;
    private void Start()
    {
        _glassWall = player.GetComponent<GlassWall>();
    }
    void Update()
    {
        if (_glassWall.IsDeleted()) vkl();
    }
     private void vkl()
    {
        GetComponent<NavMeshAgent>().enabled = true;
        GetComponent<EnemyAI>().enabled = true;
    }

}
