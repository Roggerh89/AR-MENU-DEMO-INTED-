using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarRuleta : MonoBehaviour {
    public float rotationSpeed = 0.1f;
    private  Vector3 lastPos;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            lastPos = (Input.mousePosition);
        }
          else if (Input.GetMouseButton(0)) {
            var rotationY = ((Input.mousePosition).y - lastPos.y) * rotationSpeed;
            transform.Rotate(Vector3.right, -rotationY, Space.Self);
           lastPos = Input.mousePosition;
        }
    }
}

