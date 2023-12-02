using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game over Canvas that is used for the game
    [Header("Game Over UI Objects for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    [Header("Score UI Object for displaying Score")]
    //Score Canvas that is used for the game
    public GameObject scoreCanvas;
    //Spawner object that is used for the game
    [Header("Spawner Object for spawning objects in game")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        //Score in visible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
