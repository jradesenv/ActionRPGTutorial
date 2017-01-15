using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    public float moveSpeed;

    private Vector3 targetPosition;

    private static bool cameraExists;

    // Use this for initialization
    void Start () {
        if (cameraExists)
        {
            Destroy(gameObject);
        }
        else
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
	}
}
