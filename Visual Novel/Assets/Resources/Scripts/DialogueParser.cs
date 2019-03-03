using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

public class DialogueParser : MonoBehaviour {

	List<DialogueLine> lines = new List<DialogueLine>(); 

	struct DialogueLine {
		string name;
		string content;
		int pose;

		public DialogueLine(string n, string c, int p){
			name = n;
			content = c;
			pose = p;
		}
	}

	// Use this for initialization
	void Start () {
		string file = "Dialogue";
		string sceneName = EditorSceneManager.GetActiveScene().name;
		sceneName = Regex.Replace (sceneName, "[^0-9]", "");
		file += sceneName + ".txt";

		LoadDialogue (file);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadDialogue(string filename) {
		string file = "Assets/Resources/" + filename;
		string line;
		StreamReader fileptr = new StreamReader (file);
		using (fileptr) {
			while ((line = fileptr.ReadLine ()) != null) {
				
				if (line != null) {
					string[] line_values = line.Split ('|');
					DialogueLine line_entry = new DialogueLine (line_values [0], line_values [1], int.Parse (line_values [2]));
					lines.Add (line_entry);
				}
			}
			fileptr.Close ();
		}
	}
}
