using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10f;
	private bool facingLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.transform.position += Vector3.up * Time.deltaTime * speed;
		}
		
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			if (!facingLeft) {
				Flip();
			}
			rigidbody2D.transform.position += Vector3.left * Time.deltaTime * speed;
		}
		
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			rigidbody2D.transform.position += Vector3.down * Time.deltaTime * speed;
		}
		
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			if (facingLeft) {
				Flip();
			}
			rigidbody2D.transform.position += Vector3.right * Time.deltaTime * speed;
		}
	}

	void Flip() {
		facingLeft = !facingLeft;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
