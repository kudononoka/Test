using UnityEngine;
using System.Collections;

public class RobotTestScriptFree : MonoBehaviour {

	private Animator anim;
	private float jumpTimer = 0;
	private float speed = 2.0f;
	private float speedSpeed = 6.0f;
	public float jumpSpeed;




	void Start () {
	
		anim = this.gameObject.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		//Controls the Input for running animations
		// 1: walk
		//2: Run
		//3: Jump

		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		float xSpeed = 0.0f;
		float ySpeed = 0.0f;
		if (horizontalInput != 0f || verticalInput != 0f)
		{
			transform.rotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, verticalInput));
		}

			if (Input.GetKey("2"))
		{
			anim.SetInteger("Speed", 2);
			transform.position += transform.forward * speedSpeed *Time.deltaTime;
		}
		else if (Input.GetKey("1"))
		{
			anim.SetInteger("Speed", 1);
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		else
		{
			anim.SetInteger("Speed", 0);
		}

		if (Input.GetKey ("3")) 
		{
			jumpTimer = 1;
			anim.SetBool ("Jumping", true);
			ySpeed = jumpSpeed;
        }

		if (jumpTimer > 0.5)
		{
			jumpTimer -= Time.deltaTime;
		}
		else if (anim.GetBool("Jumping") == true)
		{
			anim.SetBool("Jumping", false);
		}

	}
}
