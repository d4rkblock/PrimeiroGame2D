using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	public float speed = 10;

	private Rigidbody2D rb2d;

	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal * speed, moveVertical * speed);
		rb2d.AddForce(movement);
	}

	void OnTriggerEnter2D(Collider2D collisor){
		if (collisor.gameObject.CompareTag ("Ouro")) {
			Destroy (collisor.gameObject);
		}
	}
}