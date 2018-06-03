using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.text=Dialogue.dialogues[Dialogue.dialogues.Length-1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
