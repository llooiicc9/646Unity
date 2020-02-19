using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class clickDessus : MonoBehaviour
{
	
	public AudioSource sonBon;
	public AudioSource sonPasBon;
	int juste= 0;
	
    // Start is called before the first frame update
    void Start()
    {
		AudioSource[] audios = GetComponents<AudioSource>();
        sonBon = audios[0];
        sonPasBon = audios[1];
    }
	

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			
			//Destroy(gameObject);
			Debug.Log("click");
			
			if(juste==0)
			{
				sonPasBon.Play();
			}
			else
			{
				sonBon.Play();
				//Déplacer camera
				//transform.position += new Vector3(12,0);
				Camera.main.transform.Translate(13,0,-10);

                //Applique un délai pour changer de scène
                DOVirtual.DelayedCall(5, GoToNextScene);
			}			

		}		
			
    }

    //méthode pour changer de scène
	 void GoToNextScene()
    {
        SceneManager.LoadScene("Reward1");
    }


	void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        //Debug.Log("Mouse is over GameObject.");
		juste=1;
		//Debug.Log("juste = "+juste+"Mouse is no longer on GameObject.");
		
    }
	
	void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
		juste=0;
		//Debug.Log("juste = "+juste+"Mouse is no longer on GameObject.");
    }
	
}
