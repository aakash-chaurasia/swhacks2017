﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Score").GetComponent<Text> ().text = "GAME OVER! Your Score is " + GameObject.Find ("Managers").GetComponent<ScoreManager> ().score.ToString();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
