using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool number ;
	public Sprite[] numberTextures;
	void Start () {
		//number = Random.value < .20;

			//loadTexture (2);
			//loadTexture (0);
			loadTexture (3);

	}
	public void loadTexture(int counter){

			GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];



		}








}
	


