using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscBasket : MonoBehaviour {
    public GameObject newDisc;
    Rigidbody2D rb2d;
    public Text scoreText;
    public int score;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "" + score;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "InBasket")
        {
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().discInBasket = true;
            score = score +1;
            
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
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Hill")
        {
            print("gameover");

        }
    }


}
