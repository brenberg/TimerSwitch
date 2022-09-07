using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject box;
    float t;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(box, transform);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > spawnRate)
        {
            Instantiate(box, transform);
            t = 0;
        }       
    }
}
