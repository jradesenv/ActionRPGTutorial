using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        playerMoving = false;

        if (horizontalAxis != 0.0f) //left & right
        {
            transform.Translate(new Vector3(horizontalAxis * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
        }

        if (verticalAxis != 0.0f) //up & down
        {
            transform.Translate(new Vector3(0f, verticalAxis * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
        }

        if (playerMoving)
        {
            lastMove = new Vector2(horizontalAxis, verticalAxis);
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
