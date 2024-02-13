using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        if (mainCamera is not null)
        {
            var lensTransform = transform;
            Vector3 toMainCamera = mainCamera.transform.position - lensTransform.position;
            

            Quaternion relativeRotation = Quaternion.LookRotation(-toMainCamera, lensTransform.up);
            lensTransform.rotation = relativeRotation;
        }
    }
}
