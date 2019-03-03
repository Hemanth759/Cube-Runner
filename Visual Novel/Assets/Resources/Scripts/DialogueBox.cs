using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour {

	DialogueParser parser;

	public string dialogue;
	int lineNum;

	public GUIStyle customstyle;

	// Use this for initialization
	void Start () {
		dialogue = "";
		parser = GameObject.Find ("Dialogue Parser Obj").GetComponent<DialogueParser> ();
		lineNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			dialogue = parser.GetContent (lineNum);
			lineNum++;
		}
	}

	void OnGUI() {
		dialogue = GUI.TextField (new Rect (100, 400, 500, 200), dialogue, customstyle);
	}
}
