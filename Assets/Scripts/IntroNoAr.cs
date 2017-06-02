using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroNoAr : MonoBehaviour {

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            LoadGameScene();
        }
    }

}
