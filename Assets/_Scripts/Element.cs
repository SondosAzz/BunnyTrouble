using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
<<<<<<< Updated upstream
	public bool numberFive, numberSix, numberSeven;

	public Sprite[] numberTextures;
	void Start () {
		numberFive = Random.value < .30;
		numberSix = Random.value < .20;
		numberSeven = Random.value < .20;
	
		if (numberFive) {

			loadTexture (0);
		} else if (numberSix) {
			loadTexture (1);

		} else if (numberSeven) {

			loadTexture (2);
		} else
			loadTexture (3);
=======
	public bool numberS, numberE,numberW ,numberX ;

	public Sprite[] numberTextures;
	void Start () {
		numberS = Random.value < .15;
		numberE = Random.value < .15;
		numberW = Random.value < .15;
		numberX = Random.value < .15;
	
			if (numberS)
		{
			loadTexture (0);
		} 
		else if (numberE)
		{
			loadTexture (1);

		} 
		else if (numberW)
		{
			loadTexture (3);
		}
		else if (numberX) 
		{
			loadTexture (2);
		} 
		else 
		{
			loadTexture(4);
		}
>>>>>>> Stashed changes

	

	}
	public void loadTexture(int counter){

			GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];



		}








}
	


