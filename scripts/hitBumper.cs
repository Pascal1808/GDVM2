using System;
using UnityEngine;

public class hitBumper : MonoBehaviour
{



    private ParticleSystem ps;


    private void Start()
    {
        ps = GetComponent<ParticleSystem>();

        ps?.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            //speel particle effect af
            ps?.Stop();
            //verstuurt event met de tag van de bumper en de waarde
            ps?.Play();
        }
    }
}
