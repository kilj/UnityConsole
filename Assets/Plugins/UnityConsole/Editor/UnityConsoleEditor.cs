using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class UnityConsoleEditor : EditorWindow {
	
	private static UnityConsoleEditor _instance = (UnityConsoleEditor)ScriptableObject.CreateInstance(typeof(UnityConsoleEditor));
	private UnityConsoleEditor() {}
	public static UnityConsoleEditor Instance 
	{
		get { return _instance; }
	}
	
	private static List<string> _tags = new List<string>();
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
	
	public void OnInspectorUpdate()
	{
   	 	Repaint();
	}
	
	public void Log ( string tag, string msg )
	{
		_tags.Add(tag);
		_msgs.Add(msg);
	}
	
}
