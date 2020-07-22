using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Control : MonoBehaviour {

	static System.Random random = new System.Random();

	public GameObject templateAF, templateNA, templateSA, templateAS, templateAU, templateEU;
	public GameObject correctAF, correctNA, correctSA, correctAS, correctAU, correctEU;
	//public GameObject AF, NA, SA, AS, AU, EU;
	//public GameObject successAudio, successAudio1, successAudio2, successAudio3, successAudio4, successAudio5, successAudio6;
	//public GameObject cliqueAF, cliqueNA, cliqueSA, cliqueAS, cliqueAU, cliqueEU;

	public GameObject win;
	public GameObject suivant;
	public GameObject exit;
	public GameObject musicOn;
	public GameObject musicOff;
	public GameObject audio;

	private bool isPlay = true;
	private int rn;
	private int choix = 0;
	private static int count = 0;

	LoadScene playGame;

	List<int> usedValues = new List<int>();

	public void Start()
	{
		win.SetActive(false);
		suivant.SetActive(false);
		exit.SetActive(false);

		correctAF.SetActive(false);
		correctNA.SetActive(false);
		correctSA.SetActive(false);
		correctAS.SetActive(false);
		correctAU.SetActive(false);
		correctEU.SetActive(false);

		templateAF.SetActive(true);
		templateNA.SetActive(true);
		templateSA.SetActive(true);
		templateAS.SetActive(true);
		templateAU.SetActive(true);
		templateEU.SetActive(true);

		AfriqueMap.locked = false;
		AmeriqueNordMap.locked = false;
		AmeriqueSudMap.locked = false;
		AsieMap.locked = false;
		AustralieMap.locked = false;
		EuropeMap.locked = false;

		/*falseAF.SetActive(false);
		falseNA.SetActive(false);
		falseSA.SetActive(false);
		falseAS.SetActive(false);
		falseAU.SetActive(false);
		falseEU.SetActive(false);*/

		/*cliqueAF.SetActive(true);
		cliqueNA.SetActive(true);
		cliqueSA.SetActive(true);
		cliqueAS.SetActive(true);
		cliqueAU.SetActive(true);
		cliqueEU.SetActive(true);*/

		//playingAgain();
	}

	public void Update()
	{
		if(AfriqueMap.locked )
		{
			correctAF.SetActive(true);
		}

		if(AmeriqueNordMap.locked)
		{
			correctNA.SetActive(true);
		}

		if(AmeriqueSudMap.locked)
		{
			correctSA.SetActive(true);
		}

		if(AsieMap.locked )
		{
			correctAS.SetActive(true);
		}

		if(AustralieMap.locked)
		{
			correctAU.SetActive(true);
		}

		if(EuropeMap.locked)
		{
			correctEU.SetActive(true);
		}

		//playingAgain();

		//AfriqueMap.locked && AmeriqueNordMap.locked && AmeriqueSudMap.locked && AsieMap.locked && AustralieMap.locked && EuropeMap.locked

		if(AfriqueMap.locked && AmeriqueNordMap.locked && AmeriqueSudMap.locked && AsieMap.locked && AustralieMap.locked && EuropeMap.locked)
		{
			win.SetActive(true);
			suivant.SetActive(true);
			exit.SetActive(true);
		}
	}

	/*public void playingAgain()
	{
		usedValues.Add(choix);
		if(count != 6)
		{
			do
			{
				choix = generateRandomNumber();
				generateRandomTemplate(choix);
			} while(usedValues.Contains(choix));
		}

	}*/

	/*public int generateRandomNumber()
	{
		rn = random.Next(6) + 1;
		return rn;
	}

	public void generateRandomTemplate(int num)
	{
		
		switch(num)
		{
			case 1:
				templateAF.SetActive(true);
				templateNA.SetActive(false);
				templateSA.SetActive(false);
				templateAS.SetActive(false);
				templateAU.SetActive(false);
				templateEU.SetActive(false);
				break;
			case 2:
				templateAF.SetActive(false);
				templateNA.SetActive(true);
				templateSA.SetActive(false);
				templateAS.SetActive(false);
				templateAU.SetActive(false);
				templateEU.SetActive(false);
				break;
			case 3:
				templateAF.SetActive(false);
				templateNA.SetActive(false);
				templateSA.SetActive(true);
				templateAS.SetActive(false);
				templateAU.SetActive(false);
				templateEU.SetActive(false);
				break;
			case 4:
				templateAF.SetActive(false);
				templateNA.SetActive(false);
				templateSA.SetActive(false);
				templateAS.SetActive(true);
				templateAU.SetActive(false);
				templateEU.SetActive(false);
				break;
			case 5:
				templateAF.SetActive(false);
				templateNA.SetActive(false);
				templateSA.SetActive(false);
				templateAS.SetActive(false);
				templateAU.SetActive(true);
				templateEU.SetActive(false);
				break;
			case 6:
				templateAF.SetActive(false);
				templateNA.SetActive(false);
				templateSA.SetActive(false);
				templateAS.SetActive(false);
				templateAU.SetActive(false);
				templateEU.SetActive(true);
				break;
		}
	}*/

	/*public void disableAfrique()
	{
		if(choix == 1)
		{
			templateAF.SetActive(false);
			correctAF.SetActive(true);
			cliqueAF.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateAF.SetActive(true);
				correctAF.SetActive(false);
				falseAF.SetActive(true);
			}
	}

	public void disableNordA()
	{
		if(choix == 2)
		{
			templateNA.SetActive(false);
			correctNA.SetActive(true);
			cliqueNA.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateNA.SetActive(true);
				correctNA.SetActive(false);
				falseNA.SetActive(true);
			}
	}

	public void disableSudA()
	{
		if(choix == 3)
		{
			templateSA.SetActive(false);
			correctSA.SetActive(true);
			cliqueSA.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateSA.SetActive(true);
				correctSA.SetActive(false);
				falseSA.SetActive(true);
			}
	}

	public void disableAsie()
	{
		if(choix == 4)
		{
			templateAS.SetActive(false);
			correctAS.SetActive(true);
			cliqueAS.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateAS.SetActive(true);
				correctAS.SetActive(false);
				falseAS.SetActive(true);
			}
	}

	public void disableAustralie()
	{
		if(choix == 5)
		{
			templateAU.SetActive(false);
			correctAU.SetActive(true);
			cliqueAU.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateAU.SetActive(true);
				correctAU.SetActive(false);
				falseAU.SetActive(true);
			}
	}

	public void disableEurope()
	{
		if(choix == 6)
		{
			templateEU.SetActive(false);
			correctEU.SetActive(true);
			cliqueEU.SetActive(false);
			falseAF.SetActive(false);
			falseNA.SetActive(false);
			falseSA.SetActive(false);
			falseAS.SetActive(false);
			falseAU.SetActive(false);
			falseEU.SetActive(false);
			StartCoroutine(wait());
			count++;
		} else 
			{
				//templateEU.SetActive(true);
				correctEU.SetActive(false);
				falseEU.SetActive(true);
			}
	}*/

	/*private IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        playingAgain();
    }*/

    public void nextScene()
	{
		playGame = suivant.AddComponent<LoadScene>();
		playGame.loadScene(6);
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
            musicOn.SetActive(false);
            musicOff.SetActive(true);
            audio.SetActive(false);
        }
        else
        {
            isPlay = true;
            musicOn.SetActive(true);
            musicOff.SetActive(false);
            audio.SetActive(true);
        }

    }


}