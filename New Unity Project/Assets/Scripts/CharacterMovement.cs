using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float MoveSpeed = 5f;
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBackward = KeyCode.S;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode Jump = KeyCode.Space;
    public KeyCode Crouch = KeyCode.LeftControl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(MoveForward) || Input.GetKey(KeyCode.UpArrow))
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(MoveBackward) || Input.GetKey(KeyCode.DownArrow))
                transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime * -1));
        if (Input.GetKey(MoveRight) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(MoveLeft) || Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(transform.right * (MoveSpeed * Time.deltaTime * -1));
        if (Input.GetKey(Jump))
            transform.Translate(transform.up * (MoveSpeed * Time.deltaTime));
        else
            if (Input.GetKey(Crouch))
                transform.Translate(transform.up * (MoveSpeed * Time.deltaTime * -1));
       
	}
}
