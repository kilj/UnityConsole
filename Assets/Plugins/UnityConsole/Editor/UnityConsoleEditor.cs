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

    private static List<string> _logMsg = new List<string>();

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
            _logMsg.Clear();
		}
		
		EditorGUILayout.BeginScrollView(new Vector2(0,0), GUILayout.ExpandWidth(true),GUILayout.ExpandHeight(true));
		
		for ( int i = 0; i < _logMsg.Count; i++ )
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.SelectableLabel( _logMsg[i], GUILayout.Height(16));
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
        _logMsg.Add(System.DateTime.Now.ToString("HH:mm:ss") + " | " + tag + " : " + msg);
	}
	
}
