using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour 
{
	public float speed = 6.0F; 
	public float jumpSpeed = 8.0F; 
	public float gravity = 20.0F; 
	private Vector2 moveDirection = Vector2.zero;
	
	void Start(){
	}
	
	void Update(){
		CharacterController player = GetComponent<CharacterController>();
		
		if (player.isGrounded)
		{
			// if player is on the ground, we normally don't want to move him vertically
			moveDirection.y = 0;
			
			// but if the jump button is pressed, then we do want him moving vertically
			if (Input.GetButton("Jump"))
			{
				moveDirection.y = jumpSpeed;
			}
		}
		else
		{
			// if player is not on the ground, then apply gravity to him
			moveDirection.y -= gravity * Time.deltaTime;
		}
		
		// constantly move horizontally
		moveDirection.x = speed;
		
		// finally, we actually apply the movement to the player
		player.Move(moveDirection * Time.deltaTime);
	}
}
