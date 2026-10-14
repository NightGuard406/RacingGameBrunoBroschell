using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint4 : MonoBehaviour
{
    public GameObject checkPoint4;
    public static int Round = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        Checkpoint1.Checkpoint = 4;
        Round++;

        if (Round == 4)
        {
            UITime.gameStarted = false;
            SceneManager.LoadScene("End");
        }
    }
}
