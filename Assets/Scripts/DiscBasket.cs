using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscBasket : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "InBasket")
        {
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().discInBasket = true;
        }
    }
    
    
}
