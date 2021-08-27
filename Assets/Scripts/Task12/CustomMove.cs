using System;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class CustomMove : MonoBehaviour
{

    public float speed = 1.0F;
    public float rotateSpeed = 1.0F;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        var coeffSpeed = vertical > 0 ? 1f : 0.8f; 

        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, horizontal * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * vertical * coeffSpeed;
        controller.SimpleMove(forward * curSpeed);
    }
}
