using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;

    public Text countText;

    public Text winText;

    public Text gameOverText;

    private Rigidbody2D rb2d;

    private int count;

    AudioSource audioSource;

    AudioClip clip;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> () ;
        count = 0;
        winText.text = "";
        gameOverText.text = "";
        SetCountText();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
		#if UNITY_ANDROID

		Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, 0.0f);
		rb2d.velocity = movement * speed;

		#else

		float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
		#endif
	}


    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 26)
        {
            winText.text = "Congratulations, You win.";
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
  
        Debug.Log("Collided with " + collision.collider.name);

        if (collision.collider.gameObject.CompareTag("Coin"))
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (collision.collider.gameObject.CompareTag("Bomb"))
        {
            collision.collider.gameObject.SetActive(false);
            Debug.Log("Bombed");
            gameOverText.text = "GAME OVER";
        }

        switch (collision.collider.gameObject.name) {

            case "A":
                clip = (AudioClip)Resources.Load("A");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "B":
                clip = (AudioClip)Resources.Load("B");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "C":
                clip = (AudioClip)Resources.Load("C");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "D":
                clip = (AudioClip)Resources.Load("D");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "E":
                clip = (AudioClip)Resources.Load("E");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "F":
                clip = (AudioClip)Resources.Load("F");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "G":
                clip = (AudioClip)Resources.Load("G");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "H":
                clip = (AudioClip)Resources.Load("H");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "I":
                clip = (AudioClip)Resources.Load("I");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "J":
                clip = (AudioClip)Resources.Load("J");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "K":
                clip = (AudioClip)Resources.Load("K");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "L":
                clip = (AudioClip)Resources.Load("L");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "M":
                clip = (AudioClip)Resources.Load("M");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "N":
                clip = (AudioClip)Resources.Load("N");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "O":
                clip = (AudioClip)Resources.Load("O");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "P":
                clip = (AudioClip)Resources.Load("P");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Q":
                clip = (AudioClip)Resources.Load("Q");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "R":
                clip = (AudioClip)Resources.Load("R");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "S":
                clip = (AudioClip)Resources.Load("S");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "T":
                clip = (AudioClip)Resources.Load("T");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "U":
                clip = (AudioClip)Resources.Load("U");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "V":
                clip = (AudioClip)Resources.Load("V");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "W":
                clip = (AudioClip)Resources.Load("W");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "X":
                clip = (AudioClip)Resources.Load("X");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Y":
                clip = (AudioClip)Resources.Load("Y");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Z":
                clip = (AudioClip)Resources.Load("Z");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Bomb":
                clip = (AudioClip)Resources.Load("gameover");
                audioSource.clip = clip;
                audioSource.Play();
                break;
        }

    }
}
