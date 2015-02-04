using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour {

	public GameObject target;
	public int level;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (other.gameObject.name);
		if (other.tag == "Player") {
			Application.LoadLevel(level);
		}
	}
}
