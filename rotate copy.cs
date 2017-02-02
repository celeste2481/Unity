using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	//Here I set the variables to be equal to different values.
	public float speed;
	public float rotX = 15;
	public float rotY = 30;
	public float rotZ = 45;

	// Use this for initialization
	void Start () {
		speed = Random.Range (.5f, 2.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		//Here I replace the numbers with the variables. When I type "rotX", it automatically equals to 15.
		transform.Rotate (new Vector3 (rotX, rotY, rotZ) * Time.deltaTime * Speed);
	
	}
}
