using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject[] Enemy;
	public bool done = false;
	public float cameraspeed;
	
	//public Transform relCamera;
	
	// Use this for initialization
	void Start () 
	{
		done = false;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		int i = Random.Range (0, 100);
		if(i == 50)
		{
			spawn ();
		}
		if (this.transform.position.x + this.renderer.bounds.size.x < Camera.main.gameObject.transform.position.x - 10) 
		{
			Destroy (this.gameObject);
		}
	}
	
	void spawn()
	{
		int i = Random.Range (0, Enemy.GetLength (0));
		Instantiate (Enemy [i], new Vector3 (this.transform.position.x + (this.renderer.bounds.size.x / 2) + (Enemy [i].renderer.bounds.size.x / 2), this.transform.position.y, 0), Quaternion.identity);
		done = true;
	}
}
