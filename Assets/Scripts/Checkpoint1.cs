using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    public GameObject checkPoint1;
    public static int Checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Checkpoint = 1;
            UITime.gameStarted = true;
        }
    }
}
