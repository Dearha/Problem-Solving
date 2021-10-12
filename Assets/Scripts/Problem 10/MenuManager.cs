using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Update()
    {
        string scenename = SceneManager.GetActiveScene().name;
        if (Input.GetKey(KeyCode.Escape))
        {
            if (scenename != "Problem 10")
            {
                SceneManager.LoadScene("Problem 10");
            }
            else
            {
                Application.Quit();
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void SelectScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
