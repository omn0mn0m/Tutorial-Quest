using UnityEngine;
using UnityEngine.UI;
using UnitySampleAssets.CrossPlatformInput;
using System.Collections;

public class DialogueManager : MonoBehaviour {

	public GameObject namePanel;
	public GameObject dialoguePanel;
	
	public bool show = false;
	private Dialogues dialogues;
	
	private bool firstShow;
	private int iterationsSinceFirstShow;

	// Use this for initialization
	void Start () {
		dialogues = new Dialogues();
		HideDialogueBox();
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton ("CloseDialogue")) {
			HideDialogueBox();
		}
//		if (!show) {
//			HideDialogueBox ();
//		} else {
//			ShowDialogueBox ();			
//		}
	}
	
	public void ShowDialogueBox() {
		GetComponent<Canvas>().enabled = true;
	}
	
	public void HideDialogueBox() {
		GetComponent<Canvas>().enabled = false;
	}
	
	public void ChangeDialogueBox(int dialogue) {
		ChangeName (dialogue);
		ChangeDialogue(dialogue);
	}
	
	public void ChangeName(int dialogue) {
		namePanel.transform.GetChild(0).GetComponent<Text>().text = dialogues.GetSpeaker(dialogue);
	}
	
	public void ChangeDialogue(int dialogue) {
		dialoguePanel.transform.GetChild(0).GetComponent<Text>().text = dialogues.GetDialogue(dialogue);
	}
}
