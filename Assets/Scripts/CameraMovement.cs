using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public bool discInBasket = false;
    private Vector2 velocity;
    private Vector3 startpos;
    private Vector3 endpos;
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        startpos = new Vector3(transform.position.x, transform.localPosition.y, transform.localPosition.z);
        endpos = new Vector3(transform.position.x + 40, transform.localPosition.y, transform.localPosition.z);
        
        
    }
	
	// Update is called once per frame
	void Update () {
		if(discInBasket == true)
        {

            cameraMove(); 
        }
	}
    void cameraMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, endpos, 10 * Time.deltaTime);
        
    }
}
