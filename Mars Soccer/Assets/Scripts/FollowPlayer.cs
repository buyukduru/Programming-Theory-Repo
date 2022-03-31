using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform Player;

    [SerializeField]
    private float distanceFromObject = 3f;

    Vector3 offset;
    Vector3 lookOnObject;
    Vector3 playerLastPosition;

    public float speed = 2.0f;
    public float sensibility = 2.0f;

    GameObject player;



    float leftright;
    float backforward;

    float Xrotate;
    float Yrotate;


    private void Start()
    {

      
        lookOnObject = Player.position - transform.position;

        player = GameObject.Find("Player");
     
    }
    void  Update()
    {

        if (player.gameObject !=null)
        {

      

            lookOnObject = Player.position - transform.position;
            transform.forward = lookOnObject.normalized;

            playerLastPosition = Player.position - lookOnObject.normalized * distanceFromObject;
            playerLastPosition.y = Player.position.y + distanceFromObject / 2;

            transform.position = playerLastPosition;

          }
    }

    
       

}
