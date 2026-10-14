using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    public GameObject checkPoint2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Checkpoint1.Checkpoint = 2;
        }
    }
}
