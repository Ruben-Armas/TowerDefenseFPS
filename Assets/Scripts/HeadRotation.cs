using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Transform headTransform;
    public Vector2 desiredLook;
    public float maxRotationAngle;
    public float rotationSpeed;

    private float rotationX = 0;

    private void FixedUpdate()
    {
        rotationX += desiredLook.y * rotationSpeed * Time.fixedDeltaTime;
        //Limita el giro
        rotationX = Mathf.Clamp(rotationX, -maxRotationAngle, maxRotationAngle);

        headTransform.rotation = Quaternion.Euler(
            rotationX,
            headTransform.eulerAngles.y,
            headTransform.eulerAngles.z);
    }
    // GIRAR LA CABEZA  (ARRIBA Y ABAJO)
    /*
    private void FixedUpdate()
    {
        headTransform.Rotate(new Vector3(desiredLook.y, 0, 0));
        //Limitamos el giro
        Vector3 clampedRotation = headTransform.rotation.eulerAngles;
        if (clampedRotation.x < 90)
        {
            clampedRotation.x = Mathf.Clamp(
                clampedRotation.x,
                0,
                maxRotationAngle);
        }
        else
        if (clampedRotation.x > 270)
        {
            clampedRotation.x = Mathf.Clamp(
                clampedRotation.x,
                360 - maxRotationAngle,
                360);
        }
        headTransform.rotation = Quaternion.Euler(clampedRotation);
    }*/
}
