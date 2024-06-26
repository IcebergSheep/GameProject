using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour {


    public void SC_Main()
    {
        SceneManager.LoadScene("Main");
    }
    public void SC_Start() {
		SceneManager.LoadScene("Start"); 
	}

	public void SC_Seconde()
    {
        SceneManager.LoadScene("seconde");
    }

    public void SC_Three()
    {
        SceneManager.LoadScene("three");
    }

    public void SC_Four()
    {
        SceneManager.LoadScene("four");
    }
}
