using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public ParticleSystem killEffect;
    Vector2 EnemyLocation;
    public AudioSource dieSound;


    private void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            dieSound.Play();
            ParticleSystem kill = Instantiate(killEffect, EnemyLocation, Quaternion.identity);
            kill.Play();
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Score.score ++;
        }

        

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        EnemyLocation = gameObject.transform.position;
    }
}
