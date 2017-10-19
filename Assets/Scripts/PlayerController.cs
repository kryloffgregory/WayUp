using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private int score;
	public Rigidbody rb;
	public float speedFactor;
	public Text ScoreText;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		score = 0;
		ScoreText.text = "Your score: " + score.ToString ();
	}
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal*10, 0, moveVertical*10);
		rb.AddForce (movement * speedFactor);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);
		}
		score++;
		ScoreText.text = "Your score: " + score.ToString ();
	}
}
