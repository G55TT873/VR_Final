using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarkerScene : MonoBehaviour
{
    public void SceneSwitch()
    {
        SceneManager.LoadScene(2);
    }
}
