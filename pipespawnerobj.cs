using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnerobj : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe(); // Call SpawnPipe() in Update
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    { if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    } 
    void SpawnPipe()
        {
            float lowestpoint = transform.position.y - heightoffset;
            float highestpoint = transform.position.y + heightoffset;
        Instantiate (pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), transform.position.z), Quaternion.identity);

    }
       
}
