using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjetos : MonoBehaviour {
    public float rotationSpeed = 0.1f;
    private  Vector3 lastPos;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            lastPos = (Input.mousePosition);
        }
          else if (Input.GetMouseButton(0)) {
            var rotationX = ((Input.mousePosition).x - lastPos.x) * rotationSpeed;
            transform.Rotate(Vector3.up, -rotationX, Space.Self);
            lastPos = Input.mousePosition;
        }
    }
}

