using UnityEngine;
using System.Collections;
using System.Threading;

public class MainScript : MonoBehaviour
{
	public string _URL = null;

	public void OnGUI()
	{
		if (GUI.Button(new Rect(15, 15, 300, 100), "WWWGet"))
		{
			WWWGet();
		}
	}
	
	public void OnApplicationPause(bool isSuspended)
	{
		if(isSuspended)
		{
			WWWGet();
		}
	}

	void WWWGet()
	{
		WWW www = new WWW(_URL);
		while(!www.isDone)
		{
			Thread.Sleep(100);
		}
		Debug.Log(www.text);
	}
}
