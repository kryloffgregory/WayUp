using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private int score;
	public Rigidbody rb;
	public float speedFactor;
	public Text ScoreText;
	public Text WinText;
	public Button WinButton;
	public GameObject rightPalm;
	public int PickUpsNumber;

	private float prevx;
	private float prevz;



	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		score = 0;
		ScoreText.text = "Your score: " + score.ToString ();
		prevx = rightPalm.transform.position.x;
		prevz = rightPalm.transform.position.y;
		WinButton.gameObject.SetActive (false);
		WinText.gameObject.SetActive (false);
	}

	void FixedUpdate() {
		float curx = rightPalm.transform.position.x;
		float curz = rightPalm.transform.position.y;
		float moveHorizontal = curx - prevx;
		float moveVertical = curz - prevz;


		Vector3 movement = new Vector3 (moveHorizontal*1, 0, moveVertical*1);
		rb.AddForce (movement * speedFactor);
		//prevx = curx;
		//prevz = curz;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);
		}
		score++;
		ScoreText.text = "Your score: " + score.ToString ();
		if (score >= PickUpsNumber) {
			WinText.gameObject.SetActive (true);
			WinButton.gameObject.SetActive (true);
		}
		
	}
}
