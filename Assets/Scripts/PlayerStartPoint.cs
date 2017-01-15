using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    public Vector2 startDirection;

    private PlayerController thePlayer;
    private CameraController theCamera;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        theCamera = FindObjectOfType<CameraController>();

        thePlayer.transform.position = transform.position;
        theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);

        thePlayer.lastMove = startDirection;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
