using UnityEngine;
using System.Collections;

public class createBackground : MonoBehaviour 
{
	public GameObject[] Ground;
	public bool done = false;

	// Use this for initialization
	void Start () 
	{
		done = false;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (done==false) {
						spawn ();
				}
	}

	void spawn()
	{
				int j = Random.Range (6, 12);
				int t = 0;
				float l;
				for (int i=0; i<=j; i++) {
					//((Screen.width/j)*i)
					int k = Random.Range (0, Ground.GetLength (0));
					while(t==k)
					{
				 		k = Random.Range (0, Ground.GetLength (0));
					}
					if(k>4)
					{
						l=0.8f;
					}
					else{
							l=0;
						}
					Instantiate (Ground [k], new Vector3 (this.transform.position.x + ((12 / j) * i)+24, this.transform.position.y-l, Ground[k].transform.position.z), Quaternion.identity);
					t = k;

				}
				done = true;
		}
}
