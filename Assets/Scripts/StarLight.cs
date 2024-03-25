using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLight : MonoBehaviour
{
    public Light star;
    public GameObject PobedaScreen;
    public GameObject gameplayUI;
    public GameObject Player;
    public Animator animator;

    private bool rezult = false;
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
        Pobeda();
    }

    private void Pobeda()
    {
        if (star.intensity >= 10)
        {
            PobedaScreen.SetActive(true);
            gameplayUI.SetActive(false);
            Player.GetComponent<PlayerController>().enabled = false;
            Player.GetComponent<FireballCaster>().enabled = false;
            Player.GetComponent<CameraRotation>().enabled = false;
            animator.SetTrigger("pobeda");
        }
    }
}
