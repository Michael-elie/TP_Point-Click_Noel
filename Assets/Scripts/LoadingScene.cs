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
       LoadingScreen.SetActive(true);
       yield return new WaitForSeconds(1); 
       AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
 
        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            Slider.value = progressValue;
            ProgressText.text = progressValue * 100 + "%";
            
            //Debug.Log(progressValue);
            yield return null; 
        }
   }


}
