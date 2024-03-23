using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    [Header("Destruction Timer")]
    // After this time, the object will be destroyed
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        //Execute function based on timeToDestruction
        Invoke("DestroyObject", timeToDestruction);
    }

    // This function will destroy this object :(
    void DestroyObject()
    {
        //Destroy Gameobject
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

