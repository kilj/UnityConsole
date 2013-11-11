using UnityEngine;
using System.Collections;
using System;

public class UnityConsole {
	
	public enum ConsoleTag
	{
		MENU,
		GAME
	}

	public static void Log ( ConsoleTag tag, string msg )
	{
		Debug.Log ( msg );
		UnityConsoleEditor.Instance.Log( tag.ToString(), msg );
	}
	
	public static void LogWarning ( ConsoleTag tag, string msg )
	{
		Debug.LogWarning ( msg );
	}
	
	public static void LogError ( ConsoleTag tag, string msg )
	{
		Debug.LogError ( msg );
	}
	
	
}
