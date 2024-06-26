using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour {

	
	public AudioSource clickSound;
	// Update is called once per frame
	public void CS()
	{
        clickSound.Play();
	}
}
