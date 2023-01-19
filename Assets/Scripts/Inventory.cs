using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour

{
   
   [SerializeField] public List<Indices> _indicesList;
   private Indices _indices;
   public TextMeshProUGUI IndiceText; 
  public float IndiceNumber = 7f ;
  [SerializeField] private  Button BookButton;
  public  Image Booksprite;
 
  
  
    
   public void Start()
   {
       _indices = FindObjectOfType<Indices>();
       BookButton.interactable = false;
   }

   public void Update()
   {
       if (  Booksprite.GetComponent<Image>().color == Color.white)
       {
           BookButton.interactable = true;
       }

     
   }

   public void IndiceUpdate()
   {
       IndiceNumber = IndiceNumber -1f ;
       IndiceText.text = IndiceNumber +  " Clues left";
   }
   
}

