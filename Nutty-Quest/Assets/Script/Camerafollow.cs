using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]                   //makes it possible to choose how smooth the camera can be
    public float smoothFactor;      // makes the camera move smoothly


    private void FixedUpdate()
    {
        Follow();
    }


    void Follow()
    {
        Vector3 targetPosition = target.position + offset;              
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition,smoothFactor*Time.fixedDeltaTime);         //Makes the smooth camera follow the camera by taking the targetsposition
        transform.position = smoothPosition;
    }
}
