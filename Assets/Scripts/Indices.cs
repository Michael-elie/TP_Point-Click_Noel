using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Indices : MonoBehaviour
{
    [SerializeField] private bool IsSelected;
    [SerializeField] private  Button pickUpButton;
    
    public  Image ItemIcon;
    [SerializeField] private AudioSource PickUpSong;
     private Inventory _inventory;

    

    private void Start()
    {
        _inventory = FindObjectOfType<Inventory>();
        IsSelected = false;
        pickUpButton.interactable = false;
        pickUpButton.onClick.AddListener(pickup);
       
    }

    private void Update()
    {
       
    }


    private void OnMouseDown()
    {
        foreach (Indices indices in _inventory._indicesList )
        {
            indices.IsSelected = false;
            Debug.Log(indices.name);
        }
       
        IsSelected = true;
        Debug.Log("selectionné");
        
    }
    
    void pickup()
    {
        if (IsSelected == true  )
        {
            ItemIcon.GetComponent<Image>().color = Color.white;
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            PickUpSong.Play();
           _inventory.IndiceUpdate();
          

        }
      
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag =="Player" && IsSelected==true)
        {
            pickUpButton.interactable = true;
          
           
         
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pickUpButton.interactable = false; 
           
        }
       
    }

    
    
}
