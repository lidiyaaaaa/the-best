using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float RotationSpeed;
    public Transform CameraAxisTransform;
    public float minAngle;
    public float maxAngle;

    void Start()
    {
        
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(0, 
            transform.eulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);

        var newAngleX = CameraAxisTransform.eulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
        
        if(newAngleX > 180)
        {
            newAngleX -= 360;
        }
        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);

        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);

    }
}
