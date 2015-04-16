using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool numberS, numberE ;

	public Sprite[] numberTextures;
	void Start () {
		numberS = Random.value < .30;
		numberE = Random.value < .20;
	
			if (numberS) 
		{

			loadTexture (0);
		}
			else if ( numberE)
		{
			loadTexture(1);

		}
		else
		{

			loadTexture(3);
		}

	

	}
	public void loadTexture(int counter){

			GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];



		}








}
	


