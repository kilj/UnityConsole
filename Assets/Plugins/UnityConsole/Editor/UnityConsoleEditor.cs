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
	static void Init ()   
	{
		EditorWindow.GetWindow(typeof(UnityConsoleEditor));
	}
		
	void OnGUI ()
	{
		EditorGUILayout.BeginVertical();
		
		if(GUILayout.Button("Clear"))
		{
			_tags.Clear();
			_msgs.Clear();
		}
		
		EditorGUILayout.BeginScrollView(new Vector2(0,0), GUILayout.ExpandWidth(true),GUILayout.ExpandHeight(true));
		
		foreach(string msg in _msgs)
			EditorGUILayout.LabelField("tag", msg); 
		
		EditorGUILayout.EndScrollView();
		
		EditorGUILayout.EndVertical();
	}
	
	public void OnInspectorUpdate()
	{
   	 	Repaint();
	}
	
	public void Log ( string tag, string msg )
	{
		Debug.Log("sdf");
		_tags.Add(tag);
		_msgs.Add(msg);
	}
	
}
