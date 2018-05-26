using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for local takeaway.");
        Terminal.WriteLine("Press 2 for local hospital.");
        Terminal.WriteLine("Press 3 for psn servers.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter you selection.");
        Terminal.WriteLine("");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
