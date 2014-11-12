using UnityEngine;
using System.Collections;

// From the internet, but I've modified it to work with my Spring script
public class MoveCharacter : MonoBehaviour 
{
	private float speed = 6.0F; 
	private float jumpSpeed = 8.0F; 
	public float gravity = 20.0F; 
	public float yPos = -8.0f;
	public float jumpPower = 100.0f;
	private Vector2 moveDirection = Vector2.zero;
	public bool isSpringed = false;
	
	void Update()
	{
		CharacterController player = GetComponent<CharacterController>();
		float yPos = player.transform.position.y;
		
		if (player.isGrounded)
		{
			// if player is on the ground, we normally don't want to move him vertically
			moveDirection.y = 0;
			
			// but if the jump button is pressed, then we do want him moving vertically
			if (isSpringed)
			{
				moveDirection.y = jumpPower;
			}
			// Reset so we only jump once
			isSpringed = false;
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
