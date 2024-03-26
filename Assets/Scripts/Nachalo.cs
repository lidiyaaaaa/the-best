using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;

public class Nachalo : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject gameplayUI;

    private void Start()
    {
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<FireballCaster>().enabled = false;
        player.GetComponent<CameraRotation>().enabled = false;
        player.GetComponent<GrenadeCaster>().enabled = false;
        enemy.GetComponent<EnemyAI>().enabled = false;
        gameplayUI.SetActive(false);
        Invoke("off", 9);
    }

    private void off()
    {
        player.GetComponent<PlayerController>().enabled = true;
        player.GetComponent<FireballCaster>().enabled = true;
        player.GetComponent<CameraRotation>().enabled = true;
        player.GetComponent<GrenadeCaster>().enabled = true;
        enemy.GetComponent<EnemyAI>().enabled = true;
        gameplayUI.SetActive(true);
    }
}

