using UnityEngine;
using System.Collections;

public class frameSpawner : MonoBehaviour 
{
	public GameObject Frame;
	public bool done = false;
	public float cameraspeed;
	public bool done2 = true;
	// Use this for initialization
	void Start () 
	{
		done = false;	
		Instantiate (Frame, new Vector3 (this.transform.position.x - (36), this.transform.position.y, 3), Quaternion.identity);
		Instantiate (Frame, new Vector3 (this.transform.position.x - (24), this.transform.position.y, 3), Quaternion.identity);
		Instantiate (Frame, new Vector3 (this.transform.position.x - (12), this.transform.position.y, 3), Quaternion.identity);
		Instantiate (Frame, new Vector3 (this.transform.position.x, this.transform.position.y, 3), Quaternion.identity);
		Instantiate (Frame, new Vector3 (this.transform.position.x + (12), this.transform.position.y, 3), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (1.0f, 0, 0.0f) * cameraspeed * Time.deltaTime;
		if (done==false) {
			spawn ();
		}
		if (done2==true) {
						if ((int)this.transform.position.x % 12 <1) {
								done = false;
								done2 = false;
						}
		} else if ((int)this.transform.position.x % 12 >10){
			done2 = true;
				}
	}

	void spawn()
	{
				Instantiate (Frame, new Vector3 (this.transform.position.x + (24), this.transform.position.y, 3), Quaternion.identity);
				done = true;
		}
}
