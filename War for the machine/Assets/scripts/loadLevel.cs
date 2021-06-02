using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Wtf{

public class loadLevel : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;
    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        if(useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
            canvas.SetActive(true);

        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
}