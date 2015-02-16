using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	private bool pound;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" ){ // check if it's the player, if you want

			if(other.gameObject.GetComponent<movement>().pound)
			{
				Destroy(this.gameObject);
				other.GetComponent<movement>().jump();
				print ("this works");
				other.GetComponent<movement>().score += 5 * other.GetComponent<movement>().mult;
				
				other.GetComponent<movement>().mult += 1;
				other.GetComponent<movement>().counter = 0;
				
			}
			else if(other.gameObject.GetComponent<movement>().dashing)
			{
				Destroy(this.gameObject);
				other.GetComponent<movement>().score += 5 * other.GetComponent<movement>().mult;
				
				other.GetComponent<movement>().mult += 1;
				other.GetComponent<movement>().counter = 0;
				print("dash");
			}
			else if(other.gameObject.rigidbody2D.velocity.y < 0.0f && !other.gameObject.GetComponent<movement>().pound)
			{
				Destroy(this.gameObject);
				print ("this works");
			}
			else
			{
				Destroy(this.gameObject);
				if(other.gameObject.GetComponent<movement>().runspeed > 5){
				other.gameObject.GetComponent<movement>().runspeed = 4f;
				other.gameObject.GetComponent<movement>().runspeed /= 30f;
				}
				else{
					other.gameObject.GetComponent<movement>().runspeed /= 30f;
				}
				print ("option2");
			}
		}
	}
}
