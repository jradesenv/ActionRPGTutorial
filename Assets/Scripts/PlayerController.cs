using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public Vector2 lastMove;

    private Animator anim;
    private bool playerMoving;
    private Rigidbody2D myRigidBody;

    private static bool playerExists;

	// Use this for initialization
	void Start () {
        if(playerExists)
        {
            Destroy(gameObject);
        } else
        {
            playerExists = true;

            anim = GetComponent<Animator>();
            myRigidBody = GetComponent<Rigidbody2D>();

            DontDestroyOnLoad(transform.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        playerMoving = false;

        if (horizontalAxis != 0.0f) //left & right
        {
            //transform.Translate(new Vector3(horizontalAxis * moveSpeed * Time.deltaTime, 0f, 0f));
            myRigidBody.velocity = new Vector2(horizontalAxis * moveSpeed, 0);
            playerMoving = true;
        }

        if (verticalAxis != 0.0f) //up & down
        {
            //transform.Translate(new Vector3(0f, verticalAxis * moveSpeed * Time.deltaTime, 0f));
            myRigidBody.velocity = new Vector2(0, verticalAxis * moveSpeed);
            playerMoving = true;
        }

        if (playerMoving)
        {
            lastMove = new Vector2(horizontalAxis, verticalAxis);
        } else
        {
            myRigidBody.velocity = new Vector2(0f, 0f);
        }

        SetAnimatorProperties(horizontalAxis, verticalAxis);
    }

    private void SetAnimatorProperties(float horizontalAxis, float verticalAxis)
    {
        anim.SetFloat("MoveX", horizontalAxis);
        anim.SetFloat("MoveY", verticalAxis);
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}
