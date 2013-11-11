using UnityEngine;
using System.Collections;

public class UnityConsoleExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityConsole.Log(UnityConsole.ConsoleTag.GAME, "test");
		StartCoroutine(Wait());
	}
	
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(5);
		UnityConsole.Log(UnityConsole.ConsoleTag.GAME, "test2");
	}
}
