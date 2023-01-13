using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
     private Inventory _inventory;
    private bool Win = false;
  private Indices _indices; 
  
    void Start()
    {
        _inventory = FindObjectOfType<Inventory>();
    }
    
    void Update()
    {
        if (_inventory.IndiceNumber == 6f)
        {
            Debug.Log("win");
         Win = true;
        }
    }
    



}
