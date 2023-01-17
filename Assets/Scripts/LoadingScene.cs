using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour
{
   public GameObject LoadingScreen ;
   public Slider Slider;
   public TextMeshProUGUI ProgressText;
   

   public void LoadScene(int sceneIndex)
   {
       StartCoroutine(LoadSceneAsync(sceneIndex));
   }

   IEnumerator LoadSceneAsync(int sceneIndex)
   {
       AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
       
       LoadingScreen.SetActive(true);

       while (!operation.isDone)
           
       {
           float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
           Slider.value = progressValue;
           ProgressText.text = progressValue * 100f + "%";
           Debug.Log(progressValue);
           yield return null; 
       }
   }


}
