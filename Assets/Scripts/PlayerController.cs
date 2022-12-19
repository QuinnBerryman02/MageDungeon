using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] float speed;
    private Rigidbody rb;
    [SerializeField] GameObject cameraObject;
    Vector2 mousePos = Vector2.zero;
    [SerializeField] float sensitivity;


    public void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector3 v = transform.forward * verti + 
                    transform.right * hori;
        rb.MovePosition(transform.position + (v * speed * Time.deltaTime));

        mousePos += sensitivity * new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
        mousePos.y = Mathf.Clamp(mousePos.y, -90f, 90f);
        cameraObject.transform.localEulerAngles = new Vector3(mousePos.y, 0, 0);
        transform.localEulerAngles = new Vector3(0, mousePos.x, 0);
    }
}
