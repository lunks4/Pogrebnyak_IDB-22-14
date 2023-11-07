using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private Rigidbody rb;
    [SerializeField]private float speed = 1;
    [SerializeField] private Transform camTrans;
    [SerializeField] private float mouseSensitivity = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        UnityEngine.Vector3 camForwDir = camTrans.forward;
        camForwDir.y = 0;
        UnityEngine.Vector3 camRightDir = camTrans.right;
        camRightDir.y = 0;

        UnityEngine.Vector3 movDir = camForwDir.normalized * ver + camRightDir.normalized * hor;
        movDir = new UnityEngine.Vector3(movDir.x, rb.velocity.y, movDir.z);
        rb.velocity = UnityEngine.Vector3.ClampMagnitude(movDir,1) * speed;

        //rb.angularVelocity = new UnityEngine.Vector3(0,0,0);

        if (camTrans.rotation.eulerAngles.x - mouseY > 280 || camTrans.rotation.eulerAngles.x - mouseY < 80)
        camTrans.rotation = UnityEngine.Quaternion.Euler(camTrans.rotation.eulerAngles.x - mouseY*mouseSensitivity, camTrans.rotation.eulerAngles.y, camTrans.rotation.eulerAngles.z);
        transform.rotation = UnityEngine.Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseX*mouseSensitivity, transform.rotation.eulerAngles.z);

    }
}
