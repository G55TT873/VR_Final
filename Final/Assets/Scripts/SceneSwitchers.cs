using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchers : MonoBehaviour
{
    // Start is called before the first frame update
    public void MarkerSwitch()
    {
        SceneManager.LoadScene(2);
    }
    public void MarkerlessSwitch()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenuSwitch()
    {
        SceneManager.LoadScene(0);
    }
}
