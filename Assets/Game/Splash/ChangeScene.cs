using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void ChangeSceneByName(string SCname = "Game")
    {
        SceneManager.LoadScene(SCname);
    }
}
