using UnityEngine;
using System.Collections;

public class destroyThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.position.x < Camera.main.gameObject.transform.position.x - 36) 
		{
			Destroy (this.gameObject);
		}
	}
}
