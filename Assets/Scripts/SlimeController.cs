using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

    public float moveSpeed;
    public float timeBetweenMove;
    public float timeToMove;

    private float timeBetweenMoveCounter;
    private float timeToMoveCounter;
    private Rigidbody2D myRigidBody;
    private bool isMoving;
    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;
	}
	
	// Update is called once per frame
	void Update () {
        if (isMoving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;

            if(timeToMoveCounter < 0)
            {
                isMoving = false;
                timeBetweenMoveCounter = timeBetweenMove;
            }
        } else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = Vector2.zero;

            if(timeBetweenMoveCounter < 0)
            {
                isMoving = true;
                timeToMoveCounter = timeToMove;
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }
	}
}
