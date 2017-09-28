using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStartForce : MonoBehaviour {
    bool spacePressed;
    bool ballShot;

    float[] numbers;
    Rigidbody2D rb;

    public float speed;

	// Use this for initialization
	void Start () {
        ballShot = false;
        rb = GetComponent<Rigidbody2D>();
        numbers = new float[2];
        numbers[0] = 1f;
        numbers[1] = -1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            spacePressed = true;
        }
        if (spacePressed == true && ballShot == false)
        {
            int i = Random.Range(0, 1);
            float y = numbers[i];
          rb.AddForce(new Vector3(speed*y ,speed , 0));
            ballShot = true;
        }
	}
}
