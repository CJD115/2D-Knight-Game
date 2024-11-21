using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelMove_Ref : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Collision detected");

        if (other.tag == "Player")
        {
            print("Switching scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
