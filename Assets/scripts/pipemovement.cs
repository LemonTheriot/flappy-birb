using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour {

    public float movespeed;


	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.back* (movespeed * Time.deltaTime);
	}
}
