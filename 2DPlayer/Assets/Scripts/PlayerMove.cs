using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float speed, dashForce, dashCoolDown, jumpForce;
	bool turnRight, coolDown;
	
	
	//public Vector3 rotateUp = new Vector3(0, 0, 30f);
	//void Update () {
		
				//	makeCharacterDash ();
//		if (Input.GetKeyDown(KeyCode.C)) {
//
//			Debug.Log ("Dash");
//			//	rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
//			rigidbody2D.velocity = new Vector2(dashForce, rigidbody2D.velocity.y); 
//			//	}
//		}
//				if (Input.GetKeyDown (KeyCode.X)) {
//			Debug.Log ("Jump");
//			rigidbody2D.AddForce(new Vector2 (0, jumpForce));
//
//				}
	//	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//Quaternion deltaRotation = Quaternion.Euler (rotateUp * Time.deltaTime);
		float horizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (horizontal * speed, rigidbody2D.velocity.y);
		rigidbody2D.velocity = movement;

		if (Input.GetKeyDown (KeyCode.X)) {
						//Debug.Log ("Jump");
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, jumpForce);
						//rigidbody2D.AddForce(new Vector2 (0, jumpForce));
				}

		if(Input.GetKeyDown (KeyCode.Z)) {
				//Debug.Log ("Dash");
				rigidbody2D.velocity = new Vector2(dashForce, rigidbody2D.velocity.y);
			
		}
	

//		if (Input.GetKeyDown (KeyCode.UpArrow));
//			rigidbody2D.velocity
		
		if (horizontal > 0) {
			turnRight = true;
		} else if (horizontal < 0) {
			turnRight = false;
		}
		
		//	if (Input.GetKeyDown(KeyCode.C)) {
		
		//	rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
		//		rigidbody2D.velocity = new Vector2(dashForce, rigidbody2D.velocity.y); 
		//	}
	}
	
//	void makeCharacterDash(){
//		
//		if (Input.GetKeyDown(KeyCode.X) && !coolDown){
//			
//			StartCoroutine ("coolDownRoutine", .7f);
//			
//			Debug.Log ("Dash");
//			
//			
//		}
//		
//	}
//	
//	IEnumerator coolDownRoutine (){
//		
//		//float horizontal = Input.GetAxisRaw (moveInput);
//		
//		if(!coolDown){
//			if (turnRight){
//
//				Debug.Log ("DASHED");
//				rigidbody2D.velocity = new Vector2(dashForce, rigidbody2D.velocity.y); 
//				coolDown = true;
//				
//				
//			} else{
//				Debug.Log ("DASHED2");
//				rigidbody2D.velocity = new Vector2(-dashForce, rigidbody2D.velocity.y); 
//				coolDown = true;
//				
//				
//			}
//			
//		}
//		yield return new WaitForSeconds (dashCoolDown*.20f);
//		
//		
//		coolDown = false;
//		
//	}
//	
//	
}