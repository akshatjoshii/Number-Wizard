using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		print ("========================");
		max = 1000;
		min = 1;
		guess = 500;
	
		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but dont tell me");
		
		
		
		print ("The highest number you can pick is : "+ max);
		print ("The lowest number you can pick is : " + min);
		
		print ("Is your number higher or lower than "+guess);
		print ("Up arrow for higher, down arrow for lower and return for equal");
		max = max+1;
	}
	
	void NextGuess () {
		guess = (max+min)/2;
		
		print ("higher or lower than " + guess);
		print ("Up arrow for higher, down arrow for lower and return for equal");
		
	
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			// print("up key was pressed");
			min = guess;
			NextGuess();
			
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print("down key was pressed");
			max = guess;
			
			NextGuess();
			
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print("I won");
			StartGame();
		}
			
	}
} 
