using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame() {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void StartCredits() {
        SceneManager.LoadScene(2);
        SceneManager.UnloadSceneAsync(0);
    }
}
