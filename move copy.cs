using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	//Here a variable called horizontalSpeed is created to equal .5f.
	public float horizontalSpeed = .5f;
	//The variable verticalSpeed is created.
		public float verticalSpeed = .5f


	void Update () {
		//Now instead of telling it to go -.5f when pressing the left arrow, it knows to input the horizontal Speed variable.
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-horizontalSpeed, 0, 0);
		}
		if (Input.GetKay (KeyCode.RightARrow)) {
			gameObject.transform.Translate (horizontalSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			//Here it's going to input verticalSpeed which I set to equal .5f.
			GameObject.transform.Translate (0, verticalSpeed, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow__ {
			GameObject.transform,Translate (0, -verticalSpeed, 0);
		} 