using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTrigger : MonoBehaviour {
    public bool inBasket;
    public GameObject newBasket;
	// Use this for initialization
	void Start () {
        inBasket = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            inBasket = true;
            Instantiate(newBasket);
            StartCoroutine(Example());
        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(4);
        inBasket = false;
        Destroy(transform.parent.gameObject);

    }
}
