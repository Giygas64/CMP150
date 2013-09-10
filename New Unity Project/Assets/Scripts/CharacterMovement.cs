using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float MoveSpeed = 5f;
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBackward = KeyCode.S;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveForward1 = KeyCode.UpArrow;
    public KeyCode MoveBackward1 = KeyCode.DownArrow;
    public KeyCode MoveRight1 = KeyCode.RightArrow;
    public KeyCode MoveLeft1 = KeyCode.LeftArrow;
    public KeyCode Jump = KeyCode.Space;
    public KeyCode Crouch = KeyCode.LeftControl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(MoveForward) || Input.GetKey(MoveForward1))
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(MoveBackward) || Input.GetKey(MoveBackward1))
                transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime * -1));
        if (Input.GetKey(MoveRight) || Input.GetKey(MoveRight1))
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(MoveLeft) || Input.GetKey(MoveLeft1))
                transform.Translate(transform.right * (MoveSpeed * Time.deltaTime * -1));
        if (Input.GetKey(Jump))
            transform.Translate(transform.up * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(Crouch))
                transform.Translate(transform.up * (MoveSpeed * Time.deltaTime * -1));
       
	}
}
