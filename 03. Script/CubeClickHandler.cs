using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeClickHandler : MonoBehaviour {

    public string sceneToLoad;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // 이름 비교
        {
            Debug.Log("큐브가 클릭되었습니다.");

            // Scene 전환 로직
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
