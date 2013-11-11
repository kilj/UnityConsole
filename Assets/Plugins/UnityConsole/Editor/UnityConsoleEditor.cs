using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class UnityConsoleEditor : EditorWindow {
	
	private UnityConsoleEditor _instance = new UnityConsoleEditor();
	private UnityConsoleEditor() {}
	public UnityConsoleEditor Instance 
	{
		get { return _instance; }
	}
	
	private static List<string> _msgs = new List<string>();
	
	[@MenuItem ("Window/UnityConsole")]
	static void ShowWindow ()
	{
		EditorWindow.GetWindow(typeof(UnityConsoleEditor));
	}
		
	void OnGUI ()
	{
		foreach(string msg in _msgs)
			EditorGUILayout.LabelField("tag", msg); 
	}
	
	public void Log ( string tag, string msg )
	{
		Debug.Log("We are in editor");
		_msgs.Add(msg);
	}
	
}
