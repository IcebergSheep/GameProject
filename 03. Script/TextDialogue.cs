using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
	[TextArea]
	public string dialogue;
}
public class TextDialogue : MonoBehaviour {
	[SerializeField] private Text txt_Dialogue;
    [SerializeField] private Dialogue[] dialogue;

    private bool isDialogue = false;

	private int count = 0;
	
	void Start ()
	{
		ShowDialogue();
	}
	public void ShowDialogue()
	{
		txt_Dialogue.gameObject.SetActive(true);

		count = 0;
		isDialogue = true;
		NextDialogue();
	}

	private void NextDialogue()
	{
		txt_Dialogue.text = dialogue[count].dialogue;
		count++;
	
	}
	private void HideDialogue()
	{
        txt_Dialogue.gameObject.SetActive(false);

        count = 0;
        isDialogue = false;

    }
	void Update()
	{
        
        if (isDialogue) { 
			if(Input.GetKeyDown(KeyCode.Return))
			{
				if(count<dialogue.Length)
				{
					NextDialogue();

				}
				else
				{
					HideDialogue();
				}
			}
		}
	}
}
