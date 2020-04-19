using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePAnda : MonoBehaviour
{

    public GameObject target;
    public float speed = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
