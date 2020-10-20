using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// instructions for students: clone this project, open the VlambeerLabScene, and then start working on this script
// based on: Vlambeer's level generation system for Nuclear Throne https://indienova.com/u/root/blogread/1766

public class FloorMaker : MonoBehaviour {

// STEP 1: ===================================================================================
// translate the basic pseudocode here into C#

//	DECLARE CLASS MEMBER VARIABLES:
//	Declare a private integer called myCounter that starts at 0; 		// count how many floor tiles this FloorMaker has instantiated
//	Declare a public Transform called floorPrefab, assign the prefab in inspector;
//	Declare a public Transform called floorMakerPrefab, assign the prefab in inspector; 

	void Update () {
//		If counter is less than 50, then:
//			Generate a random number from 0.0f to 1.0f;
//			If random number is less than 0.25f, then rotate myself 90 degrees on Z axis;
//				... Else if number is 0.25f-0.5f, then rotate myself -90 degrees on Z axis;
//				... Else if number is 0.99f-1.0f, then instantiate a floorMakerPrefab clone at my current position;
//			// end elseIf

//			Instantiate a floorPrefab clone at current position;
//			Move 1 unit "upwards" based on this object's local rotation (e.g. with rotation 0,0,0 "upwards" is (0,1,0)... but with rotation 0,0,180 then "upwards" is (0,-1, 0)... )
//			Increment counter;
//		Else:
//			Destroy my game object; 		// self destruct if I've made enough tiles already
	}

} // don't delete, end of FloorMaker class


// STEP 2: =====================================================================================
// implement, test, and stabilize the system

//  ADD A RESTART BUTTON TO MAKE IT EASIER TO TEST:
//  - let us press [R] to reload the scene and see a new level generation
//  - example: https://github.com/radiatoryang/fall2020_gamedev/blob/master/week05_raycasting/Assets/Scripts/RestartScene.cs

//	IMPLEMENT AND TEST:
//	- save your scene!!! the code could potentially be infinite / exponential, and crash Unity
//	- don't forget to configure all prefabs in the inspector
//  - test and debug!

//	STABILIZE: 
//	- code it so that all the FloorMakers can only spawn a grand total of 500 tiles in the entire world; how would you do that?
//  hints:
//  - declare a "public static int" counter variable called "globalTileCount"
//  - each time you instantiate a floor tile, increment globalTileCount
//  - if there are already too many tiles, then self-destruct without spawning new floor tiles... like "if(globalTileCount > 500)" ... "Destroy(gameObject);"
//  note: a static var will persist beyond scene changes! you have to reset the variable manually when you restart the scene!


// STEP 3: ======================================================================================
// tune your values...

// a. how many floor tiles should a FloorMaker instantiate before self-destructing? you decide
// b. how would you tune the probabilities to generate lots of long hallways?
// c. tweak probabilities... what if you increase the % chance to make another FloorMaker? what if you decrease it?


// STEP 4:  =====================================================================================
// art pass, usability pass

// - CHANGE THE DEFAULT UNITY COLORS, PLEASE, I'M BEGGING YOU
// - optional: add some sprites?
// - with Text UI, name your engine tech demo ("AwesomeGen", "RobertGen", etc.) and add a Text UI that reminds us we can press [R] to restart


// OPTIONAL EXTRA TASKS TO DO, IF YOU WANT: ===================================================

// DYNAMIC CAMERA:
// position the camera to center itself based on your generated world...
// 1. keep a list of all your spawned tiles
// 2. then calculate the average position of all of them (use a for() loop to go through the whole list) 
// 3. then move your camera to that averaged center and make sure fieldOfView is wide enough?

// BETTER UI:
// learn how to use UI Sliders (https://unity3d.com/learn/tutorials/topics/user-interface-ui/ui-slider) 
// let us tweak various parameters and settings of our tech demo
// let us click a UI Button to reload the scene, so we don't even need the keyboard anymore!

// WALL GENERATION
// after all floor tiles are placed, add a "wall pass"
// 1. raycast downwards around each floor tile (that'd be 8 raycasts per floor tile, in a square "ring" around each tile)
// 2. if the raycast "fails" that means there's empty void there, so then instantiate a Wall tile prefab
// 3. ... repeat until walls surround your entire floorplan