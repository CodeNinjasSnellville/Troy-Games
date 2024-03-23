using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //Rigidbody2D object that is stored
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    //downward speed of the object
    public float downSpeed = 10f;
    [Header("Default Movement speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movment Speed")]
    //movement direction of the object
    public float movement = 0f;

    [Header("Score Text")]
    public Text scoreText;
    //score of game
    private float topScore = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //variable equals to component Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movment equals Horizontal movement
        //multiplied by the movement speed
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //if direction on x axis is less than 0
        if (movement < 0)
        {
            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //if direction on x axis is greater than 0
        else
        {
            //object faces to the right
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
if (rb.velocity.y > 0 && transform.position.y > topScore)
            {
                //Score equals players position
                topScore = transform.position.y;
            }
            //Text for the score equals to the top score
            scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
        }
    //Fixedupdate called every fixed frame-rate frame.
    void FixedUpdate()
    //If players velocity is greater than 0
    //and position on the y axis is greater
    //than the score
    {
        //Vector2 wich is (x,y) velocity
        //equals to the velocity of the rigidbody2D
        Vector2 velocity = rb.velocity;
        //Velocity of the x axis equals to
        //the direction movement on the x axis
        // of the character.
        velocity.x = movement;
        //Rigidbody2D velocity equals to
        //velocity of the object
        rb.velocity = velocity;

        Debug.Log("bye");
    }
        //Collision fuction
        private void OnCollisionEnter2D(Collision2D collision)
            {
            Debug.Log("hi");
                //velocity with the downspeed
                rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
            }
        
    }    
