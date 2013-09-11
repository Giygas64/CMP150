using UnityEngine;
using System.Collections;
using System;


public class CharacterMovement : MonoBehaviour {

    public float MoveSpeed = 5f;
    public Control MoveForward;
    public Control MoveBackward;
    public Control MoveRight;
    public Control MoveLeft;
    public Control Jump;
    public Control Crouch;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (MoveForward.IsActive)
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime));
        if (MoveBackward.IsActive)
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime * -1));
        if (MoveRight.IsActive)
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime));
        if (MoveLeft.IsActive)
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime * -1));
        if (Jump.IsActive)
            transform.Translate(transform.up * (MoveSpeed * Time.deltaTime));
        if (Crouch.IsActive)
            transform.Translate(transform.up * (MoveSpeed * Time.deltaTime * -1));
       
	}
}
