using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class winner : MonoBehaviour {
    string brick = "brick";
    GameObject bricks;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindWithTag(brick) == null)
        {
            SceneManager.LoadScene(2);
        }
	}




}
