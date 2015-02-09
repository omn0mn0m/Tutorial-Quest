using UnityEngine;
using System.Collections;

public class Dialogues {
	
	// Dialogue Number IDs
	public const int FIRST_AWAKE = 0;
	public const int DEATH_INTERNAL = 1;
	public const int DIALOGUE_OPEN = 2;
	
	public const int NOTE_1 = 3;
	public const int NOTE_2 = 4;
	public const int NOTE_3 = 5;
	
	public const int NARRATOR_1 = 6;
	public const int NARRATOR_2 = 7;
	public const int NARRATOR_3 = 8;
	public const int NARRATOR_4 = 9;
	public const int NARRATOR_5 = 10;
	
	public const int NARRATOR_6 = 11;
	public const int NARRATOR_7 = 12;
	
	public const int NOTE_4 = 13;
	
	public const int NARRATOR_8 = 14;
	public const int NARRATOR_9 = 15;
	public const int NARRATOR_10 = 16;
	public const int NARRATOR_11 = 17;
	
	public const int NARRATOR_12 = 18;
	public const int NARRATOR_13 = 19;
	public const int NARRATOR_14 = 20;
	public const int NARRATOR_15 = 21;
	
	public const int GAME = 22;
	
	private string[] dialogues;
	private string[] speakers;
	private int numberOfDialogues = 23;
	
	public Dialogues() {
		dialogues = new string[numberOfDialogues];
		speakers = new string[numberOfDialogues];
		
		dialogues[FIRST_AWAKE] = "Where am I?";
		dialogues[DEATH_INTERNAL] = "That hurt... better not fall again.";
		dialogues[DIALOGUE_OPEN] = "Words resonate in your head... Maybe you can find a way to make them go away.";
		dialogues[NOTE_1] = "Use A to move left and L to move right";
		dialogues[NOTE_2] = "Sometimes it's hard to get high. That's what double jumping is for. Use T.";
		dialogues[NOTE_3] = "If you want to scale vertically, you have to use Y.";
		
		dialogues[NARRATOR_1] = "Hey.";
		dialogues[NARRATOR_2] = "It looks like you're struggling a little.";
		dialogues[NARRATOR_3] = "Let me help you out.";
		dialogues[NARRATOR_4] = "Trust me; jump here.";
		dialogues[NARRATOR_5] = "See? I can help you finish this. Call me Tutorial.";
		
		dialogues[NARRATOR_6] = "Oops... Wrong door. My bad.";
		dialogues[NARRATOR_7] = "Don't touch those notes. They speak lies and deceit.";
		
		dialogues[NARRATOR_8] = "You looked at the note, didn't you? I guess I'll have to terminate you.";
		dialogues[NARRATOR_9] = "Oh you didn't? Well how can I trust you? Better safe than sorry.";
		dialogues[NARRATOR_10] = "You could be lying. I could have been lying.";
		dialogues[NARRATOR_11] = "The notes could have been too...";
		
		dialogues[NARRATOR_12] = "But why would you ever lie to yourself?";
		dialogues[NARRATOR_13] = "That's right. The notes. Me. You.";
		dialogues[NARRATOR_14] = "We're all the same twisted mind. You can't escape.";
		dialogues[NARRATOR_15] = "So try to figure out this game. I dare myself.";
		
		dialogues[NOTE_4] = "Tutorial is full of bad news.";
		
		dialogues[GAME] = "TO BE CONTINUED AT STATES";
		
		speakers[FIRST_AWAKE] = "Thought";
		speakers[DEATH_INTERNAL] = "Thought";
		speakers[DIALOGUE_OPEN] = "Thought";
		
		speakers[NOTE_1] = "Note";
		speakers[NOTE_2] = "Note";
		speakers[NOTE_3] = "Note";
		
		speakers[NARRATOR_1] = "???";
		speakers[NARRATOR_2] = "???";
		speakers[NARRATOR_3] = "???";
		speakers[NARRATOR_4] = "???";
		speakers[NARRATOR_5] = "Tutorial";
		
		speakers[NARRATOR_6] = "Tutorial";
		speakers[NARRATOR_7] = "Tutorial";
		
		speakers[NOTE_4] = "Note";
		
		speakers[NARRATOR_8] = "Tutorial";
		speakers[NARRATOR_9] = "Tutorial";
		speakers[NARRATOR_10] = "Tutorial";
		speakers[NARRATOR_11] = "Tutorial";
		
		speakers[NARRATOR_12] = "Tutorial";
		speakers[NARRATOR_13] = "Tutorial";
		speakers[NARRATOR_14] = "Myself";
		speakers[NARRATOR_15] = "Myself";
		
		speakers[GAME] = "Game";
	}
	
	public string GetDialogue(int dialogueNumber) {
		return dialogues[dialogueNumber];
	}
	
	public string GetSpeaker(int dialogueNumber) {
		return speakers[dialogueNumber];
	}
}
