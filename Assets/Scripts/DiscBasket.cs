using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscBasket : MonoBehaviour {
    public GameObject newDisc;
    Rigidbody2D rb2d;
    
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "InBasket")
        {
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().discInBasket = true;
            
            StartCoroutine(Example());
        }
    }
    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(3);

        rb2d.isKinematic = true;
        
        rb2d.velocity = Vector3.zero;
        transform.rotation = Quaternion.identity;

        GameObject.Find("Main Camera").GetComponent<CameraMovement>().discInBasket = false;
    }


}
