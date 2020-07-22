using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8Control : MonoBehaviour {

	static System.Random random = new System.Random();

	public GameObject flagAF, flagNA, flagSA, flagAS, flagAU, flagEU;
	public GameObject correctAF, correctNA, correctSA, correctAS, correctAU, correctEU;
	public GameObject incorrectAF, incorrectNA, incorrectSA, incorrectAS, incorrectAU, incorrectEU;
	public GameObject cliqueAF, cliqueNA, cliqueSA, cliqueAS, cliqueAU, cliqueEU;

	public GameObject win;
	public GameObject suivant;
	public GameObject exit;
	public GameObject musicOn;
	public GameObject musicOff;
	public GameObject audio;

	private bool isPlay = true;
	private int rn;
	private int choix = 0;
	private static int count;

	LoadScene playGame;

	List<int> usedValues = new List<int>();

	public void Start()
	{
		count = 0;

		win.SetActive(false);
		suivant.SetActive(false);
		exit.SetActive(false);
		//incorrect.SetActive(false);

		correctAF.SetActive(false);
		correctNA.SetActive(false);
		correctSA.SetActive(false);
		correctAS.SetActive(false);
		correctAU.SetActive(false);
		correctEU.SetActive(false);

		incorrectAF.SetActive(false);
		incorrectNA.SetActive(false);
		incorrectSA.SetActive(false);
		incorrectAS.SetActive(false);
		incorrectAU.SetActive(false);
		incorrectEU.SetActive(false);

		flagAF.SetActive(false);
		flagNA.SetActive(false);
		flagSA.SetActive(false);
		flagAS.SetActive(false);
		flagAU.SetActive(false);
		flagEU.SetActive(false);

		cliqueAF.SetActive(true);
		cliqueNA.SetActive(true);
		cliqueSA.SetActive(true);
		cliqueAS.SetActive(true);
		cliqueAU.SetActive(true);
		cliqueEU.SetActive(true);

		playingAgain();
	}

	public void Update()
	{
		if(count == 6)
		{
			win.SetActive(true);
			suivant.SetActive(true);
			exit.SetActive(true);
		}
	}

	public void playingAgain()
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

	}

	public int generateRandomNumber()
	{
		rn = random.Next(6) + 1;
		return rn;
	}

	public void generateRandomTemplate(int num)
	{
		
		switch(num)
		{
			case 1:
				flagAF.SetActive(true);
				flagNA.SetActive(false);
				flagSA.SetActive(false);
				flagAS.SetActive(false);
				flagAU.SetActive(false);
				flagEU.SetActive(false);
				break;
			case 2:
				flagAF.SetActive(false);
				flagNA.SetActive(true);
				flagSA.SetActive(false);
				flagAS.SetActive(false);
				flagAU.SetActive(false);
				flagEU.SetActive(false);
				break;
			case 3:
				flagAF.SetActive(false);
				flagNA.SetActive(false);
				flagSA.SetActive(true);
				flagAS.SetActive(false);
				flagAU.SetActive(false);
				flagEU.SetActive(false);
				break;
			case 4:
				flagAF.SetActive(false);
				flagNA.SetActive(false);
				flagSA.SetActive(false);
				flagAS.SetActive(true);
				flagAU.SetActive(false);
				flagEU.SetActive(false);
				break;
			case 5:
				flagAF.SetActive(false);
				flagNA.SetActive(false);
				flagSA.SetActive(false);
				flagAS.SetActive(false);
				flagAU.SetActive(true);
				flagEU.SetActive(false);
				break;
			case 6:
				flagAF.SetActive(false);
				flagNA.SetActive(false);
				flagSA.SetActive(false);
				flagAS.SetActive(false);
				flagAU.SetActive(false);
				flagEU.SetActive(true);
				break;
		}
	}

	public void disableAfrique()
	{
		if(choix == 1)
		{
			flagAF.SetActive(false);
			correctAF.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);
			cliqueAF.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagAF.SetActive(true);
				correctAF.SetActive(false);
				incorrectAF.SetActive(true);
				/*incorrectNA.SetActive(false);
				incorrectSA.SetActive(false);
				incorrectAS.SetActive(false);
				incorrectAU.SetActive(false);
				incorrectEU.SetActive(false);*/

			}
	}

	public void disableNordA()
	{
		if(choix == 2)
		{
			flagNA.SetActive(false);
			correctNA.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);

			cliqueNA.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagNA.SetActive(true);
				correctNA.SetActive(false);
				incorrectNA.SetActive(true);
				/*incorrectAF.SetActive(false);
				incorrectSA.SetActive(false);
				incorrectAS.SetActive(false);
				incorrectAU.SetActive(false);
				incorrectEU.SetActive(false);*/

			}
	}

	public void disableSudA()
	{
		if(choix == 3)
		{
			flagSA.SetActive(false);
			correctSA.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);

			cliqueSA.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagSA.SetActive(true);
				correctSA.SetActive(false);
				incorrectSA.SetActive(true);
				/*incorrectAF.SetActive(false);
				incorrectNA.SetActive(false);
				incorrectAS.SetActive(false);
				incorrectAU.SetActive(false);
				incorrectEU.SetActive(false);*/

			}
	}

	public void disableAsie()
	{
		if(choix == 4)
		{
			flagAS.SetActive(false);
			correctAS.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);

			cliqueAS.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagAS.SetActive(true);
				correctAS.SetActive(false);
				incorrectAS.SetActive(true);
				/*incorrectAF.SetActive(false);
				incorrectNA.SetActive(false);
				incorrectSA.SetActive(false);
				incorrectAU.SetActive(false);
				incorrectEU.SetActive(false);*/

			}
	}

	public void disableAustralie()
	{
		if(choix == 5)
		{
			flagAU.SetActive(false);
			correctAU.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);

			cliqueAU.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagAU.SetActive(true);
				correctAU.SetActive(false);
				incorrectAU.SetActive(true);
				/*incorrectAF.SetActive(false);
				incorrectNA.SetActive(false);
				incorrectSA.SetActive(false);
				incorrectAS.SetActive(false);
				incorrectEU.SetActive(false);*/

			}
	}

	public void disableEurope()
	{
		if(choix == 6)
		{
			flagEU.SetActive(false);
			correctEU.SetActive(true);
			incorrectAF.SetActive(false);
			incorrectNA.SetActive(false);
			incorrectSA.SetActive(false);
			incorrectAS.SetActive(false);
			incorrectAU.SetActive(false);
			incorrectEU.SetActive(false);

			cliqueEU.GetComponent<Button>().interactable = false;
			StartCoroutine(wait());
			count++;
		} else 
			{
				//flagEU.SetActive(true);
				correctEU.SetActive(false);
				incorrectEU.SetActive(true);
				/*incorrectAF.SetActive(false);
				incorrectNA.SetActive(false);
				incorrectSA.SetActive(false);
				incorrectAS.SetActive(false);
				incorrectAU.SetActive(false);*/

			}
	}

	private IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        playingAgain();
    }

    public void nextScene()
	{
		playGame = suivant.AddComponent<LoadScene>();
		playGame.loadScene(7);
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