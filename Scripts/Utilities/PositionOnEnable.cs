using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionOnEnable : MonoBehaviour
{
    [SerializeField]
    private Transform transformToClone;
    [SerializeField]
    private bool inFrontOfCamera = false;
    [SerializeField]
    private float cameraDistance = 2.5f;

    private void OnEnable()
    {
        if (transformToClone)
        {
            transform.position = transformToClone.position;
            transform.rotation = transformToClone.rotation;
        }
        else if (inFrontOfCamera)
        {
            transform.position = CameraCache.Main.transform.position + CameraCache.Main.transform.forward * cameraDistance;
            transform.rotation = Quaternion.LookRotation(CameraCache.Main.transform.forward);
        }
    }
}
