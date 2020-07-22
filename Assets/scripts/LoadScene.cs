using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.IO;

public class LoadScene : MonoBehaviour {

	//public Slider slider;

	public void loadScene (int sceneIndex)
	{
		StartCoroutine (loadAsync(sceneIndex));
	}

	IEnumerator loadAsync (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / .9f);
			//slider.value = progress;  
			yield return null;
		}
	} 
}