using UnityEngine;
using System.Collections;

public class DialogueHolder : MonoBehaviour {
    public string dialogue;
    private DialogueManager dMan;
    // public bool dialogDestruction; // condicional, si se planea destruir hay que activarlo. si el dialogo se va a destruir despues de activarse por primera vez.
    public string[] dialogueLines;

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
       // dialogDestruction = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.W))
            {
                //dMan.ShowBox(dialogue);
                if(!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
             //   if(dialogDestruction = true)
               // {
                //    Destroy(gameObject);
                //}
            }
        }
    }
}
