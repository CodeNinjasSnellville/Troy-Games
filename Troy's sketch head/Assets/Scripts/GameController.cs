using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    //Platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //Default position for platform
    float pos = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Interger i equals 1000
        for (int i = 0; i < 1000; i++)
        {
            //Execute SpawnPlatforms
            SpawnPlatforms();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawn platforms function
    void SpawnPlatforms()
    {
        //Spawn platforms randomly on the x axis and place them on the Y axis every 2.5
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);

        pos += 2.5f;
    }

    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active
        gameOverCanvas.SetActive(true);
    }

}