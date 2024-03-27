using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class StarLight : MonoBehaviour
{
    public Light star;

    public GameObject PobedaScreen;
    public GameObject gameplayUI;

    public GameObject Player;
    public Animator playerAnimator;

    public GameObject enemy;
    private EnemyHealth _enemyHealth;
        
    private bool rezult = false;

    private void Start()
    {
        _enemyHealth = enemy.GetComponent<EnemyHealth>();

    }
    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            rezult = true;
        }
    }
    private void Update()
    {
        if (rezult == true && star.intensity<=10)
        {
            star.intensity += 10 * Time.deltaTime;
        }
        if (star.intensity >= 10) Pobeda();
    }

    private void Pobeda()
    {
        Player.GetComponent<PlayerHealth>().enabled = false;
        PobedaScreen.SetActive(true);
        gameplayUI.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<FireballCaster>().enabled = false;
        Player.GetComponent<GrenadeCaster>().enabled = false;
        Player.GetComponent<CameraRotation>().enabled = false;
        playerAnimator.SetTrigger("pobeda");


    }
}
