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
 

 
  
  
    
   public void Start()
   {
       _indices = FindObjectOfType<Indices>();

   }

   public void Update()
   {
      
   }

   public void IndiceUpdate()
   {
       IndiceNumber = IndiceNumber -1f ;
       IndiceText.text = IndiceNumber +  " Clues left";
   }
   
}

