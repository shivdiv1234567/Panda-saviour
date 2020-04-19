using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan : MonoBehaviour
{
    public GameObject Enemy;
    public float maxTime = 1;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("Enemy").Length < 7 && timer > maxTime)
        {
            GameObject newEnemy = Instantiate(Enemy);
            newEnemy.transform.position = gameObject.transform.position;
            newEnemy.transform.rotation = gameObject.transform.rotation;
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
