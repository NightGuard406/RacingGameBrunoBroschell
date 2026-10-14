using UnityEngine;

public class Checkpoint3 : MonoBehaviour
{
    public GameObject checkPoint3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Checkpoint1.Checkpoint = 3;
        }
    }
}
