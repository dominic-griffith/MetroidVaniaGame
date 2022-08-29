using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public void OnClickLoad(string scene)
    {
        SceneLoader.GetInstance().LoadSceneByName(scene);
    }

    public void OnClickExit()
    {
        SceneLoader.GetInstance().ExitGame();
    }
}
