using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 cameraOffset;
    public Vector3 targetedPosition;
    private Vector3 velocity = Vector3.zero;

    public float smoothTime = 0.3f;
    // Update is called once per frame
    void LateUpdate()
    {
        targetedPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetedPosition, ref velocity, smoothTime );
    }
}
