using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    private void FixedUpdate()
    {

        Vector3 desiredPos = player.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;

    }
}