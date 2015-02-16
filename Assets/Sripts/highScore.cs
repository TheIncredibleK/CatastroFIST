using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class highScore : MonoBehaviour {
	
	public string path = @"C:\save\score.txt";
	public int score = GameObject.Find ("ThePlayer").GetComponent<movement>().score;

	
	// Use this for initialization
	void Start () {
		if(!Directory.Exists (@"C:\save\"))
		   {
			Directory.CreateDirectory(@"C:\save\");
		}

		
	}
	
	// Update is called once per frame
	void Update() {

		score = GameObject.Find ("ThePlayer").GetComponent<movement>().score;
		
		if (!File.Exists (path)) {
						string Score = Convert.ToString (score);
						File.WriteAllText (path, Score);
				} 

		/*if (File.Exists (path))
		{
						string oldScore;
						int old = 0;
						int scoreToWrite = 0;

			System.IO.StreamReader file = 
				new System.IO.StreamReader(path);
			while((oldScore = file.ReadLine()) != null)
			{
				old = Convert.ToInt32(oldScore, 10);

				if(score > old)
				{
					scoreToWrite = score;
				}

				string Score = Convert.ToString(scoreToWrite);

				File.WriteAllText(path, Score);
			}

						
			//IAOHFKJAHDFJLADFk
				}*/
		
	}
}
