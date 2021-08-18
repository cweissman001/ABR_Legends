using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAndDragCamera : MonoBehaviour
{
	float theta_x = 0.0f;
	float theta_y = 0.0f;
	float rot_speed = 10;
	float truck;
	float truckSpeed = 1.0f;
	float panSpeed = 0.1f;
	Vector2 panAmt = Vector2.zero;

	bool shiftPressed = false;
	bool ctrlPressed = false;

	void Start()
	{
		// Currently this script can be attached to a camera that is attached to an object 
		// to allow rotation in game view around that object
	}
	void Update()
	{
		// Make sure the mouse is not over the GUI
		if (EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		// Shift-click pans the camera
		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
		{
			shiftPressed = true;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
		{
			shiftPressed = false;
		}
		if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
		{
			ctrlPressed = true;
		}
		if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.RightControl))
		{
			ctrlPressed = false;
		}

		var pan = Input.GetMouseButton(0) && shiftPressed && !ctrlPressed;
		var orbit = Input.GetMouseButton(0) && !shiftPressed;
		var zoom = Input.GetMouseButton(1) || (Input.GetMouseButton(0) && ctrlPressed);

		if (pan)
		{
			var x = -Input.GetAxis("Mouse X") * panSpeed;
			var y = -Input.GetAxis("Mouse Y") * panSpeed;

			panAmt += new Vector2(x, y);

			var cam = this.transform.GetChild(0);
			var pos = this.transform.position;

			pos = cam.transform.right * panAmt.x + cam.transform.up * panAmt.y;
			this.transform.position = pos;
		}

		if (orbit)
		{
			// use a theta that represents rotational angle around the mouse's position
			// change in mouse position and rotation
			var rot_x = -Input.GetAxis("Mouse Y") * rot_speed;
			var rot_y = Input.GetAxis("Mouse X") * rot_speed;

			// add or subtract from theta the rotational change
			// angle is clamped -90 to 90 for the y direction, and ranges 0-360 for x
			theta_x += rot_x;
			theta_x = Mathf.Clamp(theta_x, -90f, 90f);

			theta_y += rot_y;
			theta_y = (theta_y + 360.0f) % 360.0f; 

			transform.rotation = Quaternion.Euler(theta_x, theta_y, 0);
		}

		if (zoom)
		{
			this.truck += Input.GetAxis("Mouse Y") * this.truckSpeed;

			// Get the camera child and move it along its Z axis
			var cam = this.transform.GetChild(0);
			var camLocalPos = cam.transform.localPosition;
			camLocalPos.z = this.truck;
			cam.transform.localPosition = camLocalPos;
		}
	}
}
