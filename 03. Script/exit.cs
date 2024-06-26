using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class exit : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }
    


}
