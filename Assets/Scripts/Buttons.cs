using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    public void PlayLevel1() {
        SceneManager.LoadScene(1);
    }

    public void PlayLevel2() {
        SceneManager.LoadScene(2);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
