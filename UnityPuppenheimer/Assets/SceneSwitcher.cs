using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Call this method when the button to switch from the second to the first scene is pressed.
    public void SwitchToFirstScene()
    {
        SceneManager.LoadScene("1 Start Scene");
    }
}

