using UnityEngine;
using System.Collections;

public class UnityConsoleExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityConsole.Log(UnityConsole.ConsoleTag.GAME, "test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
