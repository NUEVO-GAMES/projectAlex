using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

   //making a variable "scoreup" of type "Score" in order to reference to the "Score" script later
    public Score scoreup;
    
    /* REFERENCE blackthornprod 2D double/ tripple jump video
      UNITY scriptin API */
    /*we want to make the player moveable so we can see it move in game*/
    /* we also make the character flip on the x - axis */
    /* jump mechanics */
    [SerializeField]private float speed = 1f;
    // we have made a float that will determine the speed of the character;
    Vector2 dirVector;
    // we have made a vector that will hold two values 
    //one for the direction on the x- axis
    // the other for the direction on the y- axis
    private SpriteRenderer spriteRenderer;
    // we made a variable to store the players spriteRenderer
    public bool isGrounded;
    // we have made a boolean that will enable us to know when something is ground
    [SerializeField]private float checkRadius = 0.5f;
    public LayerMask Ground;
    // we have here declared a variable that will determine the size of a checking cirle like a scanner of somesort
    private Rigidbody2D rb;
    // we declared a function that will store the players rigid body component
    [SerializeField] private float jumpForce = 6f;
    // we made a variable that will store the force that will be used to lift the character from the ground
    public Transform groundCheckerPos;
    // this will store the position of the ground checker device
    private int numberOfJumps;
    // this is the number of times the player is able to jump
    public int extraJumps;
    // we have made this extrajumps variable so we can alter the number of numberOfJumps and not hard code its value
    private void Awake()
    {
        numberOfJumps = extraJumps;
        // we have given controlof numberOfJumps to extra jumps
        spriteRenderer = GetComponent<SpriteRenderer>();
        // here we have saved the players sprite renderer in the variable of type sprite renderer
        rb = GetComponent<Rigidbody2D>();
        // we have set the variable rb to the rigid body of the character

        //setting the custom scoreup variable to match the class Score
      scoreup=FindObjectOfType<Score>();
    }
    void Update()
    {
        dirVector.x = Input.GetAxis("Horizontal");
        dirVector.y = 0f;
        // we have declared the values to with unitys input function which move between 0 and 1 or negative value i am not so sure
        transform.position += (Vector3)dirVector * speed * Time.deltaTime;
        // we casted to vector3 (Vector3) because the operation += is ambiguous to vector3
        // we have set the players transform to a value that changes when you press down on a button
        FlipCharacter();
        // the flip function is declared in the update so it works 
        JumpMechanics();
        // the jump mechanic has been declared so it works in the game
    }
    void FlipCharacter() {
        if (dirVector.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        // we made and if function that will make the character stay in its current angle since to faces the negative x axis normally
        else if (dirVector.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        // we made an else if statement to make the character flip when it is moving towards the positive x- axis
    }
    void JumpMechanics() {
        isGrounded = Physics2D.OverlapCircle(groundCheckerPos.position, checkRadius, Ground);
        // we have set the boolean isGrounded to be set to true when the player is on the ground
        if (isGrounded == true) {
            numberOfJumps = extraJumps;
        }
        // when the player is on the ground then its number of jumps is reset to default
        if (Input.GetKeyDown(KeyCode.Space) && numberOfJumps > 0) {
            rb.velocity = Vector2.up * jumpForce;
            numberOfJumps--;
            // allows the player to jump but loses one of its jumps everytime it jumps
        }
    }
    // we have declared a function that will make the character jump by checking if the space bar key is being pressed

//here we make a reference to the "score" script attached to the platform and call the "scorevalue" variable and then increment it by 1 whenever the player comes in contact with the platform 
     private void OnCollisionEnter2D(Collision2D other) {
         
     if(other.collider.tag == "platform" && other.gameObject.GetComponent<platformScript>().steppedOn == false){
        scoreup.scorevalue++;
         
        
      
       
        }
     
     } 
        
        
          
        
    
}
