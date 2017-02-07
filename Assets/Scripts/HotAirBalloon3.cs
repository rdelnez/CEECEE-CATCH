using UnityEngine;
using System.Collections;

public class HotAirBalloon3 : MonoBehaviour {

	float curveX = 35.0f;
	float curveY = 30.8f;
	float alongTheX = 1.0f;
	float alongTheY = 0.5f;
	public Vector3 originalPos;
	float length; 
	
	float curveSpeed = 0.5f;
	
	
	// Use this for initialization
	void Start () {
		
		originalPos = new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);

		StartCoroutine (MoveBalloon ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		


		
		
		
	}

	IEnumerator MoveBalloon(){

		while(true){
			length += Time.deltaTime * curveSpeed;
			float x = originalPos.x + (curveX * Mathf.Sin (alongTheX * length));
			float y = originalPos.y - (Mathf.Abs (curveY * Mathf.Cos (alongTheY * length)));
			transform.localPosition = new Vector3 (x, y, 0);
			yield return new WaitForSeconds(0.02f);
		}

	}
}
