using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public static SceneLoader Instance;


    //Singleton Design Pattern
    public void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static SceneLoader GetInstance()
    {
        return Instance;
    }


    //Scene Loading
    public void LoadSceneByNumber(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadSceneByName(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(GetCurrentScene());
    }


    //Helper Methods
    public int GetCurrentScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }


    //Exit
    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
