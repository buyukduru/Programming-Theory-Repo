using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody rigidBody;

    
  
    private float fallingDistance =-20.0f;

    [SerializeField]
    private Text gameOverText;

 

    void Start()
    {

        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


            rigidBody.AddForce(movement * playerSpeed);
        
        GameOver();
    }
    private void GameOver()
    {
        if (transform.position.y< fallingDistance)
        {
            
          
     gameOverText.GetComponent<Text>().enabled = true;
          
            Destroy(rigidBody.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Shape"))
        {

            ScoreScript.scoreValue += 10;

            Destroy(collision.gameObject);
          
        }
     
    }
   


}

