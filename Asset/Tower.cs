using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public float movementspd;
    public float destroyzone = -14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movementspd) * Time.deltaTime;

        if (transform.position.x < destroyzone)
        {
            Destroy(gameObject);
        }
    }
}
