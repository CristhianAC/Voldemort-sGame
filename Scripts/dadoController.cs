using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadoController : MonoBehaviour
{
    public int dadospos;
    public Animator animator;
    
    
    void Start()
    {
          animator = GetComponent<Animator>();  
        
        
    }



    public void movedice()
    {
        FindObjectOfType<AudioController>().Play("MoverDados");
        dadospos = Random.Range(1, 6);
        
        switch (dadospos)
        {       
            case 1:
                animator.Play("Rotacion=1",0);
                break;

            case 2:
                animator.Play("Rotacion=2",0);
                break;

            case 3:
                animator.Play("Rotacion=3", 0);
                break;

            case 4:
                animator.Play("Rotacion=4",0);

                break;

            case 5:
                animator.Play("Rotacion=5", 0);
                break;

            case 6:
                animator.Play("Rotacion=6", 0);
                break;  

        }
        
    }

}
