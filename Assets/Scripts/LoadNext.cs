using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LoadNextScene),2f);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }


}
