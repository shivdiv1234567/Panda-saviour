using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePoint;
    public float BulletSpeed = 20f;
    public AudioSource BulletSound;


    // Start is called before the first frame update
    void Start() { 

    }

    // Update is called once per frame
    void Update()
    {
        FirePoint = gameObject.transform;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
            bullet.transform.rotation = FirePoint.transform.rotation;
            Rigidbody2D Bulletrb = bullet.GetComponent<Rigidbody2D>();
            Bulletrb.AddForce(FirePoint.up * BulletSpeed, ForceMode2D.Impulse);
            BulletSound.Play();
        }
    }
}
