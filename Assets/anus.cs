﻿using UnityEngine;
using System.Collections;

public class anus : MonoBehaviour 
{

	public GameObject Error;
	public GameObject Load;
	public Vungle_me vungle;


	// Use this for initialization
	public void ShowError () 
	{
		Error.SetActive (true);
	}
	
	// Update is called once per frame
	public void ShowLoad () 
	{
		Load.SetActive (true);
		StartCoroutine (rectum ());

	}

	IEnumerator rectum()
	{
		yield return new WaitForSeconds (5);
		vungle.Show ();
		yield return new WaitForSeconds (2);
		Error.SetActive (true);
	}

	public void ShowInstructions () 
	{

	}


	public void Back () 
	{
	}
}
