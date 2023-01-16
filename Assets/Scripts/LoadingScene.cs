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
   public void Start()
   {
       //LoadingScreen.SetActive(false);
   }

   public void LoadScene(int sceneId)
   {
       StartCoroutine(LoadSceneAsync(sceneId));
   }

   IEnumerator LoadSceneAsync(int sceneId)
   {
       AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
       
       LoadingScreen.SetActive(true);

       while (!operation.isDone)
           
       {
           float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
           Slider.value = progressValue;
           ProgressText.text = progressValue * 100f + "%";
           Debug.Log(operation.progress);
           yield return null; 
       }
   }


}
