using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class scenemanager : MonoBehaviour
{
    public void s1()
    {
        SceneManager.LoadScene(1);
    }
    public void s2()
    {
        SceneManager.LoadScene(2);
    }
    public void s3()
    {
        SceneManager.LoadScene(0);
    }
}
