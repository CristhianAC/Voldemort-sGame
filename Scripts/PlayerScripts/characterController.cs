using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterController : MonoBehaviour
{
    public int no_carcel = 0;
    public int dias_carcel = 0;
    public bool free = true;
    public float dinero = 1500;
    Rigidbody rigid;
    Animator anim;
    
    [SerializeField] private float vel=5;
    
    public bool nextPos = false;
    
   
    
    public ListController listController;
    public GameController gameController;
    Transform este;
  
    
    
    
    private int cantidadDePasos;



    public void setCantidadDePasos(int cantidad)
    {
        cantidadDePasos = cantidad;
    }
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        este = GetComponent<Transform>();
    }

    
    void Update()
    {
        if (nextPos)
        {
            caminar();
        }
        if (dias_carcel == 0) 
            free= true;
        if (!free)
        {
            encarcelar();
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nodo")
        {
            listController.actualizarpos();
            cantidadDePasos = cantidadDePasos - 1;
            if (other.gameObject.name == "Home")
            {
                dinero += 200;
            }
        }
    }
    public void encarcelar()
    {
        este.position =
        new Vector3((6.452f),
        (este.transform.position.y),(5.5133f));
        listController.go_jail();

    }
    private void OnTriggerExit(Collider other)
    {
        if (cantidadDePasos == 0)
        {
            gameController.check(listController.current);
            nextPos = false;
            anim.SetBool("Walking", false);
            
            

            
        }
  
    }
    private void caminar()
    {
        anim.SetBool("Walking", true);
        Vector3 posicion = (listController.selecter.objeto.transform.position);
        
        float anguloRadianes = Mathf.Atan2(posicion.z -transform.position.z  , transform.position.x -posicion.x);
        float anguloGrados = (180/Mathf.PI) * anguloRadianes-90;
        transform.rotation = Quaternion.Euler(0, anguloGrados, 0);
        
        transform.position = Vector3.MoveTowards(transform.position, posicion, vel * Time.deltaTime);
    }
    
    

}
