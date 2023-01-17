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
      
        if (_inventory.IndiceNumber == 6f)
        {
            Winsound.Play();
            WinMenu();
        }
    }

    void WinMenu()
    {
       
        StartCoroutine(WaitScene());   
       
    }
    IEnumerator WaitScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    



}
