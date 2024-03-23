using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    //Object that we will attach to the script for spawning object
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    //Spawning delay time
    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    //Spawning time for each object appearing
    [Header("Default spawn time")]
    public float spawnTime = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, -2.75f, 0);

    }
    
    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
}
