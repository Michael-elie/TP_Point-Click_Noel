using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
     private Inventory _inventory;
     private Indices _indices;
     [SerializeField] private AudioSource Winsound;
  
    void Start()
    {
       
        _inventory = FindObjectOfType<Inventory>();
    }
    
    void Update()
    {
      
        if (_inventory.IndiceNumber == 0f)
        {
            Winsound.Play();
            StartCoroutine(WaitScene());   
            WinMenu();
        }
    }

    void WinMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator WaitScene()
    {
        yield return new WaitForSeconds(5);
    }
    
    



}
