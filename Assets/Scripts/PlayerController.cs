using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        if (horizontalAxis != 0.0f) //left & right
        {
            transform.Translate(new Vector3(horizontalAxis * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (verticalAxis != 0.0f) //up & down
        {
            transform.Translate(new Vector3(0f, verticalAxis * moveSpeed * Time.deltaTime, 0f));
        }

        anim.SetFloat("MoveX", horizontalAxis);
        anim.SetFloat("MoveY", verticalAxis);
    }
}
