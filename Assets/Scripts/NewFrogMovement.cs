using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFrogMovement : MonoBehaviour
{

    public float MoveSpeed = 6f;
    public float RotateSpeed = 65f;

    //public float jumpAmount = 8;
    public bool isGrounded = true;

    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
        _rb.AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
        isGrounded = false;
        }

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    _rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}

