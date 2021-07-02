using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    void Update()
    {
        if (Time.timeScale == 1)
        {
            float step = 0.01f;

            var cameraPosition = Camera.main.gameObject.transform.position;
            cameraPosition.y += step;
            Camera.main.gameObject.transform.position = cameraPosition;
        }
    }
}
