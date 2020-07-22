using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.IO;

public class Menu : MonoBehaviour {

	public GameObject start;
	public GameObject setting;

	public Slider volumeSlider;

	private bool isOpen=false;

	LoadScene playGame;

	void Start()
	{
		volumeSlider.value = PlayerPrefs.HasKey ("volumeLevel") ? PlayerPrefs.GetFloat ("volumeLevel") : 0.5f;
	}

    void Update()
    {
             
    }

    public void startGame()
    {
    	playGame = start.AddComponent<LoadScene>();
    	playGame.loadScene(1);
    }


	public void quit() {
			Application.Quit();
	}

	public void settingVolumePanel() {

		if (isOpen) {
			setting.SetActive (false);
			isOpen = false;
		} else {
			isOpen = true;
			setting.SetActive (true);
		}

	}


	public void setVolume(float volume)
	{
		//audioMixer.SetFloat ("volume",volume);
		AudioListener.volume = volume;
		PlayerPrefs.SetFloat ("volumeLevel",AudioListener.volume);
			
	}

}
