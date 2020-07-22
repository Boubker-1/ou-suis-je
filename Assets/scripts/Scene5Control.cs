using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Control : MonoBehaviour {

	[SerializeField]
	private GameObject win;

	//public GameObject next;
	public GameObject exit;
	public GameObject finish;

	public GameObject MusicOn;
    public GameObject MusicOff;
	public GameObject audio;
	public GameObject successAudio, successAudio1, successAudio2, successAudio3, successAudio4;
	public GameObject successAudio5, successAudio6, successAudio7, successAudio8;

	private bool isPlay = true;

	LoadScene playGame;


	//methode pour initialiser
	void Start()
	{
		Afrique0.locked = false;
		Afrique1.locked = false;
		Afrique2.locked = false;
		Afrique3.locked = false;
		Afrique4.locked = false;
		Afrique5.locked = false;
		Afrique6.locked = false;
		Afrique7.locked = false;
		Afrique8.locked = false;

		win.SetActive(false);
		//next.SetActive(false);
		exit.SetActive(false);
		finish.SetActive(false);

		successAudio.SetActive(false);
		successAudio1.SetActive(false);
		successAudio2.SetActive(false);
		successAudio3.SetActive(false);
		successAudio4.SetActive(false);
		successAudio5.SetActive(false);
		successAudio6.SetActive(false);
		successAudio7.SetActive(false);
		successAudio8.SetActive(false);
	}

	// && 

	void Update()
	{
		//successAudio.SetActive(false);
		if(Afrique0.locked )
		{
			successAudio.SetActive(true);
		}

		if(Afrique1.locked)
		{
			successAudio1.SetActive(true);
		}

		if(Afrique2.locked)
		{
			successAudio2.SetActive(true);
		}

		if(Afrique3.locked )
		{
			successAudio3.SetActive(true);
		}

		if(Afrique4.locked)
		{
			successAudio4.SetActive(true);
		}

		if(Afrique5.locked)
		{
			successAudio5.SetActive(true);
		}

		if(Afrique6.locked )
		{
			successAudio6.SetActive(true);
		}

		if(Afrique7.locked)
		{
			successAudio7.SetActive(true);
		}

		if(Afrique8.locked)
		{
			successAudio8.SetActive(true);
		}

		/*if(Afrique0.locked || Afrique1.locked || Afrique2.locked || Afrique3.locked || Afrique4.locked || Afrique5.locked || Afrique6.locked || Afrique7.locked || Afrique8.locked)
		{
			successAudio.SetActive(true);
		}*/

		if(Afrique0.locked && Afrique1.locked && Afrique2.locked && Afrique3.locked && Afrique4.locked && Afrique5.locked && Afrique6.locked && Afrique7.locked && Afrique8.locked)
		{
			//successAudio.SetActive(false);
			//next.SetActive(true);
			win.SetActive(true);
			exit.SetActive(true);
			StartCoroutine(wait());
		}
		//successAudio.SetActive(false);
	}

	/*public void nextScene()
	{
		playGame = next.AddComponent<LoadScene>();
		playGame.loadScene(6);
	}*/

	public void exitScene()
	{
		playGame = exit.AddComponent<LoadScene>();
    	playGame.loadScene(0);
	}


    public void songPlaying()
    {
        if (isPlay)
        {
            isPlay = false;
            MusicOn.SetActive(false);
            MusicOff.SetActive(true);
            audio.SetActive(false);
        }
        else
        {
            isPlay = true;
            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
            audio.SetActive(true);
        }

    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        finish.SetActive(true);
    }
}