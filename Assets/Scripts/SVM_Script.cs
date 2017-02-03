using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class SVM_Script : MonoBehaviour {

	public static string gameDifficulty;
	public static int targetScore = 50;
	public static bool advanceIsLocked = true;
	public static bool expertIsLocked = true;
	
	public static bool gameSetup;
		// Make global
	public static SVM_Script Instance {
			get;
			set;
	}
		


	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
		if (Instance == null) {
			Instance=this;
		}
		else if(Instance != this){
			Destroy (gameObject);
		}


	}
		
	void Start() {

	}
		


}
