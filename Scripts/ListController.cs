using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodoManagment;
using UnityEditor;


public class ListController: MonoBehaviour
{
    
    public Nodo current = null;
    //Objetos
    public GameObject[] coords;
    LinkedList ll = new LinkedList();
    public Nodo selecter = null;
    
    void Start()
    {
        //añadir nodos
        for (int i = 0; i < coords.Length; i++)
        {
            if (coords[i].name == "VisitPrison")
            {
                ll.add_jail(coords[i]);
            }
            else
            {
                ll.addnode(coords[i]);
            }
        }
        
        selecter = ll.PTR.next;
        current = ll.PTR;

        
    }



    public void actualizarpos()
    {
        selecter = selecter.next;
        current = current.next;

    }
    public void go_jail()
    {
        selecter = ll.jail.next; 
        current = ll.jail;
    }
}
  