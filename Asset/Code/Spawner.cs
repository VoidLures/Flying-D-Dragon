using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tower;
    public float spawnrate = 2;
    private float timer = 0;
    public float offset=10;
    // Start is called before the first frame update
    void Start()
    {
        spawntower();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawntower();
            timer = 0;
        }
    }
    
    void spawntower()
    {
        float lowest = transform.position.y - offset;
        float highest = transform.position.y + offset;

        Instantiate(tower, new Vector3(transform.position.x,Random.Range(lowest,highest),0), transform.rotation);
    }
}
