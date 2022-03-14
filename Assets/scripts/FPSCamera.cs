using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {

    public Joystick JoystickLeft;
    public Joystick JoystickRight;

    public Camera FPScamera;
    public float horizontalSpeed;
    public float verticalSpeed;
    public float moveSpeed;
    public float cameraSpeed;
    float h;
    float v;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //   h = horizontalSpeed * Input.GetAxis("MouseX");
        //  v = verticalSpeed * Input.GetAxis("JoystickRight");
        //  transform.Rotate(0, h, 0);
        //  FPScamera.transform.Rotate(-v, 0, 0);

        transform.Rotate(0, cameraSpeed * JoystickRight.Horizontal, 0);
        FPScamera.transform.Rotate(-cameraSpeed * JoystickRight.Vertical, 0, 0);

        transform.Translate(JoystickLeft.Horizontal * moveSpeed, 0, JoystickLeft.Vertical * moveSpeed);

      //  Vector3 moveVector = (transform.right * JoystickLeft.Vertical + -transform.forward * JoystickLeft.Horizontal).normalized;
      //  transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}
