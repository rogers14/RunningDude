using UnityEngine;
using System.Collections;

// From the internet, but I've modified it to work with my Spring script
public class MoveCharacter : MonoBehaviour 
{
	public float speed = 6.0F; 
	private float jumpSpeed = 8.0F; 
	public float gravity = 20.0F; 
	public float yPos = -8.0f;
	public float jumpPower = 100.0f;
	private Vector2 moveDirection = Vector2.zero;
	public bool isSpringed = false;
	public CharacterController player;
	public Quaternion startQ;
	private Animation animation;
	public AnimationClip run;
	public AnimationClip jump;
	public AnimationClip fall;


	void Start()
	{
		player = GetComponent<CharacterController>();
		startQ = player.transform.rotation;
		animation = GetComponent<Animation> ();
		animation [run.name].speed = 2f;
	}
	void Update()
	{
		float yPos = player.transform.position.y;
		
		if (player.isGrounded)
		{
			animation.Play(run.name);
			// if player is on the ground, we normally don't want to move him vertically
			moveDirection.y = 0;
			
			// but if the jump button is pressed, then we do want him moving vertically
			if (isSpringed)
			{
				moveDirection.y = jumpPower;
				animation.Play(jump.name);
			}
			// Reset so we only jump once
			isSpringed = false;
		}
		else
		{
			// if player is not on the ground, then apply gravity to him
			moveDirection.y -= gravity * Time.deltaTime;

			//for some reason isGrounded randomly returns false even if the character is grounded
			//so I'm getting a weird thing where it tries to play both animations
			//animation.Play(fall.name);
		}
		
		// constantly move horizontally
		moveDirection.x = speed;
		
		// finally, we actually apply the movement to the player
		player.Move(moveDirection * Time.deltaTime);
	}
	
}
