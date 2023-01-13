using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    

    void Update()
    {
        transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y+3f, transform.position.z);
    }
}
