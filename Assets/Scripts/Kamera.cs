using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject car;
    public Vector3 offset = new Vector3(0f, 0f, -6f);
    public float followSpeed = 10000f;
    public float height = 5f;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        if (car == null)
        {
            return;
        }

        Vector3 targetPosition =
            car.transform.position + car.transform.TransformDirection(offset);

        targetPosition.y = car.transform.position.y + height;

        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPosition,
            ref velocity,
            1f / Mathf.Max(followSpeed, 0.01f)
        );

        Vector3 lookAtTarget = car.transform.position;
        lookAtTarget.y = transform.position.y;
        transform.LookAt(lookAtTarget);
    }
}
