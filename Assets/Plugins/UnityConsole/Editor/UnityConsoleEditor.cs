using UnityEditor;
using UnityEngine;

public class UnityConsoleEditor : EditorWindow {
	
	private static string _testStr = "";
	
	private bool _isSubscribed;
	
	[@MenuItem ("Window/UnityConsole")]
	static void ShowWindow ()
	{
		EditorWindow.GetWindow(typeof(UnityConsoleEditor));
	}
		
	void OnGUI ()
	{
		EditorGUILayout.TextField("Test", _testStr); 
	}
	
	public static void Log ( string msg )
	{
		Debug.Log("We are in editor");
		_testStr = msg;
	}
	
}
