using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiscBasket : MonoBehaviour {
    public GameObject newDisc;
    Rigidbody2D rb2d;
    public Text scoreText;
    public Text scoreRecordText;
    public int score;
    public int scoreBest;
    public GameObject gameOver;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        scoreRecordText.enabled = false;
        rb2d = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        scoreBest = PlayerPrefs.GetInt("recordScore");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "InBasket")
        {
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().discInBasket = true;
            score++;
            scoreText.text = "" + score;
            if(score > scoreBest)
            {
                scoreBest = score;
                PlayerPrefs.SetInt("recordScore", scoreBest);
            }
            audioSource.Play();
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
        if(col.gameObject.name == "Hill" || rb2d.position.y == -10 || col.gameObject.name == "mäki" )
        {
            scoreRecordText.text = "your best score: " + scoreBest;
            scoreRecordText.enabled = true;
            gameOver.SetActive(true);

        }
        
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }


}
