using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 minBound = new Vector3(-Mathf.Infinity, -Mathf.Infinity, -10);
    public Vector3 maxBound = new Vector3(Mathf.Infinity, Mathf.Infinity, -10);


    private void FixedUpdate()
    {
        TrackPlayer();
    }

    private void TrackPlayer()
    {
        Vector3 desiredPos = player.position + offset;
        Vector3 boundPos = new Vector3( //gives camera boundaries
            Mathf.Clamp(desiredPos.x, minBound.x, maxBound.x),
            Mathf.Clamp(desiredPos.y, minBound.y, maxBound.y),
            Mathf.Clamp(desiredPos.z, minBound.z, maxBound.z));

        Vector3 smoothedPos = Vector3.Lerp(transform.position, boundPos, smoothSpeed);
        transform.position = smoothedPos;
    }
}