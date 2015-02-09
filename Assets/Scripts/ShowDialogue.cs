using UnityEngine;
using System.Collections;

public class ShowDialogue : MonoBehaviour {

	DialogueManager manager;
	public int dialogue;

	// Use this for initialization
	void Start () {
		manager = GameObject.FindGameObjectWithTag("DialogueBox").GetComponent<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			manager.ShowDialogueBox();
			manager.ChangeDialogueBox(dialogue);
		}
	}
}
