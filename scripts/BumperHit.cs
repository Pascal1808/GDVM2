using System;
using UnityEngine;

public class BumperHit : MonoBehaviour
{
    [SerializeField] private int scoreValue = 100;
    public static event Action<string, int> onBumperHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            onBumperHit?.Invoke(gameObject.tag, scoreValue);

        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
