using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickManager : MonoBehaviour
{
    private Vector2 followSpot;
    public float speed;

    private Animator _animator;

    private Vector2 StuckDistanceCheck;

    private RaycastHit2D hit;

    [SerializeField] private TextMeshProUGUI NameItem;
   
   
    void Start()
    {
        followSpot = transform.position;

        _animator = GetComponent<Animator>();
    }
    
    

    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !IsMouseOverUI())
        {
            followSpot = new Vector2(mousePosition.x, mousePosition.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
        UpdateAnimation();
        DetecteItem();
        
        
        
        
    }


    void DetecteItem()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Affichage du Nom des objets quand on passe la souris dessus
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (hit.collider != null)
        {
            NameItem.GetComponent<TextMeshProUGUI>().text = (hit.collider.gameObject.name);
            
        }
        else
        {
            NameItem.GetComponent<TextMeshProUGUI>().text = null;
        }

    }

    // Empecher la souris de passer derriere l'UI
    
    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
    
    
    

    private void OnCollisionStay2D(Collision2D collision)
    {
        followSpot = transform.position;
    }


    private void UpdateAnimation() //changement d'animation du personnage
    {
        float distance = Vector2.Distance(transform.position, followSpot);
       /* if (Vector2.Distance(StuckDistanceCheck, transform.position) == 0)
        {
            _animator.SetFloat("distance",0.0f); return;
            
        }
        */
        
        _animator.SetFloat("distance",distance);
        if (distance > 0.01f)
        {
            Vector3 direction = transform.position - new Vector3(followSpot.x, followSpot.y, transform.position.z);
            float angle = Mathf.Atan2(direction.x,direction.y) * Mathf.Rad2Deg;
            _animator.SetFloat("angle",angle);
           // StuckDistanceCheck = transform.position;
        }
        
        
       
    }
}
