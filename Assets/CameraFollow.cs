using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target; // Assign the target GameObject in the Inspector
    public float smoothSpeed = 0.125f; // Adjust the smoothing speed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Vector3 desiredPosition = target.position + new Vector3(0, 0, -10); // Adjust Z for desired distance
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            
    }
}
