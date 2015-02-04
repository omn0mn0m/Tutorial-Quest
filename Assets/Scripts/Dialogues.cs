using UnityEngine;
using System.Collections;

public class Dialogues {
	
	// Dialogue Number IDs
	public const int FIRST_AWAKE = 0;
	public const int DEATH_INTERNAL = 1;
	
	private string[] dialogues;
	private string[] speakers;
	
	public Dialogues() {
		dialogues[0] = "Where am I?";
		dialogues[1] = "That hurt... better not fall again.";
		
		speakers[0] = "Thought";
		speakers[1] = "Thought";
	}
	
	public string GetDialogue(int dialogueNumber) {
		return dialogues[dialogueNumber];
	}
	
	public string GetSpeaker(int dialogueNumber) {
		return speakers[dialogueNumber];
	}
}
