using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector2(10, Random.Range(-6, 6));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
