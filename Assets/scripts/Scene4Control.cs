using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.IO;

public class Scene4Control : MonoBehaviour {

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
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;

    public GameObject falseMaroc, falseIsland, falseKenyia, falseTunis;


    /*int continent1, continent2, continent3;
    int continent4, continent5, continent6, continent7;*/

    private static int count;

	private bool isPlay = true;

	LoadScene playGame;

	void Start()
	{
		count = 0;
		
        af.gameObject.SetActive(false);
        an.gameObject.SetActive(false);
        asi.gameObject.SetActive(false);
        au.gameObject.SetActive(false);
        eu.gameObject.SetActive(false);
        sa.gameObject.SetActive(false);
        na.gameObject.SetActive(false);

        one.gameObject.SetActive(true);
        two.gameObject.SetActive(true);
        three.gameObject.SetActive(true);
        four.gameObject.SetActive(true);
        five.gameObject.SetActive(true);
        six.gameObject.SetActive(true);
        seven.gameObject.SetActive(true);
        eight.gameObject.SetActive(true);
        nine.gameObject.SetActive(true);
        ten.gameObject.SetActive(true);
        eleven.gameObject.SetActive(true);

        falseMaroc.gameObject.SetActive(false);
        falseIsland.gameObject.SetActive(false);
        falseKenyia.gameObject.SetActive(false);
        falseTunis.gameObject.SetActive(false);


        win.gameObject.SetActive(false);
        suivant.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
	}

    void Update()
    {
        if(count > 7)
        {
            count = 7;
        }

        if(count == 7)
        {
            win.gameObject.SetActive(true);
            suivant.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);
        }

    }

    public void nextScene()
    {
        playGame = suivant.AddComponent<LoadScene>();
        playGame.loadScene(4);
    }

    public void disableOne()
    {
        eu.gameObject.SetActive(true);
        one.gameObject.SetActive(false);
        count++;
    }

    public void disableTwo()
    {
        two.gameObject.SetActive(false);
        au.gameObject.SetActive(true);
        count++;
    }

    public void disableThree()
    {
        three.gameObject.SetActive(false);
        an.gameObject.SetActive(true);
        count++;
    }

    public void disableFour()
    {
        four.gameObject.SetActive(false);
        asi.gameObject.SetActive(true);
        count++;
    }

    public void disableFive()
    {
        five.gameObject.SetActive(false);
        af.gameObject.SetActive(true);
        count++;
    }

    public void disableSix()
    {
        six.gameObject.SetActive(false);
        sa.gameObject.SetActive(true);
        count++;
    }

    public void disableSeven()
    {
        seven.gameObject.SetActive(false);
        na.gameObject.SetActive(true);
        count++;
    }

    public void disableEight()
    {
        falseIsland.gameObject.SetActive(true);
        falseKenyia.gameObject.SetActive(false);
        falseMaroc.gameObject.SetActive(false);
        falseTunis.gameObject.SetActive(false);
    }

    public void disableNine()
    {
        falseIsland.gameObject.SetActive(false);
        falseKenyia.gameObject.SetActive(true);
        falseMaroc.gameObject.SetActive(false);
        falseTunis.gameObject.SetActive(false);
    }

    public void disableTen()
    {
        falseIsland.gameObject.SetActive(false);
        falseKenyia.gameObject.SetActive(false);
        falseMaroc.gameObject.SetActive(true);
        falseTunis.gameObject.SetActive(false);
    }

    public void disableEleven()
    {
        falseIsland.gameObject.SetActive(false);
        falseKenyia.gameObject.SetActive(false);
        falseMaroc.gameObject.SetActive(false);
        falseTunis.gameObject.SetActive(true);
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
