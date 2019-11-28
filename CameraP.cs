using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour { 
public Transform target;
public float smoothing;

    // Start is called before the first frame update
    void Start()
{

}

// Update is called once per frame
void LateUpdate()
{
    if (transgorm.position != targer.position)
    {
            Vector3 targetPosition = new Vector3(targetPosition.position.x, targetPosition.position.y, Transform.position.z);
        Transform.position = Vector3.Lerp(Transform.position, targerPosition, smoothing);


            }

}
}