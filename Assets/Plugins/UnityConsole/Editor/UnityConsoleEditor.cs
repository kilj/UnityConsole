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
    private static List<string> _timestamps = new List<string>();

    //private static Color _timeColor = Color.black;
    //private static Color _tagColor = Color.white;
    //private static Color _msgColor = Color.white;

    private static GUIStyle _tagStyle = new GUIStyle();
	
	[@MenuItem ("Window/UnityConsole")]
	static void Init ()   
	{
		EditorWindow.GetWindow(typeof(UnityConsoleEditor));

        _tagStyle.alignment = TextAnchor.MiddleCenter;
	}
		
	void OnGUI ()
	{
		EditorGUILayout.BeginVertical();
		
		if(GUILayout.Button("Clear"))
		{
			_tags.Clear();
			_msgs.Clear();
            _timestamps.Clear();
		}
		
		EditorGUILayout.BeginScrollView(new Vector2(0,0), GUILayout.ExpandWidth(true),GUILayout.ExpandHeight(true));
		
		for ( int i = 0; i < _tags.Count; i++ )
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.SelectableLabel( _timestamps[i] + " | " + _tags[i] + " : " + _msgs[i], GUILayout.Height(16));
            EditorGUILayout.EndHorizontal();
        }
			
		
		EditorGUILayout.EndScrollView();
		
		EditorGUILayout.EndVertical();
	}
	
	public void OnInspectorUpdate()
	{
   	 	Repaint();
	}
	
	public void Log ( string tag, string msg )
	{
		_tags.Add(tag);
		_msgs.Add(msg);
        _timestamps.Add(System.DateTime.Now.ToString("HH:mm:ss"));
	}
	
}
