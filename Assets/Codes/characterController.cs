using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	public float maxSpeed = 10f;
	bool facingRight = true;
	public float move;
	public Animator animator;

	private Rigidbody2D rb;

	public VectorValue pos;

	// Use this for initialization
	void Start () 
	{
		transform.position = pos.initialValue;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * maxSpeed, 0);
		animator.SetFloat("Speed", Mathf.Abs(move));

	}

	void Update()
	{

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	
	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}		
}