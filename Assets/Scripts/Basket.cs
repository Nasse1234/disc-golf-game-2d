using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
    public GameObject newBasket;
	// Use this for initialization
	void Start () {
        transform.position = new Vector2(transform.position.x +40, Random.Range(-6, 6));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
