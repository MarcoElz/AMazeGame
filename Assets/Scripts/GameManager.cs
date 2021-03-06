﻿using UnityEngine;

public class GameManager : MonoBehaviour {

	public Maze mazePrefab;
	private Maze mazeInstance;

	void Start () 
	{
		BeginGame ();
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			RestartGame();
		}
	}

	private void BeginGame()
	{
		mazeInstance = Instantiate(mazePrefab) as Maze;
		mazeInstance.Generate();

	}

	private void RestartGame()
	{
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}



}
