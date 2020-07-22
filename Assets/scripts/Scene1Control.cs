using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.IO;

public class Scene1Control : MonoBehaviour {

	public GameObject start;
	public GameObject presentation;
	public GameObject audio;
	public GameObject musicOn;
	public GameObject musicOff;
	public GameObject exit;

	private bool isPlay = true;

	LoadScene playGame;

	void Start()
	{
		presentation.SetActive(true);
		exit.SetActive(false);
		start.SetActive(false);
		musicOn.SetActive(false);

	}

    void Update()
    {
             
    }

    public void startGame()
    {
    	playGame = start.AddComponent<LoadScene>();
    	playGame.loadScene(2);
    }

    public void closePresentation()
    {
    	presentation.SetActive(false);
    	exit.SetActive(true);
    	start.SetActive(true);
    	musicOn.SetActive(true);
    }

    public void exitScene()
    {
    	playGame = start.AddComponent<LoadScene>();
    	playGame.loadScene(0);
    }

    public void songPlaying()
    {
        if (isPlay)
        {
            isPlay = false;
            audio.SetActive(false);
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
        else
        {
            isPlay = true;
            audio.SetActive(true);
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }

    }
}
