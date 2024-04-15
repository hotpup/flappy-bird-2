using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 10;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawn();
            timer = 0;
        }
    }

    void spawn() {
        float min = transform.position.y - 5;
        float max = transform.position.y + 5;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(min,max), 0), transform.rotation);
    }
}

