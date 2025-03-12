using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public void LoadScen1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScen2()
    {
        SceneManager.LoadScene(2);
    }
}
