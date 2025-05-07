using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    public Vector2 minBounds, maxBounds;
    public float smoothSpeed = 0.1f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desired = new Vector3(
            Mathf.Clamp(target.position.x, minBounds.x, maxBounds.x),
            Mathf.Clamp(target.position.y, minBounds.y, maxBounds.y),
            transform.position.z
        );
        transform.position = Vector3.Lerp(transform.position, desired, smoothSpeed);
    }


}