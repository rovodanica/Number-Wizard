﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
	StartGame ();
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		print("==========================");
		print ("Welcome to NumberWizard!");
		print ("Pick a number in your head!");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		print ("Is your number " + guess +"?");
		print ("Up = higher, down = lower, return = equals");
		max = max+1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
		min = guess;
		NextGuess();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)){
		max = guess;
		NextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)) {
		print ("I won!");
		StartGame ();
		}
}
	
	void NextGuess(){
		guess = (min+max) / 2;
		print("Is it higher or lower than " + guess + "?");
	}

}
