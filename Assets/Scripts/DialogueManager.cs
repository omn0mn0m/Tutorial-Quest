using UnityEngine;
using System.Collections;

public class DialogueManager {

	private Dialogues dialogueList;
	
	private int currentStoryDialogue = 0;

	public DialogueManager() {
	
	}
	
	public int GetStoryDialogueNumber() {
		return currentStoryDialogue;
	}
	
	public void SetStoryDialogueNumber(int currentStoryDialogue) {
		this.currentStoryDialogue = currentStoryDialogue;
	}
}
