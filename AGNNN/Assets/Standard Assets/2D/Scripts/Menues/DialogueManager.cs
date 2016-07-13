using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;
    private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogActive && Input.GetKeyDown(KeyCode.Return))
                {
            // dBox.SetActive(false);
            //dialogActive = false;
            currentLine++;
        }

        if(currentLine >= dialogLines.Length)
        {
            thePlayer.canMove = true;
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }
        dText.text = dialogLines[currentLine];
    }

    public void ShowBox(string dialogue)

    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        //thePlayer.canMove = false;
    }
    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
       thePlayer.canMove = false;
    }

}
