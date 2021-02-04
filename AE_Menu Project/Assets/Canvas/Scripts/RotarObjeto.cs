using UnityEngine;

public class RotarObjeto : MonoBehaviour {
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDrag() {
        dragging = true;
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonUp(0)){
            dragging = false;
        }
    }
    void FixedUpdate(){
        if (dragging){
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime; //eje X
             float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime; //eje Y

            rb.AddTorque(Vector3.down*x); // rotate around its axis (horizontal)
            rb.AddTorque(Vector3.right*y);
        }
    }
}
