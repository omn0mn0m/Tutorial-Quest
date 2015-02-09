using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PreGameIntro : MonoBehaviour {

	public int level;
	public int delay;
	
	private int iterations;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.GetComponent<Text>().text == "Time to wake up.") {
			if (iterations >= delay) {
				Application.LoadLevel (level);
			} else {
				iterations += 1;
			}
		}
	}
}
