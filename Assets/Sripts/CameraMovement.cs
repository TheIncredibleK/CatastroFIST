using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private movement move;

	public Transform player;
	public float cameraspeed;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update () 
	{
		if (player.position.x > this.transform.position.x - 4.9f) {
			this.transform.position = new Vector3 (player.position.x + 5, 0, -10);// * player.gameObject.GetComponent<movement> ().runspeed * Time.deltaTime;
		} else {
				this.transform.position += new Vector3 (1.0f, 0.0f, 0.0f) * cameraspeed * Time.deltaTime;
		}
	}

}
