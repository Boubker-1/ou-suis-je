using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.IO;

public class Scene3Control : MonoBehaviour {

	public GameObject suivant;
    public GameObject win;
	public GameObject audio;
	public GameObject musicOn;
	public GameObject musicOff;
	public GameObject exit;
    public GameObject af;
    public GameObject an;
    public GameObject asi;
    public GameObject au;
    public GameObject eu;
    public GameObject sa;
    public GameObject na;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;

    public static int count;

    /*int continent1, continent2, continent3;
    int continent4, continent5, continent6, continent7;*/

	private bool isPlay = true;

	LoadScene playGame;

	void Start()
	{
        count = 0;
        af.gameObject.SetActive(true);
        an.gameObject.SetActive(true);
        asi.gameObject.SetActive(true);
        au.gameObject.SetActive(true);
        au.gameObject.SetActive(true);
        eu.gameObject.SetActive(true);
        sa.gameObject.SetActive(true);
        na.gameObject.SetActive(true);

        win.gameObject.SetActive(false);
        suivant.gameObject.SetActive(false);
        exit.gameObject.SetActive(true);

        /*continent1 = PlayerPrefs.GetInt("Continent1");
        continent2 = PlayerPrefs.GetInt("Continent2");
        continent3 = PlayerPrefs.GetInt("Continent3");
        continent4 = PlayerPrefs.GetInt("Continent4");
        continent5 = PlayerPrefs.GetInt("Continent5");
        continent6 = PlayerPrefs.GetInt("Continent6");
        continent7 = PlayerPrefs.GetInt("Continent7");*/
	}

    void Update()
    {
        if(count > 7)
        {
            count = 7;
        }

        switch(count)
        {
            case 1:
                one.SetActive(true);
                break;
             case 2:
                two.SetActive(true);
                one.SetActive(false);
                break;
             case 3:
                three.SetActive(true);
                two.SetActive(false);
                break;
             case 4:
                four.SetActive(true);
                three.SetActive(false);
                break;
             case 5:
                five.SetActive(true);
                four.SetActive(false);
                break;
             case 6:
                six.SetActive(true);
                five.SetActive(false);
                break;
             case 7:
                seven.SetActive(true);
                six.SetActive(false);
                win.SetActive(true);
                suivant.SetActive(true);
                break;
        }

    }

    public void nextScene()
    {
        playGame = suivant.AddComponent<LoadScene>();
        playGame.loadScene(3);
    }

    public void disableAfrique()
    {
        af.gameObject.SetActive(false);
        count++;
    }

    public void disableAntartique()
    {
        an.gameObject.SetActive(false);
        count++;
    }

    public void disableAsie()
    {
        asi.gameObject.SetActive(false);
        count++;
    }

    public void disableEurope()
    {
        eu.gameObject.SetActive(false);
        count++;
    }

    public void disableAmeriqueSud()
    {
        sa.gameObject.SetActive(false);
        count++;
    }

    public void disableAmeriqueNord()
    {
        na.gameObject.SetActive(false);
        count++;
    }

    public void disableAustralie()
    {
        au.gameObject.SetActive(false);
        count++;
    }

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
