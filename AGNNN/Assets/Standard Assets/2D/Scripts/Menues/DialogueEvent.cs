using UnityEngine;
using System.Collections;

public class DialogueEvent : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMan;
    public bool dialogDestruction; // condicional, si se planea destruir hay que activarlo. si el dialogo se va a destruir despues de activarse por primera vez.
    public string[] dialogueLines;

   
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        dialogDestruction = false;
    }

    
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
               if (!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }

                  if(dialogDestruction = true)
                 {
                   Destroy(gameObject);
                }
            }
        }
    }

