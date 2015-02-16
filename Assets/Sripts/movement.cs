using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float runspeed;
	public Transform player;
	public int jumpforce;
	public float downForce;
	public float dashForce;
	public bool grounded;
	public bool pound;
	public bool dashing;
	public int score = 0;
	public int mult = 1;
	public int counter = 0;
	// Use this for initialization
	void Start () 
	{
		pound = false;
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (counter > 180) {
			mult = 1;
		}
		if(rigidbody2D.velocity.x <= runspeed)
		{
			dashing = false;
		}
		if (rigidbody2D.velocity.y == 0) {
			pound = false;
		}
		if (Input.GetKeyDown (KeyCode.Space) && rigidbody2D.velocity.y == 0) {

			jump ();

				} else if (Input.GetKeyDown (KeyCode.Space) && pound==false) {
					Gpound();
				}
		if (Input.GetKeyDown (KeyCode.RightArrow) && this.dashing == false) {
			dashing = true;
			player.rigidbody2D.AddForce (new Vector2 (dashForce, 0));
		}
		transform.position += new Vector3 (1.0f, 0.0f, 0.0f) * runspeed * Time.deltaTime;
		if (runspeed < 5 && runspeed > 0) {
			runspeed *= 1.1f;
		} else {
			runspeed *= 1.0001f;
		}
		if (this.transform.position.x + this.renderer.bounds.size.x < Camera.main.gameObject.transform.position.x - 10) 
		{
			Destroy (this.gameObject);
			if(gameObject.tag == "Player")
			{
				Debug.Break();
				return;
			}
		}

		counter++;

	}
	public void jump()
	{
				rigidbody2D.velocity = new Vector2 (0, 0);
				rigidbody2D.AddForce (new Vector2 (0, jumpforce));
				pound = false;
		}
	void Gpound()
	{
				rigidbody2D.AddForce (new Vector2 (0, -jumpforce * downForce));
				pound = true;
		}

	
	void OnGUI(){
		
		GUI.Box (new Rect (Screen.width /2, 4f, 20f, 20f), score.ToString ());
		GUI.Box (new Rect (Screen.width /2 + 20, 4f, 20f, 20f), mult.ToString ());
	}
}
