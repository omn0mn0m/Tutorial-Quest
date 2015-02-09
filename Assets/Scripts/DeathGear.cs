using UnityEngine;
using System.Collections;

public class DeathGear : MonoBehaviour {

	public bool spinning;
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spinning) {
			transform.Rotate (Vector3.forward, speed * Time.deltaTime);
		}
	}
}
